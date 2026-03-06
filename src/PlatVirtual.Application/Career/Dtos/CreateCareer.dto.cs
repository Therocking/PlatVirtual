using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.Career.Dtos
{
    public class CreateCareerDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public DateOnly Duration { get; set; }
    }
}
