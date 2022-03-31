using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using LiteDB;
using Xamarin.Essentials;

namespace FameTracker.Features.Twitter
{
    
    public class TwitterDB
    {
        public List<Tweet> UpdateSavedTweets(List<Tweet> raw)
        {
            using (var db = new LiteDatabase(Path.Combine(FileSystem.AppDataDirectory,
                       "FameTrackerStorage_325532453.db")))
            {
                List<Tweet> tweets = new();
                var Collection = db.GetCollection<Tweet>("tweets");
                var SavedTweets = Collection.FindAll().ToList();
                foreach (var tweet in raw)
                {
                    if(!SavedTweets.Any(x => x.Id == tweet.Id) && tweet.Username != "@SocialTrendz24") // Social Trends generates unnecessary spam
                    {
                        tweets.Add(tweet);
                    }
                }
                
                foreach (var tweet in tweets)
                {
                    Collection.Insert(tweet);
                    SavedTweets.Add(tweet);
                }

                var result = from tweet in SavedTweets
                    orderby tweet.CreatedAt
                    select tweet;

                return Enumerable.Reverse(result).ToList();
            }
        }
    }
}