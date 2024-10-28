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
            throw new NotImplementedException();
        }

        public int Insert(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
}
