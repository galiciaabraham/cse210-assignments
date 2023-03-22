using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> comments1 = new List<Comment>{
        new Comment("3-21-2023","GeorgeTheFifth","amazing video!!"),
        new Comment("3-20-2023","VodiKid","Love it, I could watch it all day long"),
        new Comment("3-14-2023","Anonymous","Don't know how I got here but love it")
        };

        Video video1 = new Video("Monkey Spinning","Monkey",60000,comments1);

        List<Comment> comments2 = new List<Comment>{
        new Comment("2-12-2022","YourMan","love the song and product"),
        new Comment("4-5-2021","Zendaya3000","Can't believe how great this is..."),
        new Comment("6-1-2023","ALinkToDaPast","Not a fan of the ending :/")
        };

        Video video2 = new Video("Hello world","Louie Zong",240,comments2);

        List<Comment> comments3 = new List<Comment>{
        new Comment("8-15-2020","JustMe","What did I just watch?"),
        new Comment("9-12-2021","JustYou","I didn't really get what I whatched..."),
        new Comment("6-1-2022","AZeldaToDaPast","Hello! Visit my channel"),
        new Comment("12-31-2020","JustUs","Could've included more sprinkles")
        };

        Video video3 = new Video("My video this is","A human",360,comments3);

        List<Comment> comments4 = new List<Comment>{
        new Comment("9-20-2015","Mafalda","This is comming to teathers and broadway for sure!"),
        new Comment("6-30-2021","Condorito","Great idea!"),
        new Comment("7-9-2014","Thelibrarian","You could change the beginning"),
        new Comment("12-14-2020","ThatKid","First comment")
        };

        Video video4 = new Video("The grinch stole Halloween: A project idea","Seuss the Laywer",600,comments4);

        List<Video> videos = new List<Video>{};

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        foreach(Video video in videos)
        {
            
            Console.WriteLine(video.GetVideo());
            Console.Write("Number of comments:");
            Console.WriteLine(video.CommentsCount());
            video.DisplayComments();
            Console.WriteLine("");
        }
    }
}