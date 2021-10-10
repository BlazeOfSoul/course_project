using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseProject.ViewModels;
using CourseProject.Models;

namespace CourseProject.Controllers
{
    public class HomeController : Controller
    {
        private PostContext db_p;
        public HomeController(PostContext context_p)
        {
            db_p = context_p;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(PostModel model, LoginModel model_u)
        {
            if (ModelState.IsValid)
            {
                Post post = await db_p.Posts.FirstOrDefaultAsync(p => p.PostName == model.PostName);
                if (post == null)
                {
                    db_p.Posts.Add(new Post { UserName = model_u.Email , PostName = model.PostName, PostContent = model.PostContent });
                    await db_p.SaveChangesAsync();
                }
                return RedirectToAction("Index", "Home");
            }
            return View(model);
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
