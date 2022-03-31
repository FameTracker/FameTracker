using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using LiteDB;
using Newtonsoft.Json;
using Xamarin.Forms.PlatformConfiguration;

namespace FameTracker.Features.Twitter
{
    public class TwitterService
    {
        TwitterDB db = new TwitterDB();
        public async Task<List<Tweet>> FetchTweets()
        {
            var bearer = "AAAAAAAAAAAAAAAAAAAAAGF1awEAAAAAIWPf0fzOC%2Fu2cBcig9gCPcW5AHk%3DmvqT2M1S2W9yIMkgkx2rvduv4tYCiNmQRJMGq1YwyDwaYJlAcf";
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearer);
            var jsonresponse = await client.GetStringAsync("https://api.twitter.com/2/tweets/search/recent?query=FameMMA%20OR%20Fame%20MMA&tweet.fields=created_at&max_results=20").ConfigureAwait(false);;
            var tweetresponse = JsonConvert.DeserializeObject<TweetPayload>(jsonresponse);

            return PackTweets(tweetresponse, client).Result;;
        }

        private async Task<List<Tweet>> PackTweets(TweetPayload response, HttpClient client)
        {
            List<Tweet> Tweets = new();
        
            for(int i = 0; i < response?.meta.result_count-1; i++)
            {
                var jsonresponse = await client.GetStringAsync("https://api.twitter.com/2/tweets/"+ response.data[i].id +"?expansions=author_id&user.fields=name,username,profile_image_url").ConfigureAwait(false);;
                var userresponse = JsonConvert.DeserializeObject<TweetUserPayload>(jsonresponse);
                    
                var tweet = new Tweet
                {
                    ProfileImageUrl = userresponse.includes.users.First().profile_image_url,
                    User = userresponse.includes.users.First().name,
                    Username = "@"+userresponse.includes.users.First().username,
                    Text = response.data[i].text,
                    CreatedAt = response.data[i].created_at,
                    Id = response.data[i].id
                };
                Tweets.Add(tweet);
            }
            
            var result = db.UpdateSavedTweets(Tweets);

            return result;
        }
    }
}