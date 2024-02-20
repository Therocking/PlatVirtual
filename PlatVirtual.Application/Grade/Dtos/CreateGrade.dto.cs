using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.Grade.Dtos
{
    public class CreateGradeDto
    {
        public int Grade {  get; set; }
        public Guid StudentId { get; set; }
        public Guid ProfessorId { get; set; }
        public Guid SubjectId { get; set; }
    }
}
