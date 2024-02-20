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
    public class Courses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [DefaultValue(true)]
        public bool IsActive {  get; set; }
        [Required]
        public Guid ProfessorId { get; set; }

        [ForeignKey("ProfessorId")]
        public virtual Users Professor {  get; set; }

        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
