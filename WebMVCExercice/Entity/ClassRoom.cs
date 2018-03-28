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
    public partial class ClassRoom
    {
        #region Properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassRoomId { get; set; }
        public int Number { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        #endregion

        #region Associations
        public virtual List<Student> Students { get; set; }
        #endregion
    }
}