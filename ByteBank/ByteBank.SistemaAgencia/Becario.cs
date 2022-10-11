using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    internal class Becario : Empleado
    {
        public Becario(string _Dni) : base(_Dni, 20000)
        {
            Console.WriteLine("Constructor Administrativo");
        }

        protected override double obtenerBonificacion()
        {
            throw new NotImplementedException();
        }
    }
}
