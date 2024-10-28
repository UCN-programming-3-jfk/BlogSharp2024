
using BlogSharp2024.DAL.DAO;

namespace BlogSharp2024.WebAPI.DALStub;
public class AuthorDAOStub : IAuthorDAO
{
    private static List<Author> _authors = new List<Author>() {
        new Author(){Id=1, BlogTitle="Blogging about vegetables", Email="veggiehead@gmail.com", Password="1234" },
        new Author(){Id=2, BlogTitle="Best Python Coding Blog", Email="pycoder@gmail.com" },
        new Author(){Id=3, BlogTitle="The Dessert Blog", Email="Desserts@gmail.com" },
    };

    public bool Delete(int id)
    {
        var author = _authors.FirstOrDefault(a => a.Id == id);
        if (author != null)
        {
            _authors.Remove(author);
            return true;
        }
        return false;
    }

    public Author? Get(int id)
    {
        return _authors.FirstOrDefault(a => a.Id == id);
    }

    public IEnumerable<Author> GetAll()
    {
        return _authors;
    }

    public int Insert(Author author)
    {
        var newId = _authors.Max(a => a.Id) + 1;
        author.Id = newId;
        _authors.Add(author);
        return newId;
    }

    public int TryLogin(string email, string password)
    {
        var author = _authors.FirstOrDefault(a => a.Email == email && a.Password == password);
        return author?.Id ?? -1;
    }

    public bool Update(Author author)
    {
        var existingAuthor = _authors.FirstOrDefault(a => a.Id == author.Id);
        if (existingAuthor != null)
        {
            existingAuthor.BlogTitle = author.BlogTitle;
            existingAuthor.Email = author.Email;
            existingAuthor.Password = author.Password;
            return true;
        }
        return false;
    }
}