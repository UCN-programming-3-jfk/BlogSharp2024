using BlogSharp2024.WebSite.ApiClient;
using BlogSharp2024.WebSite.ApiClient.DTO;
using Microsoft.AspNetCore.Mvc;
namespace BlogSharp2024.WebSite.Controllers;
public class AuthorsController : Controller
{

    IRestClient _client;
    public AuthorsController(IRestClient client)
    {
        _client = client;
    }


    // GET: AuthorsController
    public ActionResult Index()
    {
        return View();
    }

    // GET: AuthorsController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: AuthorsController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: AuthorsController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Author author)
    {
        try
        {
            if (!ModelState.IsValid) 
            {
                TempData["Message"] = $"Error creating your account. Try again later...";
                return View();
            }

            _client.AddAuthor(author);
            TempData["Message"] = $"Your account for the blog {author.BlogTitle} was created - welcome!";
            return RedirectToAction(nameof(Index), "Home");
        }
        catch
        {
            TempData["Message"] = $"Error creating your account. Try again later...";
            return View();
        }
    }

    // GET: AuthorsController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: AuthorsController/Edit/5
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

    // GET: AuthorsController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: AuthorsController/Delete/5
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
