using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Entidades.Test
{
    [TestClass]
    public class VisitaTests
    {
        [TestMethod]
        public void RealizarAccion_DebeRetornarMensajeCorrecto()
        {
            // Arrange
            Visita visita = new Visita("Juan", "Perez", 30, 123456789, "Paciente1");

            // Act
            string resultado = visita.RealizarAccion();

            // Assert
            Assert.AreEqual("Juan esta visitando a Paciente1", resultado);
        }

        [TestMethod]
        public void ToString_DebeRetornarDatosCorrectos()
        {
            // Arrange
            Visita visita = new Visita("Maria", "Gomez", 25, 987654321, "Paciente2", 101, "Familiar");

            // Act
            string resultado = visita.ToString();

            // Assert
            StringAssert.Contains(resultado, "paciente: Paciente2");
            StringAssert.Contains(resultado, "numero habitacion: 101");
            StringAssert.Contains(resultado, "parentesco: Familiar");
        }

        [TestMethod]
        public void Mostrar_DebeRetornarDatosCorrectos()
        {
            // Arrange
            Visita visita = new Visita("Carlos", "Lopez", 35, 456789123, "Paciente3", 202, "Amigo");

            // Act
            string resultado = visita.Mostrar();

            // Assert
            StringAssert.Contains(resultado, "paciente: Paciente3");
            StringAssert.Contains(resultado, "numero habitacion: 202");
            StringAssert.Contains(resultado, "parentesco: Amigo");
            StringAssert.Contains(resultado, "Nombre: Carlos");
            StringAssert.Contains(resultado, "Apellido: Lopez");
            StringAssert.Contains(resultado, "Edad: 35");
            StringAssert.Contains(resultado, "DNI: 456789123");
        }

        [TestMethod]
        public void Equals_DebeRetornarTrueSiNombresYApellidosSonIguales()
        {
            // Arrange
            Visita visita1 = new Visita("Ana", "Rodriguez", 28, 111222333, "Paciente4");
            Visita visita2 = new Visita("Ana", "Rodriguez", 28, 111222333, "Paciente5");

            // Act
            bool resultado = visita1.Equals(visita2);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Equals_DebeRetornarFalseSiNombresYApellidosNoSonIguales()
        {
            // Arrange
            Visita visita1 = new Visita("Eduardo", "Lopez", 40, 555666777, "Paciente6");
            Visita visita2 = new Visita("Maria", "Gomez", 25, 987654321, "Paciente7");

            // Act
            bool resultado = visita1.Equals(visita2);

            // Assert
            Assert.IsFalse(resultado);
        }
    }
}
