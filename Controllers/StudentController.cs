using Microsoft.AspNetCore.Mvc;
using NguyenGiaNguyenBTH.Models;

namespace NguyenGiaNguyenBTH.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            //khoi tao list student
            List<Student> stdList = new List<Student>()
            {
                new Student  {StudentID = 1, StudentName = "Nguyen Van A", Age = 18},
                new Student  {StudentID = 2, StudentName = "Nguyen Van B", Age = 18},
                new Student  {StudentID = 3, StudentName = "Nguyen Van C", Age = 18},
                new Student  {StudentID = 4, StudentName = "Nguyen Van D", Age = 18},
                new Student  {StudentID = 5, StudentName = "Nguyen Van E", Age = 18}
            };
            ViewData["Students"] = stdList;
             return View();
        }
        [HttpPost]
        public IActionResult Creat (Student std)
        {
            //string message = std.StudentID + "-";
            //message += std.StudentName + "-";
            //message += std.Age;
            //ViewBag.TT = message;
            return View ();
        }
    }
}
