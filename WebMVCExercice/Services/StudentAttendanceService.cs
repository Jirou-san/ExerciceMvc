// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StudentAttendanceService.cs" company="M2I">
//   M2I
// </copyright>
// <summary>
//   The student attendance service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace WebMVCExercice.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using WebMVCExercice.Entity;
    using WebMVCExercice.ViewModels;

    /// <summary>
    /// The student attendance service.
    /// </summary>
    public class StudentAttendanceService
    {
        /// <summary>
        /// The get all attendances.
        /// </summary>
        /// <returns>
        /// The <see cref="List"/>.
        /// </returns>
        public List<StudentAttendanceViewModel> GetAllAttendances()
        {
            var studentAttendanceVm = new List<StudentAttendanceViewModel>();
            using (var db = new ContextAppli())
            {
                var studentAttendanceEntities = db.Attendances.Select(e => e).ToList();
                studentAttendanceVm.AddRange(studentAttendanceEntities.Select(attendance => attendance.MapToStudentAttendanceViewModel()));

                /*foreach (var entity in studentAttendanceEntities)
                {
                    studentAttendanceVm.Add(entity.MapToStudentAttendanceViewModel());
                }*/
            }

            return studentAttendanceVm;
        }

        public int AddStudent(StudentViewModel studentVM)
        {
            var id = 0;
            using (var db = new ContextAppli())
            {
               var student = db.Students.Add(studentVM.MapToStudent());
                id = student.StudentId;
                db.SaveChanges();
            }

            return id;
        }

        public int AddAttendance(StudentAttendanceViewModel attendanceStudentVM)
        {
            var id = 0;
            using (var db = new ContextAppli())
            {
                var attendance = db.Attendances.Add(attendanceStudentVM.MapToStudentAttendance());
                id = attendance.AttendanceId;
                db.SaveChanges();
            }

                return id;
        }

        public StudentAttendanceViewModel GetAttendanceById(int id)
        {
            var studentAttendanceViewModel = new StudentAttendanceViewModel();
            using (var db = new ContextAppli())
            {
                var attendance = db.Attendances.Find(id);
                studentAttendanceViewModel = attendance.MapToStudentAttendanceViewModel();
            }
            return studentAttendanceViewModel;
        }

        public List<SelectListItem> GetStudentsItems()
        {
            var classRoomSelectList = new List<SelectListItem>();
            using (var db = new ContextAppli())
            {
                var students = db.Students.Select(e => e).ToList();
                foreach (var student in students)
                {
                    classRoomSelectList.Add(new SelectListItem
                                                {
                                                    Text = student.StudentName,
                                                    Value = student.StudentId.ToString()
                                                });
                }
            }
            return classRoomSelectList;
        }
        public List<SelectListItem> GetRoomsItems()
        {
            var classRoomSelectList = new List<SelectListItem>();
            using (var db = new ContextAppli())
            {
                var rooms = db.ClassRooms.Select(e => e).ToList();
                foreach (var room in rooms)
                {
                    classRoomSelectList.Add(new SelectListItem
                        {
                        Text = room.Name,
                        Value = room.ClassRoomId.ToString()
                        });
                }
            }
            return classRoomSelectList;
        }
    }
}