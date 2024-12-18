﻿using BlogSharp2024.WebSite.ApiClient.DTO;

namespace BlogSharp2024.WebSite.ApiClient;

public class RestClientStub : IRestClient
{
    private static List<BlogPost> _posts = new List<BlogPost>() {
        new BlogPost(){ Id = 1, Title = "Jordbærgrød FTW!", Content="Fed artikel med indhold.....", CreationDate = DateTime.Now.AddDays(-5)},
        new BlogPost(){ Id = 2, Title = "Exploring C# 12", Content="An in-depth look at the new features in C# 12.", CreationDate = DateTime.Now.AddDays(-4)},
        new BlogPost(){ Id = 3, Title = "REST APIs: The Basics", Content="Understanding the core concepts of RESTful APIs.", CreationDate = DateTime.Now.AddDays(-10)},
        new BlogPost(){ Id = 4, Title = "Why Unit Testing Matters", Content="A guide to the importance of testing your code.", CreationDate = DateTime.Now.AddDays(-7)},
        new BlogPost(){ Id = 5, Title = "Introduction to Dependency Injection", Content="A beginner's guide to DI in C#.", CreationDate = DateTime.Now.AddDays(-15)},
        new BlogPost(){ Id = 6, Title = "Top 10 VS Code Extensions for C#", Content="Boost your productivity with these extensions.", CreationDate = DateTime.Now.AddDays(-2)},
        new BlogPost(){ Id = 7, Title = "Handling Exceptions Gracefully", Content="Learn how to manage exceptions effectively in C#.", CreationDate = DateTime.Now.AddDays(-9)},
        new BlogPost(){ Id = 8, Title = "LINQ: A Quick Overview", Content="How to use LINQ to make your C# code more concise.", CreationDate = DateTime.Now.AddDays(-20)},
        new BlogPost(){ Id = 9, Title = "Solid Principles Explained", Content="A breakdown of the SOLID principles in software design.", CreationDate = DateTime.Now.AddDays(-8)},
        new BlogPost(){ Id = 10, Title = "Understanding Async/Await", Content="Mastering asynchronous programming in C#.", CreationDate = DateTime.Now.AddDays(-3)},
        new BlogPost(){ Id = 11, Title = "Effective Logging in C#", Content="Learn best practices for logging in your C# applications.", CreationDate = DateTime.Now.AddDays(-14)},
        new BlogPost(){ Id = 12, Title = "Top Resources to Learn C#", Content="A curated list of resources for C# developers.", CreationDate = DateTime.Now.AddDays(-13)},
        new BlogPost(){ Id = 13, Title = "What’s New in .NET 8", Content="A summary of new features in the latest .NET release.", CreationDate = DateTime.Now.AddDays(-6)},
        new BlogPost(){ Id = 14, Title = "C# for Beginners: Getting Started", Content="A complete beginner’s guide to C# programming.", CreationDate = DateTime.Now.AddDays(-18)},
        new BlogPost(){ Id = 15, Title = "Using Entity Framework Core", Content="An introduction to working with EF Core in C#.", CreationDate = DateTime.Now.AddDays(-11)}
    };

    private static List<Author> _authors = new List<Author>() {
       new Author(){Id=1, BlogTitle="Blogging about vegetables", Email="veggiehead@gmail.com", Password="1234" },
       new Author(){Id=2, BlogTitle="Best Python Coding Blog", Email="pycoder@gmail.com" },
       new Author(){Id=3, BlogTitle="The Dessert Blog", Email="Desserts@gmail.com" },
    };

    public int AddAuthor(Author author)
    {
        var nextAvailableId = _authors.Max(post => post.Id) + 1;
        author.Id = nextAvailableId;
        _authors.Add(author);
        return author.Id;
    }

    public int AddBlogPost(BlogPost blogPost)
    {
        var nextAvailableId = _posts.Max(post => post.Id) + 1;
        blogPost.Id = nextAvailableId;
        blogPost.CreationDate = DateTime.Now;
        _posts.Add(blogPost);
        return blogPost.Id;
    }

    public BlogPost GetBlogPostFromId(int id)
    {
        return _posts.First(post => post.Id == id);
        //TODO: change return type to BlogPost?
        //return _posts.FirstOrDefault(post => post.Id == id);
    }

    public IEnumerable<BlogPost> GetTenLatestBlogPosts()
    {
        return _posts.Take(10);
    }

    public int TryLogin(string email, string password)
    {
        var author = _authors.SingleOrDefault(author => author.Email == email && author.Password == password);

        if(author == null) { return -1; }
        return author.Id;

    }
}














