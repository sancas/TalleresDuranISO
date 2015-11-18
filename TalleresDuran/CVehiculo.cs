using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalleresDuran
{
    public class CVehiculo
    {
        public int id_vehiculo { get; set; }
        public CClientes id_cliente { get; set; }
        public string vehiculo { get; set; }
        public int placas { get; set; }
        public string anho { get; set; }
        public string color { get; set; }
        public string modelo { get; set; }
        public string descripcion { get; set; }

        public CVehiculo(int id_vehiculo, CClientes id_cliente, string vehiculo,
            int placas, string anho, string color, string modelo, string descripcion)
        {
            this.id_vehiculo = id_vehiculo;
            this.id_cliente = id_cliente;
            this.vehiculo = vehiculo;
            this.placas = placas;
            this.anho = anho;
            this.color = color;
            this.modelo = modelo;
            this.descripcion = descripcion;
        }
    }
}
