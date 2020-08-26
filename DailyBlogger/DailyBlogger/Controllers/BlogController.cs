using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using DailyBlogger.Models;


namespace DailyBlogger.Controllers
{
    public class BlogController : Controller
    {
        private BlogContext _Context;
        public BlogController(BlogContext context)
        {
            _Context = context;

        }
        public IActionResult list()
        {
            IEnumerable<BlogPost> posts = _Context.BlogPost.ToList<BlogPost>();
            return View(posts);
        }

        public IActionResult New()
        {
            BlogPost blogPost = new BlogPost();
            return View(blogPost);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("blogTitle,content,blogDate")] BlogPost blog)
        {
            if (ModelState.IsValid)
            {
                _Context.Add(blog);
                _Context.SaveChanges();
                return RedirectToAction(nameof(list));

            }
            return View(blog);
        }
    }
}
