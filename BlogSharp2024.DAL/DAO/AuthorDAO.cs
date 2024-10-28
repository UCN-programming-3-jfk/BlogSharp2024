using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace BlogSharp2024.DAL.DAO
{
    public class AuthorDAO : BaseDAO, IAuthorDAO
    {
        private const string INSERT_SQL = "INSERT INTO Author (Email, BlogTitle, PasswordHash) OUTPUT INSERTED.Id  VALUES (@Email, @BlogTitle, @PasswordHash);";
        public AuthorDAO(string connectionString) : base(connectionString)
        {
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Author? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Insert(Author author)
        {
            var passwordHash = BCryptTool.HashPassword(author.Password);
            using var connection = CreateConnection();
            return connection.QuerySingle<int>(INSERT_SQL, new { Email = author.Email, BlogTitle = author.BlogTitle, PasswordHash = passwordHash }); //can be simplified
        }

        public int TryLogin(string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool Update(Author account)
        {
            throw new NotImplementedException();
        }
    }
}
