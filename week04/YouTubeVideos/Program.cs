using System;
using System.Collections.Generic;

class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }

    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{Author}: {Text}");
    }
}

// Video class to store video details and comments
class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } 
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\nNumber of Comments: {GetNumberOfComments()}\n");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("---------------------------");
    }
}

class Program
{
    static void Main()
    {
        // Creating video instances
        Video video1 = new Video("Intro to C#", "John Doe", 300);
        Video video2 = new Video("Object-Oriented Programming", "Jane Smith", 450);
        Video video3 = new Video("C# Abstraction Explained", "Mike Brown", 600);

        // Adding comments to videos
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "This helped me a lot, thanks!"));
        video1.AddComment(new Comment("Charlie", "Nice video, very clear."));

        video2.AddComment(new Comment("David", "OOP concepts are finally making sense!"));
        video2.AddComment(new Comment("Eve", "This was super helpful, thanks!"));
        video2.AddComment(new Comment("Frank", "Great visuals and examples."));

        video3.AddComment(new Comment("Grace", "Very informative, keep it up!"));
        video3.AddComment(new Comment("Hank", "Best explanation of abstraction I've seen."));
        video3.AddComment(new Comment("Ivy", "Looking forward to more videos!"));

        // Storing videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying video details and comments
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}