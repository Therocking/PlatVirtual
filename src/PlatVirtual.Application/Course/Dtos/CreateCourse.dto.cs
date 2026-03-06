using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.Course.Dtos
{
    public class CreateCourseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ProfessorId { get; set; }
    }
}
