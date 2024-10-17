namespace BlogSharp2024.WebSite.ApiClient.DTO;
public class BlogPost
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }
    public DateTime CreationDate { get; set; }

    //TODO: author, email, id?
   
}