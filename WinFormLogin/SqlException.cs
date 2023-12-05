using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLogin
{
    internal class MySqlException:Exception
    {
        public MySqlException(string message, Exception innerException)
        {
            MessageBox.Show($"Error en la conexion: {innerException}");
        }
    }
}
