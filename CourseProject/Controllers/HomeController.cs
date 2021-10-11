using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseProject.ViewModels;
using CourseProject.Models;

namespace CourseProject.Controllers
{
    public class HomeController : BaseController
    {
        private DataBaseContext db_p;
        public HomeController(DataBaseContext context_p)
        {
            db_p = context_p;
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

        public IActionResult CreationPage()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
