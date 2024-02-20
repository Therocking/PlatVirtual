using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Domain.Entities
{
    public class Enrollments
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
        [Required]
        public Guid StudentId { get; set; }
        [Required]
        public Guid CareerId { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }

        [ForeignKey("StudentId")]
        public virtual Users Student { get; set; }
        [ForeignKey("CareerId")]
        public virtual Careers Career { get; set; }
    }
}
