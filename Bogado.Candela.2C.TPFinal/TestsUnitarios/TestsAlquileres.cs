using Entidades.Clases;
using System.Collections.Generic;

namespace TestsUnitarios
{
    [TestClass]
    public class TestsAlquileres
    {
        [TestMethod]
        public void AlLlamar_OrdenarPorFechaReciente_SeEspera_OrdenarOK()
        {
            //Arrange
            Alquiler alq1 = new Alquiler(1, 5, "supercandela", 1, "Sueños de Libertad", "03/18/2021", "03/19/2021");
            Alquiler alq2 = new Alquiler(2, 5, "supercandela", 6, "El señor de los Anillos: El retorno del rey", "11/09/2023", "11/11/2023");
            Alquiler alq3 = new Alquiler(3, 5, "supercandela", 8, "Tiempos Violentos", "11/02/2023", "11/04/2023");
            Alquiler alq4 = new Alquiler(4, 5, "supercandela", 9, "Forrest Gump", "11/16/2023", "11/17/2023");
            Alquiler alq5 = new Alquiler(5, 5, "supercandela", 2, "El Padrino", "09/28/2023", "09/29/2023");
            Alquiler alq6 = new Alquiler(6, 5, "supercandela", 2, "El Padrino", "03/16/2023", "03/18/2023");

            List<Alquiler> listaOriginal = new List<Alquiler> { alq1, alq2, alq3, alq4, alq5, alq6 };

            List<Alquiler> listaEsperada = new List<Alquiler> { alq4, alq2, alq3, alq5, alq1, alq6};

            //Act

            listaOriginal = listaOriginal.OrdenarPorFechaReciente();


            //Assert

            CollectionAssert.AreEqual(listaEsperada, listaOriginal);

        }

        [TestMethod]
        public void AlLlamar_OrdenarPorFechaReciente_SeEspera_FallaOrden_ComparaListaOriginalConListaOrdenada()
        {
            //Arrange
            Alquiler alq1 = new Alquiler(1, 5, "supercandela", 1, "Sueños de Libertad", "03/18/2021", "03/19/2021");
            Alquiler alq2 = new Alquiler(2, 5, "supercandela", 6, "El señor de los Anillos: El retorno del rey", "11/09/2023", "11/11/2023");
            Alquiler alq3 = new Alquiler(3, 5, "supercandela", 8, "Tiempos Violentos", "11/02/2023", "11/04/2023");
            Alquiler alq4 = new Alquiler(4, 5, "supercandela", 9, "Forrest Gump", "11/16/2023", "11/17/2023");
            Alquiler alq5 = new Alquiler(5, 5, "supercandela", 2, "El Padrino", "09/28/2023", "09/29/2023");
            Alquiler alq6 = new Alquiler(6, 5, "supercandela", 2, "El Padrino", "03/16/2023", "03/18/2023");

            List<Alquiler> listaOriginal = new List<Alquiler> { alq1, alq2, alq3, alq4, alq5, alq6 };

            //Act

            List < Alquiler > listaOrdenada = listaOriginal.OrdenarPorFechaReciente();


            //Assert

            CollectionAssert.AreNotEqual(listaOrdenada, listaOriginal);

        }
    }
}