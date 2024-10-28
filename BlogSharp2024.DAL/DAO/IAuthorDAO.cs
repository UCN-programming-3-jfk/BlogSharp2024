namespace BlogSharp2024.DAL.DAO;
public interface IAuthorDAO
{
    int Insert(Author account);
    IEnumerable<Author> GetAll();
    Author? Get(int id);
    bool Update(Author account);
    bool Delete(int id);
    int TryLogin(string email, string password);
}