using BlogSharp2024.WebSite.ApiClient.DTO;

namespace BlogSharp2024.WebSite.ApiClient;

public class RestClientStub : IRestClient
{
    static private List<BlogPost> _posts = new List<BlogPost>() {
        new BlogPost(){Id=1, Title = "Jordbærgrød FTW!", Content="Fed artikel med indhold.....", CreationDate = DateTime.Now.AddDays(-5)},
        new BlogPost(){ Title = "Exploring C# 12", Content="An in-depth look at the new features in C# 12.", CreationDate = DateTime.Now.AddDays(-4)},
        new BlogPost(){ Title = "REST APIs: The Basics", Content="Understanding the core concepts of RESTful APIs.", CreationDate = DateTime.Now.AddDays(-10)},
        new BlogPost(){ Title = "Why Unit Testing Matters", Content="A guide to the importance of testing your code.", CreationDate = DateTime.Now.AddDays(-7)},
        new BlogPost(){ Title = "Introduction to Dependency Injection", Content="A beginner's guide to DI in C#.", CreationDate = DateTime.Now.AddDays(-15)},
        new BlogPost(){ Title = "Top 10 VS Code Extensions for C#", Content="Boost your productivity with these extensions.", CreationDate = DateTime.Now.AddDays(-2)},
        new BlogPost(){ Title = "Handling Exceptions Gracefully", Content="Learn how to manage exceptions effectively in C#.", CreationDate = DateTime.Now.AddDays(-9)},
        new BlogPost(){ Title = "LINQ: A Quick Overview", Content="How to use LINQ to make your C# code more concise.", CreationDate = DateTime.Now.AddDays(-20)},
        new BlogPost(){ Title = "Solid Principles Explained", Content="A breakdown of the SOLID principles in software design.", CreationDate = DateTime.Now.AddDays(-8)},
        new BlogPost(){ Title = "Understanding Async/Await", Content="Mastering asynchronous programming in C#.", CreationDate = DateTime.Now.AddDays(-3)},
        new BlogPost(){ Title = "Effective Logging in C#", Content="Learn best practices for logging in your C# applications.", CreationDate = DateTime.Now.AddDays(-14)},
        new BlogPost(){ Title = "Top Resources to Learn C#", Content="A curated list of resources for C# developers.", CreationDate = DateTime.Now.AddDays(-13)},
        new BlogPost(){ Title = "What’s New in .NET 8", Content="A summary of new features in the latest .NET release.", CreationDate = DateTime.Now.AddDays(-6)},
        new BlogPost(){ Title = "C# for Beginners: Getting Started", Content="A complete beginner’s guide to C# programming.", CreationDate = DateTime.Now.AddDays(-18)},
        new BlogPost(){ Title = "Using Entity Framework Core", Content="An introduction to working with EF Core in C#.", CreationDate = DateTime.Now.AddDays(-11)}
    }
    public IEnumerable<BlogPost> GetTenLatestBlogPosts()
    {
        return _posts.Take(10);
    }
}
