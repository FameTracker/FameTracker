using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreTweet;
using CoreTweet.Streaming;
using static System.Console;

namespace FameTracker.Features.Twitter
{
    public class TwitterService
    {
        public List<Tweet> FetchTweets()
        {
            var bearer =
                "AAAAAAAAAAAAAAAAAAAAAGF1awEAAAAAtSpS4t92J9BBIwfKlYoVP54qsvQ%3DHwxGnkptvwuqwPWuDGRT0rZ5AzjbUfbJCJQiZB9YEa9R0vDVcB";
            var api = OAuth.Authorize("2pjpUtLc9mlQSEd8EnxQp3XEf",
                "gTEXKl8FYucqy41Ps4lfQUVVPoU4Xa69kmSzp31Cp0KqtgLkDB");
            var token = api.GetTokens("1302297702827520004-0jgY8UDiyOFDfoOCSCzAsQdpGMkHDB");

            List<Tweet> Tweets = new List<Tweet>();

            foreach (var m in token.Streaming.Filter(track => "tea")
                         .OfType<StatusMessage>()
                         .Select(x => x.Status)
                         .Take(10))
            {
                WriteLine("about tea by {0}: {1}", m.User.ScreenName, m.Text);
                Tweets.Add(new Tweet()
                {
                    User = m.User.ScreenName,
                    Text = m.Text
                });
            }

            return Tweets;
        }
    }
}