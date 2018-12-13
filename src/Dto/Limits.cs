namespace TrelloFurikaerier.Dto
{
    public class Limits
    {
        public Attachments attachments { get; set; }
        public Boards boards { get; set; }
        public Cards cards { get; set; }
        public Checklists checklists { get; set; }
        public CustomFields customFields { get; set; }
        public Labels labels { get; set; }
        public Lists lists { get; set; }
    }
}