using BlogSharp2024.WebSite.ApiClient.DTO;
using RestSharp;

namespace BlogSharp2024.WebSite.ApiClient
{
    public class RestApiClient : IRestClient
    {
        //restsharp klienten
        RestClient _client;

        //constructor der modtager basis URL'en til APi'et
        //https://localhost:7243/api/v1/
        public RestApiClient(string baseApiUrl) => _client = new RestClient(baseApiUrl);

        public int AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public int AddBlogPost(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public BlogPost GetBlogPostFromId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetTenLatestBlogPosts()
        {
            //HACK: FUGLY CODE!! - get ONLY 10
            return _client.Get<IEnumerable<BlogPost>>(new RestRequest("blogposts")).Take(10);
        }

        public int TryLogin(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
