using System;

class Program
{
    static void Main(string[] args)
    {
        //Create list of videos
        List<Video> videos = new List<Video>();

        //Video 1 - Video(tile, author, length)
        Video v1 = new Video("Video 1", "Matt", 100);
        v1.AddComment(new Comment("Person 1", "Comment 1."));
        v1.AddComment(new Comment("Person 2", "Comment 2."));
        v1.AddComment(new Comment("Person 3", "Comment 3."));
        videos.Add(v1);

        //Video 2

        //Video 3

        //Display info for videos
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }

    }
}