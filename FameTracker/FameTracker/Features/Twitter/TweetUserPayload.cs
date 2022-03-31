using System.Collections.Generic;

namespace FameTracker.Features.Twitter
{
    public partial class TweetUserPayload
    {
        
    }
    
    public class Data
    {
        public string author_id { get; set; }
        public string id { get; set; }
        public string text { get; set; }
    }

    public class User
    {
        public string profile_image_url { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string id { get; set; }
    }

    public class Includes
    {
        public List<User> users { get; set; }
    }

    public partial class TweetUserPayload
    {
        public Data data { get; set; }
        public Includes includes { get; set; }
    }
}