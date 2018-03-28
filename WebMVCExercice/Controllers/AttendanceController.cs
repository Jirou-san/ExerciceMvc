using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCExercice.Entity;
namespace WebMVCExercice.Controllers
{
    using WebMVCExercice.Services;
    using WebMVCExercice.ViewModels;

    public class AttendanceController : Controller
    {
        private readonly StudentAttendanceService _service = new StudentAttendanceService();
        
        public ActionResult Attendances()
        {
            var attendances = _service.GetAllAttendances();
            return View("Attendances",attendances);
        }

        public ActionResult GetAttendance(int idAttendance)
        {
            var studentAttendance = _service.GetAttendanceById(idAttendance);
            return View("StudentAttendanceDetail", studentAttendance);
        }

        [HttpPost]
        public ActionResult AddStudentAttendance(StudentAttendanceViewModel studentAttendanceVm)
        {
            if (ModelState.IsValid)
            {
                _service.AddAttendance(studentAttendanceVm);
                RedirectToAction("Index", "Home");

            }
            //ViewBag
            var studentListItems = _service.GetStudentsItems();
            var classRoomListItems = _service.GetRoomsItems();
            ViewBag.Students = studentListItems;
            ViewBag.Rooms = classRoomListItems;
            return View(studentAttendanceVm);
        }
        [HttpGet]
        public ActionResult AddStudentAttendance()
        {
            var studentListItems = _service.GetStudentsItems();
            var classRoomListItems = _service.GetRoomsItems();
            ViewBag.Students = studentListItems;
            ViewBag.Rooms = classRoomListItems;
            return View(new StudentAttendanceViewModel
                            {
                                DateAttendance = DateTime.Now
                            });
        }
        [HttpGet]
        public ActionResult AddAttendance()
        {

            return View("AttendanceStudentView");
        }
        //Post
        [HttpPost]
        public ActionResult AddAttendance(StudentAttendanceViewModel studentAttendanceVm)
        {
            if (ModelState.IsValid)
            {
                _service.AddAttendance(studentAttendanceVm);
                RedirectToAction("Index", "Home");

            }

            return View("AttendanceStudentView", studentAttendanceVm);
        }
    }
}