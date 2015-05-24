using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JustBlog.Core;
using JustBlog.Models;

namespace JustBlog.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/
        private IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
                
        }

        public ViewResult Posts(int p = 1)
        {
            // TODO: read and return posts from repository
            var posts = _blogRepository.Posts(p - 1, 10);
            var totalPosts = _blogRepository.TotalPosts();

            var ListViewModel = new ListViewModel 
            {
                Posts = posts,
                TotalPosts = totalPosts
                        
            };
            ViewBag.Title = "Latest Posts";

            return View("List", ListViewModel);

            //return View("List", ListViewModel.Posts);
        }

    }
}
