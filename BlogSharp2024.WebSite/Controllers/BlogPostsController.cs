﻿using BlogSharp2024.WebSite.ApiClient;
using BlogSharp2024.WebSite.ApiClient.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSharp2024.WebSite.Controllers
{
    
    public class BlogPostsController : Controller
    {
        //REady for Dependency Injection
        private readonly IRestClient _restClient;

        public BlogPostsController(IRestClient restClient)
        {
            _restClient = restClient;
        }



        // GET: BlogPostsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BlogPostsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_restClient.GetBlogPostFromId(id));
        }

        // GET: BlogPostsController/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPostsController/Create
        [Authorize,HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create(BlogPost blogPost)
        {
            try
            {
                //save to DAL
                _restClient.AddBlogPost(blogPost);                return Redirect("/home/index");
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
