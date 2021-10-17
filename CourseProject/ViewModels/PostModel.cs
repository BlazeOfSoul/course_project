using System.ComponentModel.DataAnnotations;

namespace CourseProject.ViewModels
{
    public class PostModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PostName { get; set; }
        public string PostContent { get; set; }
        public string Answer { get; set; }

        
    }
}
