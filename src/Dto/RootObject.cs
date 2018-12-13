using System;
using System.Collections.Generic;

namespace TrelloFurikaerier.Dto
{
    public class RootObject
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public object descData { get; set; }
        public bool closed { get; set; }
        public object idOrganization { get; set; }
        public Limits limits { get; set; }
        public bool pinned { get; set; }
        public bool starred { get; set; }
        public string url { get; set; }
        public Prefs prefs { get; set; }
        public string shortLink { get; set; }
        public bool subscribed { get; set; }
        public LabelNames labelNames { get; set; }
        public List<object> powerUps { get; set; }
        public DateTime dateLastActivity { get; set; }
        public DateTime dateLastView { get; set; }
        public string shortUrl { get; set; }
        public List<object> idTags { get; set; }
        public object datePluginDisable { get; set; }
        public object creationMethod { get; set; }
        public List<Action> actions { get; set; }
        public List<Card2> cards { get; set; }
        public List<Label> labels { get; set; }
        public List<List2> lists { get; set; }
        public List<Member3> members { get; set; }
        public List<object> checklists { get; set; }
        public List<object> customFields { get; set; }
        public List<Membership> memberships { get; set; }
        public List<object> pluginData { get; set; }
    }
}