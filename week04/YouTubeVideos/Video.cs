public class Video
{
  private string _title;
  private string _author;
  private int _length;
  private List<Comment> _comments = new List<Comment>();
  public Video(string title, string author, int length)
  {
    _title = title;
    _author = author;
    _length = length;
  }

  public void GetComment(string commenterName, string commentText)
  {
    Comment comment = new Comment(commenterName, commentText);
    _comments.Add(comment);
  }
  public int GetCommentCount()
  {
    return _comments.Count;
  }
  public void DisplayVideoInfo()
  {
    Console.WriteLine($"{_title}, {_author}, {_length} seconds");
    Console.WriteLine($"Number of comments: {GetCommentCount()}");
    Console.WriteLine("Comments:");
    foreach (Comment comment in _comments)
    {
      comment.DisplayCommentInfo();
    }
  }
}