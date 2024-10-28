using BlogSharp2024.DAL.Model;

namespace BlogSharp2024.DAL.DAO;
public interface IBlogPostDAO
{
    IEnumerable<BlogPost> GetAll();
    BlogPost Get(int id);
    int Insert(BlogPost blogPost);
    IEnumerable<BlogPost> GetTenLatestBlogPosts();
}