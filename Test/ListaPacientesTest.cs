using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Test
{
    using global::Entidades;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Linq;

    namespace Entidades.Tests
    {
        [TestClass]
        public class ListaPacientesTests
        {
            [TestMethod]
            public void ToString_DebeRetornarDatosCorrectos()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();
                Paciente paciente1 = new Paciente("Juan", "Perez", 30, 123456789, 1);
                Paciente paciente2 = new Paciente("Maria", "Gomez", 25, 987654321, 2);
                lista.Agregar(paciente1);
                lista.Agregar(paciente2);

                // Act
                string resultado = lista.ToString();

                // Assert
                StringAssert.Contains(resultado, "Nombre: Juan");
                StringAssert.Contains(resultado, "Apellido: Perez");
                StringAssert.Contains(resultado, "Edad: 30");
                StringAssert.Contains(resultado, "DNI: 123456789");
                StringAssert.Contains(resultado, "numeroHabitacion: 1");
                StringAssert.Contains(resultado, "Nombre: Maria");
                StringAssert.Contains(resultado, "Apellido: Gomez");
                StringAssert.Contains(resultado, "Edad: 25");
                StringAssert.Contains(resultado, "DNI: 987654321");
                StringAssert.Contains(resultado, "numeroHabitacion: 2");

            }

            [TestMethod]
            public void OperadorIgual_DebeRetornarTrueSiContienePaciente()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();
                Paciente paciente = new Paciente("Ana", "Rodriguez", 28, 111222333, 1);
                lista.Agregar(paciente);

                // Act
                bool resultado = lista == paciente;

                // Assert
                Assert.IsTrue(resultado);
            }

            [TestMethod]
            public void OperadorDiferente_DebeRetornarTrueSiNoContienePaciente()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();
                Paciente paciente = new Paciente("Eduardo", "Lopez", 40, 555666777, 1);

                // Act
                bool resultado = lista != paciente;

                // Assert
                Assert.IsTrue(resultado);
            }

            [TestMethod]
            public void OperadorSuma_DebeAgregarPacienteSiNoExiste()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();
                Paciente paciente = new Paciente("Laura", "Fernandez", 35, 444555666,3);

                // Act
                bool resultado = lista + paciente;

                // Assert
                Assert.IsTrue(resultado);
                Assert.AreEqual(1, lista.Obtener().Count);
            }

            [TestMethod]
            public void OperadorResta_DebeEliminarPacienteSiExiste()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();
                Paciente paciente = new Paciente("Pedro", "Lopez", 45, 777888999, 1);
                lista.Agregar(paciente);

                // Act
                bool resultado = lista - paciente;

                // Assert
                Assert.IsTrue(resultado);
                Assert.AreEqual(0, lista.Obtener().Count);
            }

            [TestMethod]
            public void OrdenarPorEdadAscendente_DebeOrdenarCorrectamente()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();
                Paciente paciente1 = new Paciente("Juan", "Perez", 30, 123456789,5);
                Paciente paciente2 = new Paciente("Maria", "Gomez", 25, 987654321, 6);
                Paciente paciente3 = new Paciente("Eduardo", "Lopez", 40, 555666777, 4);
                lista.Agregar(paciente1);
                lista.Agregar(paciente2);
                lista.Agregar(paciente3);

                // Act
                var resultado = lista.OrdenarPorEdadAscendente();

                // Assert
                Assert.AreEqual(25, resultado.First().Edad);
                Assert.AreEqual(40, resultado.Last().Edad);
            }

            [TestMethod]
            public void OrdenarPorEdadDescendente_DebeOrdenarCorrectamente()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();
                Paciente paciente1 = new Paciente("Juan", "Perez", 30, 123456789, 9);
                Paciente paciente2 = new Paciente("Maria", "Gomez", 25, 987654321, 10);
                Paciente paciente3 = new Paciente("Eduardo", "Lopez", 40, 555666777, 11);
                lista.Agregar(paciente1);
                lista.Agregar(paciente2);
                lista.Agregar(paciente3);

                // Act
                var resultado = lista.OrdenarPorEdadDescendente();

                // Assert
                Assert.AreEqual(40, resultado.First().Edad);
                Assert.AreEqual(25, resultado.Last().Edad);
            }

            [TestMethod]
            public void Indexador_DebeRetornarPacienteCorrecto()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();
                Paciente paciente1 = new Paciente("Juan", "Perez", 30, 123456789, 15);
                Paciente paciente2 = new Paciente("Maria", "Gomez", 25, 987654321, 14);
                lista.Agregar(paciente1);
                lista.Agregar(paciente2);

                // Act
                var resultado = lista[1];

                // Assert
                Assert.AreEqual("Maria", resultado.Nombre);
            }

            [TestMethod]
            public void Indexador_DebeLanzarExcepcionSiIndiceFueraDeRango()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();

                // Act y Assert
                Assert.ThrowsException<IndexOutOfRangeException>(() => { var resultado = lista[0]; });
            }

            [TestMethod]
            public void Verificar_DebeRetornarTrueSiHayPacientes()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();
                Paciente paciente = new Paciente("Ana", "Rodriguez", 28, 111222333, 17);
                lista.Agregar(paciente);

                // Act
                bool resultado = lista.Verificar();

                // Assert
                Assert.IsTrue(resultado);
            }

            [TestMethod]
            public void Verificar_DebeRetornarFalseSiNoHayPacientes()
            {
                // Arrange
                ListaPacientes lista = new ListaPacientes();

                // Act
                bool resultado = lista.Verificar();

                // Assert
                Assert.IsFalse(resultado);
            }
        }
    }

}
