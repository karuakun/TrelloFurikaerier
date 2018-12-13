using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloFurikaerier
{
    public class AppSettings
    {
        public const string SectionName = "appSettings";
        public string TrelloExportFile { get; set; }
        public bool ShowUser { get; set; }

        public string Format { get; set; }

    }
}
