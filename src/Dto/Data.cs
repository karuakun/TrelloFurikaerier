namespace TrelloFurikaerier.Dto
{
    public class Data
    {
        public Member member { get; set; }
        public Board board { get; set; }
        public Card card { get; set; }
        public string idMember { get; set; }
        public List list { get; set; }
        //public Old old { get; set; }
        public bool? deactivated { get; set; }
        public string text { get; set; }
        public ListAfter listAfter { get; set; }
        public ListBefore listBefore { get; set; }
        public string idMemberAdded { get; set; }
        public string memberType { get; set; }
    }
}