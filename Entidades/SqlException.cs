using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class MySqlException:Exception
    {
        public MySqlException(string message, Exception innerException)
        {
        }
    }
}
