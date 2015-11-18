using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalleresDuran
{
    public class CClientes
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string dui { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }

        public CClientes(int id_cliente, string nombre, string apellido,
            string direccion, string dui, int edad, string sexo)
        {
            this.id_cliente = id_cliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.dui = dui;
            this.edad = edad;
            this.sexo = sexo;
        }
    }
}
