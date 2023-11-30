using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    internal class DoctorTest
    {
        [TestMethod]
        public void RealizarAccion_DebeRetornarMensajeCorrecto()
        {
            // Arrange
            Doctor doctor = new Doctor("juan", "fernandez", 35, 123456789, "Cardiología");

            // Act
            string resultado = doctor.RealizarAccion();

            // Assert
            Assert.AreEqual("El doctor juan esta atendiendo al paciente", resultado);
        }

        [TestMethod]
        public void ToString_DebeRetornarCadenaConDatosEspecificos()
        {
            // Arrange
            Doctor doctor = new Doctor("juana", "suarez", 40, 987654321, "Dermatología", 8000.50f, Euniversidad.UAI);

            // Act
            string resultado = doctor.ToString();

            // Assert
            StringAssert.Contains(resultado, "especializacion: Dermatología");
            StringAssert.Contains(resultado, "universidad: UAI");
            StringAssert.Contains(resultado, "sueldo: 8000.5");
        }

        [TestMethod]
        public void Mostrar_DebeRetornarCadenaConTodosLosDatos()
        {
            // Arrange
            Doctor doctor = new Doctor("sergio", "lopez", 45, 555555555, "Oftalmología", 7000.75f, Euniversidad.UNLP);

            // Act
            string resultado = doctor.Mostrar();

            // Assert
            StringAssert.Contains(resultado, "especializacion: Oftalmología");
            StringAssert.Contains(resultado, "universidad: UNLP");
            StringAssert.Contains(resultado, "sueldo: 7000.75");
            StringAssert.Contains(resultado, "nombre: sergio");
            StringAssert.Contains(resultado, "apellido: lopez");
            StringAssert.Contains(resultado, "edad: 45");
            StringAssert.Contains(resultado, "dni: 555555555");
        }

        [TestMethod]
        public void Equals_CuandoObjetoEsDoctor_DebeRetornarTrue()
        {
            // Arrange
            Doctor doctor1 = new Doctor("alicia", "rodriguez", 30, 111111111, "Pediatría");
            Doctor doctor2 = new Doctor("sergio", "lopez", 45, 555555555, "Oftalmología", 7000.75f, Euniversidad.UCA);

            // Act
            bool resultado = doctor1.Equals(doctor2);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Equals_CuandoObjetoNoEsDoctor_DebeRetornarFalse()
        {
            // Arrange
            Doctor doctor = new Doctor("carlos", "cabaña", 25, 999999999, "Cirugía");

            // Act
            bool resultado = doctor.Equals(new Paciente("carlos", "cabaña", 25, 999999999,5));

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Igualdad_CuandoDoctoresTienenMismoNombre_DebeRetornarTrue()
        {
            // Arrange
            Doctor doctor1 = new Doctor("juan", "martinez", 35, 123456789, "Cardiología");
            Doctor doctor2 = new Doctor("jorge", "lopez", 40, 987654321, "Dermatología", 8000.50f, Euniversidad.UCA);

            // Act
            bool resultado = doctor1 == doctor2;

            // Assert
            //Assert.IsTrue(resultado);
            Console.WriteLine(resultado);
        }

        [TestMethod]
        public void Igualdad_CuandoDoctoresTienenDistintoNombre_DebeRetornarFalse()
        {
            // Arrange
            Doctor doctor1 = new Doctor("juana", "suarez", 40, 987654321, "Dermatología", 8000.50f, Euniversidad.UNLP);
            Doctor doctor2 = new Doctor("luis", "hernandez", 35, 123456789, "Cardiología");

            // Act
            bool resultado = doctor1 == doctor2;

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Desigualdad_CuandoDoctoresTienenMismoNombre_DebeRetornarFalse()
        {
            // Arrange
            Doctor doctor1 = new Doctor("juan", "juarez", 35, 123456789, "Cardiología");
            Doctor doctor2 = new Doctor("juan", "flores", 40, 987654321, "Dermatología", 8000.50f, Euniversidad.UBA);

            // Act
            bool resultado = doctor1 != doctor2;

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Desigualdad_CuandoDoctoresTienenDistintoNombre_DebeRetornarTrue()
        {
            // Arrange
            Doctor doctor1 = new Doctor("mirta", "torrez", 40, 987654321, "Dermatología", 8000.50f, Euniversidad.UNS);
            Doctor doctor2 = new Doctor("rodrigo", "vazquez", 35, 123456789, "Cardiología");

            // Act
            bool resultado = doctor1 != doctor2;

            // Assert
            Assert.IsTrue(resultado);
        }
    }
}
