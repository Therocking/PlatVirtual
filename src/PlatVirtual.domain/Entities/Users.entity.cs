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
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(255)]
        public string Password { get; set; }
        [StringLength(20)]
        public string? PhoneNumber { get; set; }
        [Required]
        public DateOnly? BirthDay { get; set; }
        [Required]
        public Guid RoleId { get; set; }
        [StringLength(255)]
        public string? Address { get; set; }
        public string? Img { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("RoleId")]
        public virtual Roles Role { get; set; }

        public virtual ICollection<Courses> Courses { get; set; }
        public virtual ICollection<Enrollments> Enrollments { get; set; }
        public virtual ICollection<Grades> Grades { get; set; }
        public virtual ICollection<Subjects> Subjects { get; set; }
    }
}
