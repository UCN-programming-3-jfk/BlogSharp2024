using BlogSharp2024.WebSite.ApiClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp2024.WebSite.Controllers
{
    public class BlogPostsController : Controller
    {
        private readonly IRestClient _restClient = new RestClientStub();

        // GET: BlogPostsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlogPostsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogPostsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPostsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogPostsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogPostsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BlogPostsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogPostsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
