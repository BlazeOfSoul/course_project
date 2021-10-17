using CourseProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.ViewModels
{
    public class IndexModel
    {

        [BindProperty]
        public string IndexAnswer { get; set; }
        [BindProperty]
        public int PostID { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}
