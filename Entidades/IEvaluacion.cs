using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLogin
{
    internal interface IEvaluacion
    {
        void EscribirPromedioEnArchivo(float promedio);
        void MostrarResultado(int nivel);
    }
}
