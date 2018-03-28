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
	public partial class Attendance
	{
	    #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceId { get; set; }
		public DateTime AttendanceDate { get; set; }
		[Required]
		public bool IsPresent { get; set; }
		//Foreign Keys
		[ForeignKey("Student")]
		public int StudentId { get; set; }
        [ForeignKey("ClassRoom")]
        public int ClassRoomId { get; set; }
	    #endregion
        #region Associations
        public virtual Student Student { get; set; }
		public virtual ClassRoom ClassRoom { get; set; }
        #endregion
    }
}