using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();
        Console.WriteLine();

        Video video1 = new Video("OnePlus 13 vs 13r Durability Test! - One is not like the other...", "JerryRigEverything", 420);
        video1.GetComment("RensKIngma", "My cat started attacking the tv speakers because of the scratching sounds hahaha");
        video1.GetComment("faiz697", "\"2019 was 6 years ago\".. that hurts right in the fell bro");
        video1.GetComment("g6autobot", "Save the 300 dollars the 13R is a good looking phone! Thank for the videos.");
        videos.Add(video1);

        Video video2 = new Video("Stop Using Pixels For Media Queries", "Web Dev Simplified", 1080);
        video2.GetComment("zedpoutine", "r.e.m.'s biggest hit: Losing My Pixels");
        video2.GetComment("theo-k4i8m", "6 years later I'm still coming to class.\nThanks kyle");
        video2.GetComment("thirdreplicator", "His head is bobbing more these days.");
        videos.Add(video2);

        Video video3 = new Video("The RTX 5090 - Our Biggest Review Ever", "Linus Tech Tips", 1380);
        video3.GetComment("internet2oup650", "the biggest advancement this generation was the cooler shrinking to 1/2 the 40 series sizes");
        video3.GetComment("mdyusufzaman9356", "\"frame generation work's the best when it makes the least sense to use it\"");
        video3.GetComment("MobikSaysStuff", "My entire PC costs this much, lmao");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
        }
    }
}