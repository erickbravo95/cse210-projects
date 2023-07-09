public class Video{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _Comments = new List<Comment>();
    public void DisplayInfo(){
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} minutes");
        Console.WriteLine("-Comments-");
    }

    public void CommentCount(){
        foreach (Comment comment in _Comments)
        {
            comment.GetComment();
        }
        Console.WriteLine();
    }
}