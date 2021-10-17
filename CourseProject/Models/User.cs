using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseProject.Models
{
    public class User
    {
        public User()
        {
            Posts = new List<Post>();
            Answers = new List<Answer>();
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        virtual public IEnumerable<Post> Posts { get; set; }
        virtual public IEnumerable<Answer> Answers { get; set; }
    }
}
