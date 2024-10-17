using BlogSharp2024.WebSite.ApiClient.DTO;

namespace BlogSharp2024.WebSite.ApiClient

{
    public interface IRestClient
    {
        public IEnumerable<BlogPost> GetTenLatestBlogPosts();

    }
}
