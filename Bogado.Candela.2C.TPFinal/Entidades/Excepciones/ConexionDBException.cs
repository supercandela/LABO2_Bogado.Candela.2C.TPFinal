using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ConexionDBException : Exception
    {
        public ConexionDBException(string mensaje)
            :base(mensaje)
        { 
            
        }

        public ConexionDBException(string mensaje, Exception innerException)
            :base(mensaje, innerException)
        {

        }
    }
}
