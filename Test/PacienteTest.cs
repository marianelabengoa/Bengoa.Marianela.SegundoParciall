using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    public class PacienteTest
    {

        [TestMethod]
        public void RealizarAccion_DebeRetornarMensajeCorrecto()
        {
            // Arrange
            Paciente paciente = new Paciente("John", "Doe", 35, 123456789, 101);

            // Act
            string resultado = paciente.RealizarAccion();

            // Assert
            Assert.AreEqual("John esta siendo atendido", resultado);
        }

        [TestMethod]
        public void ToString_DebeRetornarCadenaConDatosCorrectos()
        {
            // Arrange
            Paciente paciente = new Paciente("Jane", "Smith", 40, 987654321, 202, EObraSocial.Galeno, new DateTime(1982, 5, 15));

            // Act
            string resultado = paciente.ToString();

            // Assert
            StringAssert.Contains(resultado, "nombre : Jane");
            StringAssert.Contains(resultado, "apellido: Smith");
            StringAssert.Contains(resultado, "edad: 40");
            StringAssert.Contains(resultado, "dni: 987654321");
            StringAssert.Contains(resultado, "obra social: Galeno");
            StringAssert.Contains(resultado, "numero habitacion: 202");
            StringAssert.Contains(resultado, "fecha nacimiento: 15/05/1982");
        }

        [TestMethod]
        public void Mostrar_DebeRetornarCadenaConDatosDeLaPersona()
        {
            // Arrange
            Paciente paciente = new Paciente("Bob", "Johnson", 45, 555555555, 303);

            // Act
            string resultado = paciente.Mostrar();

            // Assert
            StringAssert.Contains(resultado, "nombre: Bob");
            StringAssert.Contains(resultado, "apellido: Johnson");
            StringAssert.Contains(resultado, "edad: 45");
            StringAssert.Contains(resultado, "DNI 555555555");
        }

        [TestMethod]
        public void Equals_CuandoObjetoEsPaciente_DebeRetornarTrue()
        {
            // Arrange
            Paciente paciente1 = new Paciente("Alice", "Williams", 30, 111111111, 404);
            Paciente paciente2 = new Paciente("Bob", "Johnson", 45, 555555555, 505);

            // Act
            bool resultado = paciente1.Equals(paciente2);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Equals_CuandoObjetoNoEsPaciente_DebeRetornarFalse()
        {
            // Arrange
            Paciente paciente = new Paciente("Charlie", "Brown", 25, 999999999, 606);

            // Act
            bool resultado = paciente.Equals(new Doctor("Charlie", "Brown", 25, 999999999, "Cirugía"));

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Igualdad_CuandoPacientesTienenMismoNombre_DebeRetornarTrue()
        {
            // Arrange
            Paciente paciente1 = new Paciente("John", "Doe", 35, 123456789, 101);
            Paciente paciente2 = new Paciente("John", "Smith", 40, 987654321, 202, EObraSocial.Galeno, new DateTime(1982, 5, 15));

            // Act
            bool resultado = paciente1 == paciente2;

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Igualdad_CuandoPacientesTienenDistintoNombre_DebeRetornarFalse()
        {
            // Arrange
            Paciente paciente1 = new Paciente("Jane", "Smith", 40, 987654321, 202, EObraSocial.Galeno, new DateTime(1982, 5, 15));
            Paciente paciente2 = new Paciente("John", "Doe", 35, 123456789, 101);

            // Act
            bool resultado = paciente1 == paciente2;

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Desigualdad_CuandoPacientesTienenMismoNombre_DebeRetornarFalse()
        {
            // Arrange
            Paciente paciente1 = new Paciente("John", "Doe", 35, 123456789, 101);
            Paciente paciente2 = new Paciente("Jahn", "Smith", 40, 987654321, 202, EObraSocial.Galeno, new DateTime(1982, 5, 15));

            // Act
            bool resultado = paciente1 != paciente2;

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Desigualdad_CuandoPacientesTienenDistintoNombre_DebeRetornarTrue()
        {
            // Arrange
            Paciente paciente1 = new Paciente("Jane", "Smith", 40, 987654321, 202, EObraSocial.Galeno, new DateTime(1982, 5, 15));
            Paciente paciente2 = new Paciente("John", "Doe", 35, 123456789, 101);

            // Act
            bool resultado = paciente1 != paciente2;

            // Assert
            Assert.IsTrue(resultado);
        }
    }
}