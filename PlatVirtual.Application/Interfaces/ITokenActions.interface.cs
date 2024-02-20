using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.Interfaces
{
    public interface ITokenActions
    {
        string GenerateToken(string name);
        string? DecodeToken(string token);
    }
}
