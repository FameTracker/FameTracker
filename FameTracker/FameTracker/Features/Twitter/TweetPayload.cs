using System;
using System.Collections.Generic;

namespace FameTracker.Features.Twitter
{
    public class TweetPayload
    {
        public List<TweetData> data { get; set; }
        public Meta meta { get; set; }
    }
    
    public class TweetData
    {
        public DateTime created_at { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }


    public class Meta
    {
        public string newest_id { get; set; }
        public string oldest_id { get; set; }
        public int result_count { get; set; }
        public string next_token { get; set; }
    }
}