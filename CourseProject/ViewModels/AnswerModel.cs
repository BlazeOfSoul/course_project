using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class AnswerModel
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string UserAnswer { get; set; }
    }
}
