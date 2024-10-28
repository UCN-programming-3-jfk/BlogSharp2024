using BlogSharp2024.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSharp2024.DAL.DAO
{
    public class BlogPostDAO : BaseDAO, IBlogPostDAO
    {
            private const string SELECT_TEN_QUERY = "SELECT TOP(10) Id, Title, PostContent as [Content], FK_Author_Id as AuthorId FROM BlogPost ORDER BY CreationDate DESC";
        public BlogPostDAO(string connectionString) : base(connectionString)
        {
        }
        public BlogPost Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetTenLatestBlogPosts()
        {
            using var connection = CreateConnection();
            return connection.Query<BlogPost>(query).ToList();

        }

        public int Insert(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
}
