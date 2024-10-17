using BlogSharp2024.WebSite.ApiClient;
using BlogSharp2024.WebSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogSharp2024.WebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRestClient _client;
        public HomeController(ILogger<HomeController> logger, IRestClient client)
        {
            _logger = logger;
            _client = client;
        }

        public IActionResult Index()
        {
            return View(_client.GetTenLatestBlogPosts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
