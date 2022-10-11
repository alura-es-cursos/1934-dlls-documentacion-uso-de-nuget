using ByteBank_ADM.Empleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.EmpleadoAutenticables
{
    public class EmpleadoAutenticable:Empleado
    {
        public EmpleadoAutenticable(string _Dni, double _Salario) : base(_Dni, _Salario)
        {
        }

        public string Clave { get; set; }
        public bool autenticarUsuario(string clave)
        {
            return this.Clave == clave;
        }

        public override double obtenerBonificacion()
        {
            return 0;
        }
    }
}
