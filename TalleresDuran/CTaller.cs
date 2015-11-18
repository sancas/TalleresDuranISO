using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalleresDuran
{
    public class CTaller
    {
        public List<CEmpleados> Empleados;
        public List<CTrabajos> Trabajos;
        public List<CClientes> Clientes;
        public List<CVehiculo> Vehiculos;
        //public List<CFacturas> Facturas;

        public CTaller()
        {
            Empleados = new List<CEmpleados>();
            Trabajos = new List<CTrabajos>();
            Clientes = new List<CClientes>();
            Vehiculos = new List<CVehiculo>();
        }
    }
}
