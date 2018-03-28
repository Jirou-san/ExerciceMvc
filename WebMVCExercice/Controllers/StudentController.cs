using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCExercice.Services;
namespace WebMVCExercice.Controllers
{
    using WebMVCExercice.ViewModels;

    public class StudentController : Controller
    {
        private StudentAttendanceService _service = new StudentAttendanceService();
        // GET: Student
        [HttpGet]
        public ActionResult AddStudent()
        {

            return View();
        }
        //Post
        [HttpPost]
        public ActionResult AddStudent(StudentViewModel studentVM)
        {
            if (ModelState.IsValid)
            {
                _service.AddStudent(studentVM);
                RedirectToAction("Index", "Home");

            }

            return View(studentVM);
        }
    }
}