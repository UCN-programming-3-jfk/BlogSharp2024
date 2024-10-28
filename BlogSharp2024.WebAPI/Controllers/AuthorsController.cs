using BlogSharp2024.DAL.DAO;
using BlogSharp2024.WebAPI.DALStub;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp2024.WebAPI.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class AuthorsController : ControllerBase
{
    private readonly IAuthorDAO _authorDAO;

    public AuthorsController(IAuthorDAO authorsDAO)
    {
        _authorDAO = authorsDAO;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Author>> Get()
    {
        return Ok(_authorDAO.GetAll());
    }

    
    [HttpGet("{id}")]
    public ActionResult<Author> Get([FromRoute]int id)
    {
        var author = _authorDAO.Get(id);
        if (author == null)
        {
            return NotFound();
        }
        return Ok(author);
    }

    [HttpPost]
    public ActionResult<int> Post([FromBody] Author author)
    {
        var authorId = _authorDAO.Insert(author);
        return CreatedAtAction(nameof(Get), new { id = authorId }, authorId);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Author author)
    {
        if (id != author.Id)
        {
            return BadRequest();
        }

        _authorDAO.Update(author);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _authorDAO.Delete(id);
        return NoContent();
    }

    [HttpPost("login")]
    public ActionResult<int> Post([FromBody] Credentials credentials)
    {
        var authorId =_authorDAO.TryLogin(credentials.Email, credentials.Password);
        if (authorId < 1){return NotFound(-1);}
        return Ok(authorId);
    }
}
