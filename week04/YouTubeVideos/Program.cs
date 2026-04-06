using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("My Research Talk", "Doris Amuji", 600);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Very helpful."));
        video1.AddComment(new Comment("Charlie", "Thanks!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Health Podcasts", "Doris Nnenna", 800);
        video2.AddComment(new Comment("David", "Nice explanation."));
        video2.AddComment(new Comment("Ella", "Loved it!"));
        video2.AddComment(new Comment("Frank", "Clear and simple."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Relationship Talk", "Nedu Anadozie", 1200);
        video3.AddComment(new Comment("Grace", "This was deep."));
        video3.AddComment(new Comment("Henry", "Learned a lot."));
        video3.AddComment(new Comment("Ivy", "Awesome content."));
        videos.Add(video3);

        // Display all videos
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Name}: {comment.Text}");
            }

            Console.WriteLine("-----------------------------");
        }
    }
}