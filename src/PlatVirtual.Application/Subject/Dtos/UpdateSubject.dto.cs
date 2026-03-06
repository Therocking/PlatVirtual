using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.Subject.Dtos
{
    public class UpdateSubjectDto
    {
        public Guid Id {  get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public Guid CourseId { get; set; }
    }
}
