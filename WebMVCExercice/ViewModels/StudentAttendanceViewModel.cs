using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebMVCExercice.ViewModels
{
    public class StudentAttendanceViewModel
    {
        //public static int ClassRoomNumero { get; set; }
        //public static string ClassRoomName { get; set; }
        [DisplayName("Nom de la classe:")]
        public string ClassRoomFullName { get; set; }

        [Required]
        public int ClassRoomId { get; set; }
        public int AttendanceId { get; set; }

        [Required]
        public int IdStudent { get; set; }

        [DisplayName("Nom de l'étudiant:")]
        public string StudentName { get; set; }

        [DisplayName("Date:")]
        [Required]
        public DateTime DateAttendance { get; set; }

        [DisplayName("Est présent:")]
        public bool IsPresentAttendance { get; set; }          
    }
}