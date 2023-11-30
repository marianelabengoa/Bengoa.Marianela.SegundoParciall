using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    internal class PersonaTest
    {
        [TestMethod]
        public void ToString_DebeRetornarCadenaConDatosCorrectos()
        {
            // Arrange
            Doctor persona = new Doctor("juan", "rodriguez", 35, 123456789, "dermatologia");

            // Act
            string resultado = persona.ToString();

            // Assert
            StringAssert.Contains(resultado, "nombre: juan");
            StringAssert.Contains(resultado, "apellido: rodriguez");
            StringAssert.Contains(resultado, "edad: 35");
            StringAssert.Contains(resultado, "DNI 123456789");
        }

        [TestMethod]
        public void Equals_CuandoObjetoEsPersona_DebeRetornarTrue()
        {
            // Arrange
            Paciente persona1 = new Paciente("alicia", "fernandez", 30, 111111111, 2);
            Doctor persona2 = new Doctor("eugenio", "lopez", 45, 555555555, "traumatologia");

            // Act
            bool resultado = persona1.Equals(persona2);

            // Assert
            Assert.IsTrue(resultado);
        }


        [TestMethod]
        public void Pagar_ConPacienteGaleno_DebeRetornarMontoConDescuento30Porciento()
        {

            Paciente paciente = new Paciente("Eva", "Gonzalez", 28, 888888888, 1,EObraSocial.Galeno);

            // Act
            float resultado = paciente.Pagar(paciente);

            // Assert
            Assert.AreEqual(700.0f, resultado);
        }

        [TestMethod]
        public void Pagar_ConVisita_DebeRetornarMontoFijo1500()
        {
            // Arrange
            Visita persona = new Visita("miguel", "sanchez", 40, 777777777,"maria gonzalez");

            // Act
            float resultado = persona.Pagar(persona);

            // Assert
            Assert.AreEqual(1500.0f, resultado);
        }
    }
}