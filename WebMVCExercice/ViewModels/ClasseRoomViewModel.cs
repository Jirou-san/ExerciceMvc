using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCExercice.ViewModels
{
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class ClasseRoomViewModel
    {
        public int ClassRoomId { get; set; }
        [Required]
        public int Number { get; set; }
        [Required] [DisplayName("Nom de salle")]
        public string Name { get; set; }
    }
}