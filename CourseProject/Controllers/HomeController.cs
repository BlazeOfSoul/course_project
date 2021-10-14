using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CourseProject.ViewModels;
using CourseProject.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CourseProject.Controllers
{
    public class HomeController : BaseController
    {
        private DataBaseContext db_p;
        public HomeController(DataBaseContext context_p)
        {
            db_p = context_p;
            db_p.Posts.Load();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(PostModel model)
        {
            if (ModelState.IsValid)
            {
                db_p.Posts.Add(new Post { UserId = GetUserId, PostName = model.PostName, PostContent = model.PostContent, Answer = model.Answer });
                await db_p.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult TakeAnswer()
        {
            return View();
        }
        public IActionResult CreationPage()
        {
            return View();
        }
        public IActionResult Index()
        {
            var posts = db_p.Posts.ToList();
            if (posts == null) return View();
            return View(posts);
        }

        
    }
}
