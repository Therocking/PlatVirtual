using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatVirtual.Application.Helpers
{
    public class Envs
    {
        public static string? GetEnvString(string envName)
        {
            return Environment.GetEnvironmentVariable(envName);
        }
    }
}
