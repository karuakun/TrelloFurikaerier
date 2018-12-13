namespace TrelloFurikaerier.Dto
{
    public class List2
    {
        public string id { get; set; }
        public string name { get; set; }
        public bool closed { get; set; }
        public string idBoard { get; set; }
        public double pos { get; set; }
        public bool subscribed { get; set; }
        public Limits4 limits { get; set; }
        public object creationMethod { get; set; }
    }
}