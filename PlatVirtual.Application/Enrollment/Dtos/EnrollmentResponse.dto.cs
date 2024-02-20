using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.Enrollment.Dtos
{
    public class EnrollmentResponseDto
    {
        public Guid Id { get; set; }
        public Guid Student {  get; set; }
        public Guid Career { get; set; }
    }
}
