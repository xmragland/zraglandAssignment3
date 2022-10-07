﻿namespace zraglandAssignment3.Models
{
    public class MovieDetailsVM
    {
        public Movie movie { get; set; }
        public List<MovieTweet>? Tweets { get; set; }
        public double AverageTweetSentiment()
        {
            if (Tweets == null) return 0;
            int validTweets = 0;
            double totalTweetScore = 0;
            foreach (MovieTweet tweet in Tweets)
            {
                if(tweet.Sentiment != 0)
                {
                    validTweets++;
                    totalTweetScore += tweet.Sentiment;
                }
            }

            return totalTweetScore / validTweets;
        }
    }
}
