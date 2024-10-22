using BlogSharp2024.WebSite.ApiClient;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace BlogSharp2024.WebSite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //register dependencies
            //so any controller asking for a 
            //IRestClient receives a RestClientStub
            //builder.Services.AddSingleton<IRestClient, RestClientStub>();
            builder.Services.AddSingleton<IRestClient>((_) => new RestApiClient("https://localhost:7243/api/v1"));

            //1) 
            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)

                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme);


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // 2)
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
