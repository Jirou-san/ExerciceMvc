using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebMVCExercice.Entity
{
    public partial class Student
    {
        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [StringLength(15)]
        public string StudentName { get; set; }
        #endregion

        #region Associations  
        public virtual List<ClassRoom> ClassRooms { get; set; }
        #endregion  
    }
}