using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("Top 10 Tech Gadgets You Need in 2024", "TechGuru Alex", 300);
        Video video2 = new Video("The Best Kitchen Gadgets for Quick and Easy Meals", "Cooking with Chef Mia", 450);
        Video video3 = new Video("Travel Must-Haves: Gear That Makes Your Trips Easier", "Wanderpro Jake", 600);

        // Add comments to video 1
        video1.AddComment(new Comment("SarahB87", "Great video!"));
        video1.AddComment(new Comment("TechFanatic", "Thanks for sharing."));
        video1.AddComment(new Comment("Gadget_geek", "Very informative."));

        // Add comments to video 2
        video2.AddComment(new Comment("FoodieFrank", "Awesome content."));
        video2.AddComment(new Comment("MandyQ55", "Loved it."));
        video2.AddComment(new Comment("ChefChioma", "Well explained."));

        // Add comments to video 3
        video3.AddComment(new Comment("Alex_pane33", "Fantastic video."));
        video3.AddComment(new Comment("WandererMike", "Learned a lot!"));
        video3.AddComment(new Comment("TravelMike", "Keep it up."));

        // Add videos to a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display the video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}

    
