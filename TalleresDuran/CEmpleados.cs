using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalleresDuran
{
    public class CEmpleados
    {
        public int id_empleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string dui { get; set; }
        public string direccion { get; set; }
        public string sexo { get; set; }
        public string cargo { get; set; }
        public string password { get; set; }

        public CEmpleados(int id_empleado, string nombre, string apellido,
            int edad, string dui, string direccion, string sexo, string cargo,
            string password)
        {
            this.id_empleado = id_empleado;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dui = dui;
            this.direccion = direccion;
            this.sexo = sexo;
            this.cargo = cargo;
            this.password = password;
        }
    }
}
