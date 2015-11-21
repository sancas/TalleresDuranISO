using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalleresDuran
{
    public class CTrabajos
    {
        public int id_trabajo { get; set; }
        public CEmpleados id_empleado { get; set; }
        public CVehiculo id_vehiculo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
        public double costo { get; set; }

        public CTrabajos(int id_trabajo, CEmpleados id_empleado, CVehiculo id_vehiculo,
            string nombre, string descripcion, string estado, double costo)
        {
            this.id_trabajo = id_trabajo;
            this.id_empleado = id_empleado;
            this.id_vehiculo = id_vehiculo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.estado = estado;
            this.costo = costo;
        }
    }
}
