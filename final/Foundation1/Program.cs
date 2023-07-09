using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
                List<Video> videos = new List<Video>();

        // Create videos with comments
        Video video1 = new Video
        {
            Title = "Video 1",
            Author = "Author 1",
            LengthInSeconds = 120,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "User1", Text = "Comment 1" },
                new Comment { CommenterName = "User2", Text = "Comment 2" },
                new Comment { CommenterName = "User3", Text = "Comment 3" }
            }
        };
        videos.Add(video1);

        Video video2 = new Video
        {
            Title = "Video 2",
            Author = "Author 2",
            LengthInSeconds = 180,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "User4", Text = "Comment 4" },
                new Comment { CommenterName = "User5", Text = "Comment 5" }
            }
        };
        videos.Add(video2);

        Video video3 = new Video
        {
            Title = "Video 3",
            Author = "Author 3",
            LengthInSeconds = 240,
            Comments = new List<Comment>
            {
                new Comment { CommenterName = "User6", Text = "Comment 6" },
                new Comment { CommenterName = "User7", Text = "Comment 7" },
                new Comment { CommenterName = "User8", Text = "Comment 8" }
            }
        };
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.LengthInSeconds}");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}