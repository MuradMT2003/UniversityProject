using UniversityProject.Models;

namespace UniversityProject.ViewModels
{
    public class StudentDetailViewModel
    {
        public Student student { get; set; }
        public List<Group> groups { get; set; }
    }
}
