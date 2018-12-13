namespace TrelloFurikaerier.Dto
{
    public class Board
    {
        public string shortLink { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public Prefs2 prefs { get; set; }
    }
}