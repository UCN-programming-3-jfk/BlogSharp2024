using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSharp2024.DAL.DAO
{
    public class AuthorDAO : BaseDAO, IAuthorDAO
    {
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

        public int Insert(Author account)
        {
            throw new NotImplementedException();
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
