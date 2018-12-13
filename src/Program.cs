using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using TrelloFurikaerier.Dto;

namespace TrelloFurikaerier
{
    public class Program
    {
        private static AppSettings _settings;
        public static async Task Main(string[] args)
        {
            Initialize(args);
            if (null == _settings)
            {
                Console.WriteLine("invalid arguments. require appsettings.json or commandline args");
                return;
            }

            var exportFile = _settings.TrelloExportFile;
            if (!File.Exists(exportFile))
            {
                Console.WriteLine($"trello export file is not found. {_settings.TrelloExportFile}");
                return;
            }

            var jsonData = await File.ReadAllTextAsync(exportFile, Encoding.UTF8);
            if (string.IsNullOrEmpty(jsonData))
            {
                Console.WriteLine($"trello export data is empty. {exportFile}");
                return;
            }

            // Convert
            var data = JsonConvert.DeserializeObject<RootObject>(jsonData);
            var query = data.cards
                .GroupBy(c => c.idList)
                .Select(g => new
                {
                    List = data.lists.First(l => l.id == g.Key),
                    Cards = g.Select(c => new
                    {
                        c.id,
                        c.name,
                        createMember = data.actions
                            .Where(a => a.data.card?.id == c.id)
                            .Where(a => a.type == "createCard")
                            .Select(a => a.memberCreator.fullName)
                            .FirstOrDefault()
                    })
                })
                .ToList();

            // Export
            { 
                WriteQuoteStartTag();
                foreach (var q in query)
                {
                    WriteHeader(q.List.name);
                    foreach (var c in q.Cards)
                    {
                        var userName = _settings.ShowUser ? $"({c.createMember})" : string.Empty;
                        WriteList($"{c.name} {userName}");
                    }
                }
                WriteQuoteEndTag();
            }
        }

        private static void Initialize(string[] args)
        {
            _settings = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true)
                .AddCommandLine(args)
                .Build()
                .GetSection(AppSettings.SectionName).Get<AppSettings>();
        }

        private static void WriteQuoteStartTag() => Write(IsBacklog() ? "{quote}": "```" );
        private static void WriteQuoteEndTag() => Write(IsBacklog() ? "{/quote}" : "```");
        private static void WriteHeader(string message) => Write(IsBacklog() ? $"* {message}" : $"# {message}");
        private static void WriteList(string message) => Write($"- {message}");
        private static bool IsBacklog() => _settings.Format == "backlog";
        private static void Write(string message) => Console.WriteLine(message);
    }
}
