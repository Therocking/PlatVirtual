using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.User.Exceptions
{
    public class UserNotFoundException: Exception
    {
        public override string Message { get; }
        public UserNotFoundException()
        {
            Message = "El usuario no fue encontra.";
        }
    }
}
