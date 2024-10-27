using BlogSharp2024.WebAPI.DALStub;
using Microsoft.AspNetCore.Mvc;
namespace BlogSharp2024.WebAPI.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class BlogPostsController : ControllerBase
{
    IBlogPostDAO _blogPostsDAO;

    public BlogPostsController(IBlogPostDAO blogPostsDAO) => _blogPostsDAO = blogPostsDAO;

    // GET: api/<BlogPostsController>
    [HttpGet]
    public ActionResult<IEnumerable<BlogPost>> Get() => Ok(_blogPostsDAO.GetAll());

    // GET: api/<BlogPostsController>
    [HttpGet("latest10")]
    public ActionResult<IEnumerable<BlogPost>> GetLatestTen() => Ok(_blogPostsDAO.GetTenLatestBlogPosts());

    // GET api/<BlogPostsController>/5
    [HttpGet("{id}")]
    public ActionResult<BlogPost> Get(int id) => _blogPostsDAO.Get(id);

    // POST api/<BlogPostsController>
    [HttpPost]
    public int Post([FromBody] BlogPost blogPost) => _blogPostsDAO.Insert(blogPost);
}
