using BlogSharp2024.WebSite.ApiClient.DTO;

namespace BlogSharp2024.WebSite.ApiClient

{
    public interface IRestClient
    {
        IEnumerable<BlogPost> GetTenLatestBlogPosts();
        BlogPost GetBlogPostFromId(int id);
        int AddBlogPost(BlogPost blogPost);

    }
}
