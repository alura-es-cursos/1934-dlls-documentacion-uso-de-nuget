using ByteBank_ADM.Autenticables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.SocioComerciales
{
    public class SocioComercial : IAutenticable
    {
        public string Clave { get; set; }
        public bool autenticarUsuario(string clave)
        {
            return this.Clave == clave;
        }
    }
}
