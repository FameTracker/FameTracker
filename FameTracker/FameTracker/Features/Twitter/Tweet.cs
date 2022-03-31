using System;

namespace FameTracker.Features.Twitter
{
    public class Tweet
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string User { get; set; }
        public string Username { get; set; }
        public string ProfileImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}