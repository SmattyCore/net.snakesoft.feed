using System;
using System.ServiceModel.Syndication;

namespace SnakeSoft.Feed.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            SyndicationFeed feed = SnakeSoft.Feed.Feed.GetFeed("https://smattycore.de/feed");
            Console.WriteLine($"Title: {feed.Title.Text}");

            foreach (var item in feed.Items)
            {
                Console.Write($"Title: {item.Title.Text}\n" +
                    $"Author: {item.GetDcCreator()}\n" +
                    $"Comments-URL: {item.GetCommentsUrl()}\n" +
                    $"Comments-Count: {item.GetCommentsCount()}\n" +
                    $"Content: {item.GetEncodedContent()}\n\n\n\n");
            }
        }
    }
}