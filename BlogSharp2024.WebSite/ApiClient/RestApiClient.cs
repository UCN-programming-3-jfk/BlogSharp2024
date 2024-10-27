using BlogSharp2024.WebSite.ApiClient.DTO;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace BlogSharp2024.WebSite.ApiClient;

public class RestApiClient : IRestClient
{
    //restsharp klienten
    RestClient _client;

    //constructor der modtager basis URL'en til APi'et
    //https://localhost:7243/api/v1/
    public RestApiClient(string baseApiUrl) => _client = new RestClient(baseApiUrl);

    public int AddAuthor(Author author)
    {
        var request = new RestRequest("authors", Method.Post);
        request.AddJsonBody(author);
        var response = _client.Execute<int>(request);
        return response.Data;
    }

    public int AddBlogPost(BlogPost blogPost)
    {
        var request = new RestRequest("blogposts", Method.Post);
        request.AddJsonBody(blogPost);
        var response = _client.Execute<int>(request);
        return response.Data;
    }

    public BlogPost GetBlogPostFromId(int id)
    {
        var request = new RestRequest($"blogposts/{id}", Method.Get);
        var response = _client.Execute<BlogPost>(request);
        return response.Data;
    }

    public IEnumerable<BlogPost> GetTenLatestBlogPosts()
    {
        //HACK: FUGLY CODE!! - get ONLY 10
        //return _client.Get<IEnumerable<BlogPost>>(new RestRequest("blogposts")).Take(10);

        //HACK: FUGLY CODE!! - get ONLY 10
        return _client.Get<IEnumerable<BlogPost>>(new RestRequest("blogposts/latest10"));
    }

    public int TryLogin(string email, string password)
    {
        var request = new RestRequest("authors/login", Method.Post);
        request.AddJsonBody(new Credentials{ Email = email, Password = password });
        var response = _client.Execute<int>(request);
        return response.Data;
    }
}
