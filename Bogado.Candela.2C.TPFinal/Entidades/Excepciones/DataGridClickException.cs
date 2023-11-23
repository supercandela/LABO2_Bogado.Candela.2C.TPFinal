using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class DataGridClickException : Exception
    {
        public DataGridClickException(string mensaje)
            :base(mensaje)
        { 
            
        }

        public DataGridClickException(string mensaje, Exception innerException)
            :base(mensaje, innerException)
        {

        }
    }
}
