using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalleresDuran
{
    public class CFacturas
    {
        public int id_factura { get; set; }
        public CVehiculo id_vehiculo { get; set; }
        public List<CTrabajos> cuentas { get; set; }
        public string descripcion { get; set; }
        public double total { get; set; }

        public CFacturas(int id_factura, CVehiculo id_vehiculo, List<CTrabajos> cuentas,
            string descripcion, double total)
        {
            this.id_factura = id_factura;
            this.id_vehiculo = id_vehiculo;
            this.cuentas = cuentas;
            this.descripcion = descripcion;
            this.total = total;
        }
    }
}
