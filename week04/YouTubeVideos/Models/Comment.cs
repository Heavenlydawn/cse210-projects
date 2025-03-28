namespace YouTubeVideoProgram.Models
{
    public class Comment
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
            Console.WriteLine($"   - {Author}: {Text}");
        }
    }
}
