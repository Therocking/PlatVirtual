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
    public class Grades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [Range(0,10)]
        public int Grade { get; set; }
        public DateTime CreatedAt { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        [Required]
        public Guid StudentId { get; set; }
        [Required]
        public Guid SubjectId { get; set; }
        [Required]
        public Guid ProfessorId { get; set; }
         
        [ForeignKey("StudentId")]
        public virtual Users Student { get; set; }

        [ForeignKey("ProfessorId")]
        public virtual Users Professor { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subjects Subject { get; set; }
    }
}
