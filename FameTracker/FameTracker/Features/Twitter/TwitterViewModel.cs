using System.Collections.Generic;
using ReactiveUI;

namespace FameTracker.Features.Twitter
{
    public class TwitterViewModel : ReactiveObject
    {
        private readonly TwitterService _twitterService;

        public List<Tweet> GetTweets()
        {
            return _twitterService.FetchTweets();
        }
    }
}