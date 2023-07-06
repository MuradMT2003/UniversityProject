using Microsoft.AspNetCore.Mvc;
using UniversityProject.Models;
using UniversityProject.ViewModels;

namespace UniversityProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = Data.sls;
            var groups = Data.gpls;
            if (students == null || groups == null)
            {
                return View("Error");
            }
            StudentIndexViewModel studentIndexViewModel = new StudentIndexViewModel()
            {
                students = students,
                groups = groups
            };
            return View(studentIndexViewModel);
        }
        public IActionResult Detail(int id)
        {
            if (id == null)
            {
                return View("Error");
            }
            var student = Data.sls.Find(x => x.Id == id);
            var groups = Data.gpls;
            if (student == null||groups==null)
            {
                return View("Error");
            }
            StudentDetailViewModel studentDetailViewModel = new StudentDetailViewModel()
            {
                student = student,
                groups = groups
            };

            return View(studentDetailViewModel);
        }
    }
}
