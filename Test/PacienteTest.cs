using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Entidades.Test
{
    [TestClass]
    public class PacienteTests
    {
        [TestMethod]
        public void RealizarAccion_DebeRetornarMensajeCorrecto()
        {
            // Arrange
            Paciente paciente = new Paciente("Juan", "Perez", 30, 123456789, 101);

            // Act
            string resultado = paciente.RealizarAccion();

            // Assert
            Assert.AreEqual("Juan esta siendo atendido", resultado);
        }

        [TestMethod]
        public void ToString_DebeRetornarDatosCorrectos()
        {
            // Arrange
            DateTime fechaNacimiento = new DateTime(1990, 5, 15);
            Paciente paciente = new Paciente("Maria", "Gomez", 25, 987654321, 202, EObraSocial.OSDE, fechaNacimiento);

            // Act
            string resultado = paciente.ToString();

            // Assert
            StringAssert.Contains(resultado, "nombre : Maria");
            StringAssert.Contains(resultado, "apellido: Gomez");
            StringAssert.Contains(resultado, "edad: 25");
            StringAssert.Contains(resultado, "dni: 987654321");
            StringAssert.Contains(resultado, "obra social: OSDE");
            StringAssert.Contains(resultado, "numero habitacion: 202");
            StringAssert.Contains(resultado, "fecha nacimiento: 15/05/1990");
        }

        [TestMethod]
        public void Mostrar_DebeRetornarDatosCorrectos()
        {
            // Arrange
            Paciente paciente = new Paciente("Carlos", "Lopez", 35, 456789123, 303);

            // Act
            string resultado = paciente.Mostrar();

            // Assert
            StringAssert.Contains(resultado, "Nombre: Carlos");
            StringAssert.Contains(resultado, "Apellido: Lopez");
            StringAssert.Contains(resultado, "Edad: 35");
            StringAssert.Contains(resultado, "DNI: 456789123");
        }

        [TestMethod]
        public void Equals_DebeRetornarTrueSiTipoEsPaciente()
        {
            // Arrange
            Paciente paciente = new Paciente("Ana", "Rodriguez", 28, 111222333, 404);

            // Act
            bool resultado = paciente.Equals(new Paciente());

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void OperadorIgual_DebeRetornarTrueSiNombresYApellidosSonIguales()
        {
            // Arrange
            Paciente paciente1 = new Paciente("Ana", "Rodriguez", 28, 111222333, 505);
            Paciente paciente2 = new Paciente("Ana", "Rodriguez", 28, 111222333, 606);

            // Act
            bool resultado = paciente1 == paciente2;

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void OperadorDiferente_DebeRetornarTrueSiNombresYApellidosNoSonIguales()
        {
            // Arrange
            Paciente paciente1 = new Paciente("Eduardo", "Lopez", 40, 555666777, 707);
            Paciente paciente2 = new Paciente("Maria", "Gomez", 25, 987654321, 808);

            // Act
            bool resultado = paciente1 != paciente2;

            // Assert
            Assert.IsTrue(resultado);
        }
    }
}