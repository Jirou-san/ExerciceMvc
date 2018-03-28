using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using WebMVCExercice.Entity;

namespace WebMVCExercice.ViewModels
{
    public static class Map
    {
        #region Students
        public static StudentViewModel MapToStudentViewModel(this Student student)
        {
            var studentViewModel = new StudentViewModel();
            if (student == null)
            {
                return studentViewModel;
            }

            studentViewModel = new StudentViewModel
            {
                Id = student.StudentId,
                Name = student.StudentName
            };
            return studentViewModel;
        }
        public static Student MapToStudent(this StudentViewModel studentViewModel)
        {
            var student = new Student();
            if (studentViewModel == null)
            {
                return student;
            }

            student = new Student
            {
                StudentId = studentViewModel.Id,
                StudentName = studentViewModel.Name
            };
            return student;
        }
        #endregion
        public static StudentAttendanceViewModel MapToStudentAttendanceViewModel(this Attendance attendance)
        {
            var studentAttendanceViewModel = new StudentAttendanceViewModel();
            if (studentAttendanceViewModel == null)
            {
                return studentAttendanceViewModel;
            }

            studentAttendanceViewModel = new StudentAttendanceViewModel
            {
                AttendanceId = attendance.AttendanceId,
                DateAttendance = attendance.AttendanceDate,
                ClassRoomFullName = $"{attendance.ClassRoom.Name} {attendance.ClassRoom.Number}",
                IdStudent = attendance.StudentId,
                IsPresentAttendance = attendance.IsPresent,
                StudentName = attendance.Student.StudentName
            };
            return studentAttendanceViewModel;
        }
        public static Attendance MapToStudentAttendance(this StudentAttendanceViewModel
            attendanceVM)
        {
            var studentAttendance = new Attendance();
            if (studentAttendance == null)
            {
                return studentAttendance;
            }

            studentAttendance = new Attendance
            {
                AttendanceId = attendanceVM.AttendanceId,
                AttendanceDate = attendanceVM.DateAttendance,
                StudentId = attendanceVM.IdStudent,
                IsPresent = attendanceVM.IsPresentAttendance,
                ClassRoomId = attendanceVM.ClassRoomId
            };
            return studentAttendance;
        }
        public static ClassRoom MapToClassRoomViewModel(this ClasseRoomViewModel
                                                            classroomVM)
        {
            var classroom = new ClassRoom();
            if (classroom == null)
            {
                return classroom;
            }

            classroom = new ClassRoom
            {
                                        ClassRoomId = classroomVM.ClassRoomId,
                                        Number = classroomVM.Number,
                                        Name = classroomVM.Name


                                    };
            return classroom;
        }
        public static ClasseRoomViewModel MapToClassRoom(this ClassRoom
                                                            classroom)
        {
            var classroomVM = new ClasseRoomViewModel();
            if (classroom == null)
            {
                return classroomVM;
            }

            classroomVM = new ClasseRoomViewModel
            {
                                ClassRoomId = classroom.ClassRoomId,
                                Number = classroom.Number,
                                Name = classroom.Name


                            };
            return classroomVM;
        }
    }
}