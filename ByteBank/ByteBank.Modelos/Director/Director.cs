using ByteBank_ADM.Autenticables;
using ByteBank_ADM.EmpleadoAutenticables;
using ByteBank_ADM.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Directores
{
    public class Director: EmpleadoAutenticable, IAutenticable
    {
        
        public Director(string _Dni):base(_Dni, 50000)
        {
            Console.WriteLine("Constructor Director");
        }
        
        public string Departamento { get; set; }

        public override double obtenerBonificacion()
        {
            return this.Salario * 0.50;

        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.05;
        }

        
    }
}
