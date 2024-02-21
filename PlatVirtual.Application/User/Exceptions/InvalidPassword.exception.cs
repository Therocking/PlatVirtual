using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.User.Exceptions
{
    public class InvalidPassword: Exception
    {
        public override string Message { get; }
        public InvalidPassword()
        {
            Message = "La contraseña es incorrecta";
        }
    }
}
