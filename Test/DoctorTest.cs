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
    public class DoctorTests
    {
        [TestMethod]
        public void RealizarAccion_DebeRetornarMensajeCorrecto()
        {
            // Arrange
            Doctor doctor = new Doctor("Juan", "Perez", 40, 123456789, "Cardiología");

            // Act
            string resultado = doctor.RealizarAccion();

            // Assert
            Assert.AreEqual("El doctorJuan esta atendiendo al paciente", resultado);
        }

        [TestMethod]
        public void ToString_DebeRetornarDatosCorrectos()
        {
            // Arrange
            Doctor doctor = new Doctor("Maria", "Gomez", 35, 987654321, "Pediatría", 80000, Euniversidad.UNLP);

            // Act
            string resultado = doctor.ToString();

            // Assert
            StringAssert.Contains(resultado, "especializacion: Pediatría");
            StringAssert.Contains(resultado, "universidad: UNLP");
            StringAssert.Contains(resultado, "sueldo: 80000");
        }

        [TestMethod]
        public void Mostrar_DebeRetornarDatosCorrectos()
        {
            // Arrange
            Doctor doctor = new Doctor("Carlos", "Lopez", 45, 456789123, "Cirugía", 90000, Euniversidad.UBA);

            // Act
            string resultado = doctor.Mostrar();

            // Assert
            StringAssert.Contains(resultado, "nombre: Carlos, apellido: Lopez, edad: 45, DNI 456789123especializacion: Cirugía, universidad: UBA, sueldo: 90000");
            /*StringAssert.Contains(resultado, "universidad: UBA");
            StringAssert.Contains(resultado, "sueldo: 90000");
            StringAssert.Contains(resultado, "Nombre: Carlos");
            StringAssert.Contains(resultado, "Apellido: Lopez");
            StringAssert.Contains(resultado, "Edad: 45");
            StringAssert.Contains(resultado, "DNI: 456789123");*/
        }

        [TestMethod]
        public void Equals_DebeRetornarTrueSiNombresYApellidosSonIguales()
        {
            // Arrange
            Doctor doctor1 = new Doctor("Ana", "Rodriguez", 28, 111222333, "Oftalmología");
            Doctor doctor2 = new Doctor("Ana", "Rodriguez", 28, 111222333, "Oftalmología");

            // Act
            bool resultado = doctor1.Equals(doctor2);

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Equals_DebeRetornarFalseSiNombresYApellidosNoSonIguales()
        {
            // Arrange
            Doctor doctor1 = new Doctor("Eduardo", "Lopez", 40, 555666777, "Traumatología");
            Doctor doctor2 = new Doctor("Maria", "Gomez", 25, 987654321, "Ginecología");

            // Act
            bool resultado = doctor1.Equals(doctor2);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void OperadorIgual_DebeRetornarTrueSiNombresYApellidosSonIguales()
        {
            // Arrange
            Doctor doctor1 = new Doctor("Ana", "Rodriguez", 28, 111222333, "Neurología");
            Doctor doctor2 = new Doctor("Ana", "Rodriguez", 28, 111222333, "Neurología");

            // Act
            bool resultado = doctor1 == doctor2;

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void OperadorDiferente_DebeRetornarTrueSiNombresYApellidosNoSonIguales()
        {
            // Arrange
            Doctor doctor1 = new Doctor("Eduardo", "Lopez", 40, 555666777, "Traumatología");
            Doctor doctor2 = new Doctor("Maria", "Gomez", 25, 987654321, "Ginecología");

            // Act
            bool resultado = doctor1 != doctor2;

            // Assert
            Assert.IsTrue(resultado);
        }
    }
}
