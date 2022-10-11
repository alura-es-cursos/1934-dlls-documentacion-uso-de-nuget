using ByteBank_ADM.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Administrativo
{
    public class Administrativo : Empleado
    {
        public Administrativo(string _Dni) : base(_Dni, 20000)
        {
            Console.WriteLine("Constructor Administrativo");
        }

        public override double obtenerBonificacion()
        {
            return this.Salario * 0.15;
        }
    }
}
