using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLogin
{
    internal class SqlException:Exception
    {
        public SqlException(string message, Exception innerException)
        {
            MessageBox.Show($"Error en la conexion: {innerException}");
        }
    }
}
