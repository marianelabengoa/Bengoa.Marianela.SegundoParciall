using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLogin
{
    internal interface IEvaluacion
    {
        int ObtenerNivelSatisfaccion();
        void MostrarResultado(int nivel);
    }
}
