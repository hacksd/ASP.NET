using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Blogapp.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blogapp.Controllers
{

    public class BlogappController : Controller
    {
        private BlogContext _context;
        public BlogappController(BlogContext context)
        {
            _context = context;

        }
        public IActionResult List()
        {
            IEnumerable<BlogPost> posts = _context.BlogPost.ToList<BlogPost>();
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
                _context.Add(blog);
                _context.SaveChanges();
                return RedirectToAction(nameof(List));

            }
            return View(blog);
        }
    }
}
