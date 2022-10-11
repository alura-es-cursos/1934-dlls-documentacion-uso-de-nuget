using ByteBank_ADM.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Autenticables
{
    public interface IAutenticable
    {

        public bool autenticarUsuario(string clave);

    }
}
