using System;
using System.Collections.Generic;

namespace TrelloFurikaerier.Dto
{
    public class Card2
    {
        public string id { get; set; }
        public object checkItemStates { get; set; }
        public bool closed { get; set; }
        public object creationMethod { get; set; }
        public DateTime dateLastActivity { get; set; }
        public string desc { get; set; }
        public object descData { get; set; }
        public string idBoard { get; set; }
        public string idList { get; set; }
        public List<object> idMembersVoted { get; set; }
        public int idShort { get; set; }
        public object idAttachmentCover { get; set; }
        public Limits3 limits { get; set; }
        public List<object> idLabels { get; set; }
        public bool manualCoverAttachment { get; set; }
        public string name { get; set; }
        public double pos { get; set; }
        public string shortLink { get; set; }
        public Badges badges { get; set; }
        public bool dueComplete { get; set; }
        public object due { get; set; }
        public string email { get; set; }
        public List<object> idChecklists { get; set; }
        public List<object> idMembers { get; set; }
        public List<object> labels { get; set; }
        public string shortUrl { get; set; }
        public bool subscribed { get; set; }
        public string url { get; set; }
        public List<object> attachments { get; set; }
        public List<object> pluginData { get; set; }
        public List<object> customFieldItems { get; set; }
    }
}