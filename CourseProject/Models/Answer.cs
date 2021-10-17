using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PostId { get; set; }
        virtual public User User { get; set; }
        virtual public Post Post { get; set; }
        public string UserAnswer { get; set; }
    }
}
