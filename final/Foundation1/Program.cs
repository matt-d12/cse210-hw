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
        Video v2 = new Video("Video 2", "Matthew", 200);
        v2.AddComment(new Comment("Person 1", "Comment 1."));
        v2.AddComment(new Comment("Person 2", "Comment 2."));
        v2.AddComment(new Comment("Person 3", "Comment 3."));
        videos.Add(v2);

        //Video 3
        Video v3 = new Video("Video 3", "Dunkin", 300);
        v3.AddComment(new Comment("Person 1", "Comment 1."));
        v3.AddComment(new Comment("Person 2", "Comment 2."));
        v3.AddComment(new Comment("Person 3", "Comment 3."));
        videos.Add(v3);

        //Display info for videos
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }

    }
}