using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskLesson.DATA;
using TaskLesson.Models;

namespace TaskLesson.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> model = _context.Blogs.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            List<Blog> model = _context.Blogs.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Blog model)
        {
            List<Blog> blogs = _context.Blogs.ToList();
            return View(model);
        }
    }
}
