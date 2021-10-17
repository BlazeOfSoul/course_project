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

        

        private DataBaseContext db;
        public HomeController(DataBaseContext context_p)
        {
            db = context_p;
            db.Posts.Load();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(PostModel model)
        {
            if (ModelState.IsValid)
            {
                db.Posts.Add(new Post { UserId = GetUserId, PostName = model.PostName, PostContent = model.PostContent, Answer = model.Answer, Date = System.DateTime.Now });
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> TakeAnswer(IndexModel model, string PostID)
        {
            if (ModelState.IsValid)
            {
                db.Answers.Add(new Answer { UserId = GetUserId, UserAnswer = model.IndexAnswer, PostId = int.Parse(PostID) });
                await db.SaveChangesAsync();
            }
            return View();
        }
        public IActionResult CreationPage()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            var posts = db.Posts.ToList();
            if (posts == null) return View();
            var temp = new IndexModel();
            temp.Posts = posts;
            temp.PostID = 0;
            temp.IndexAnswer = "";
            return View(temp);
        }

        
    }
}
