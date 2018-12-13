using System;

namespace TrelloFurikaerier.Dto
{
    public class Action
    {
        public string id { get; set; }
        public string idMemberCreator { get; set; }
        public Data data { get; set; }
        public string type { get; set; }
        public DateTime date { get; set; }
        public Limits2 limits { get; set; }
        public Member2 member { get; set; }
        public MemberCreator memberCreator { get; set; }
    }
}