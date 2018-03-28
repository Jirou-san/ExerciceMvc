using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVCExercice.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Nom:")] [Required]        
        public string Name { get; set; }


    }
}