using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clases
{
    public static class ExtiendeListaDeAlquileres
    {
        /// <summary>
        /// Ordena lista de alquileres desde el más reciente.
        /// </summary>
        /// <param name="lista">Lista de alquileres</param>
        /// <returns>Lista de Alquileres</returns>
        public static List<Alquiler> OrdenarPorFechaReciente(this List<Alquiler> lista)
        {
            return lista.OrderByDescending(x => x.FechaInicio).ToList();
        }
    }
}
