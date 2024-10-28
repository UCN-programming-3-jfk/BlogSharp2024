
using BlogSharp2024.DAL.DAO;
using BlogSharp2024.WebAPI.DALStub;

namespace BlogSharp2024.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //registrer, at hvis en controller 
            //skal bruge en IBlogPostsDAO
            //så instantiér og giv den en BlogPostsDAOStub
            builder.Services.AddSingleton<IBlogPostDAO, BlogPostDAOStub>();
            builder.Services.AddSingleton<IAuthorDAO, AuthorDAOStub>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            
            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
