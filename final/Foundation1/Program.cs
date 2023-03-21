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

        Video video1 = new Video("Monkey Spinning","Monkey",600,comments1);
        

        Console.WriteLine(video1.CommentsCount());
        Console.WriteLine(video1.GetVideo());
        video1.DisplayComments();
    }
}