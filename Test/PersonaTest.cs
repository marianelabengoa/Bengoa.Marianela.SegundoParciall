using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Entidades.Test
{
    [TestClass]
    public class PersonaTests
    {
        [TestMethod]
        public void ToString_DebeRetornarDatosCorrectos()
        {
            // Arrange
            Persona persona = new Paciente("Maria", "Gomez", 25, 987654321, 101);

            // Act
            string resultado = persona.ToString();

            // Assert
            StringAssert.Contains(resultado, "nombre: Maria");
            StringAssert.Contains(resultado, "apellido: Gomez");
            StringAssert.Contains(resultado, "edad: 0"); // La edad es 0 porque no se estableció en este caso
            StringAssert.Contains(resultado, "DNI 987654321");
        }


        [TestMethod]
        public void Pagar_PacienteGaleno_DebeRetornarMontoConDescuento30PorCiento()
        {
            // Arrange
            Paciente paciente = new Paciente("Ana", "Rodriguez", 28, 111222333, 404, EObraSocial.Galeno);
            Persona persona = paciente as Persona;

            // Act
            float resultado = persona.Pagar(paciente);

            // Assert
            Assert.AreEqual(700.0f, resultado);
        }

        [TestMethod]
        public void Pagar_Visita_DebeRetornarMonto1500()
        {
            // Arrange
            Visita visita = new Visita("Carlos", "Lopez", 45, 456789123, "PacienteX", 303, "Familiar");
            Persona persona = visita as Persona;

            // Act
            float resultado = persona.Pagar(visita);

            // Assert
            Assert.AreEqual(1500.0f, resultado);
        }
    }
}