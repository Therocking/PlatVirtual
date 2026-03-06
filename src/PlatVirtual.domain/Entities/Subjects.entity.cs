using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Domain.Entities
{
    public class Subjects
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int Credits { get; set; }
        [Required]
        public Guid CourseId { get; set; }
        [Required]
        public Guid CareerId { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        [ForeignKey("CourseId")]
        public virtual Courses Course { get; set; }

        [ForeignKey("CareerId")]
        public virtual Careers Career { get; set; }
    }
}
