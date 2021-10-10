using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        virtual public User User { get; set; }
        public string PostName { get; set; }
        public string PostContent { get; set; }
        public string Answer { get; set; }
    }
}
