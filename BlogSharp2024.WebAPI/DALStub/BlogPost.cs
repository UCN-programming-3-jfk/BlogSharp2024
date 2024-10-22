namespace BlogSharp2024.WebAPI.DALStub
{
    public class BlogPost
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public int AuthorId { get; set; }
    }
}