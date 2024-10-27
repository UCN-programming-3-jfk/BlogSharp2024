namespace BlogSharp2024.WebAPI.DALStub;
public interface IBlogPostDAO
{
    IEnumerable<BlogPost> GetAll();
    BlogPost Get(int id);
    int Insert(BlogPost blogPost);
    IEnumerable<BlogPost> GetTenLatestBlogPosts();
}