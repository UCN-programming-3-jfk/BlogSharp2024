using BlogSharp2024.WebAPI.DALStub;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogSharp2024.WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {
        IBlogPostsDAO _blogPostsDAO;

        public BlogPostsController(IBlogPostsDAO blogPostsDAO) => _blogPostsDAO = blogPostsDAO;

        // GET: api/<BlogPostsController>
        [HttpGet]
        public ActionResult<IEnumerable<BlogPost>> Get()
        {
            return Ok(_blogPostsDAO.GetAll());
        }



        // GET api/<BlogPostsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BlogPostsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BlogPostsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BlogPostsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
