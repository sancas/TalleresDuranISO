using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalleresDuran
{
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            this.BringToFront();
        }

        public void MeterDatos(CTaller taller, int Tipo)
        {
            dgDatos.Columns.Clear();
            dgDatos.Rows.Clear();
            switch (Tipo)
            {
                case 0: //Clientes
                    dgDatos.Columns.Add("id_cliente", "ID");
                    dgDatos.Columns.Add("nombre", "Nombre");
                    dgDatos.Columns.Add("apellido", "Apellido");
                    dgDatos.Columns.Add("dui", "DUI");
                    dgDatos.Columns.Add("edad", "Edad");
                    dgDatos.Columns.Add("sexo", "Sexo");
                    foreach (CClientes cliente in taller.Clientes)
                    {
                        string[] Datos = 
                        {
                            cliente.id_cliente.ToString(),
                            cliente.nombre,
                            cliente.apellido,
                            cliente.dui,
                            cliente.edad.ToString(),
                            cliente.sexo
                        };
                        dgDatos.Rows.Add(Datos);
                    }
                    break;
                case 1: //Empleados
                    dgDatos.Columns.Add("id_empleado", "ID");
                    dgDatos.Columns.Add("nombre", "Nombre");
                    dgDatos.Columns.Add("apellido", "Apellido");
                    dgDatos.Columns.Add("dui", "DUI");
                    dgDatos.Columns.Add("direccion", "Direccion");
                    dgDatos.Columns.Add("sexo", "Sexo");
                    dgDatos.Columns.Add("cargo", "Cargo");
                    dgDatos.Columns.Add("password", "Password");
                    foreach (CEmpleados empleado in taller.Empleados)
                    {
                        string[] Datos =
                        {
                            empleado.id_empleado.ToString(),
                            empleado.nombre,
                            empleado.apellido,
                            empleado.dui,
                            empleado.direccion,
                            empleado.sexo,
                            empleado.cargo,
                            empleado.password
                        };
                        dgDatos.Rows.Add(Datos);
                    }
                    break;
                case 2: //Vehiculos
                    dgDatos.Columns.Add("id_vehiculo", "ID Vehiculo");
                    dgDatos.Columns.Add("id_cliente", "ID Cliente");
                    dgDatos.Columns.Add("vehiculo", "Vehiculo");
                    dgDatos.Columns.Add("placas", "Placas");
                    dgDatos.Columns.Add("anho", "Año");
                    dgDatos.Columns.Add("color", "Color");
                    dgDatos.Columns.Add("modelo", "Modelo");
                    dgDatos.Columns.Add("descripcion", "Descripcion");
                    foreach (CVehiculo vehiculo in taller.Vehiculos)
                    {
                        string[] Datos =
                        {
                            vehiculo.id_vehiculo.ToString(),
                            vehiculo.id_cliente.id_cliente.ToString(),
                            vehiculo.vehiculo,
                            vehiculo.placas.ToString(),
                            vehiculo.anho,
                            vehiculo.color,
                            vehiculo.modelo,
                            vehiculo.descripcion
                        };
                        dgDatos.Rows.Add(Datos);
                    }
                    break;
                case 3: //Trabajos
                    dgDatos.Columns.Add("id_trabajo", "ID Trabajo");
                    dgDatos.Columns.Add("id_empleado", "ID Empleado");
                    dgDatos.Columns.Add("id_vehiculo", "ID Vehiculo");
                    dgDatos.Columns.Add("nombre", "Nombre");
                    dgDatos.Columns.Add("descripcion", "Descripcion");
                    dgDatos.Columns.Add("estado", "Estado");
                    foreach (CTrabajos trabajo in taller.Trabajos)
                    {
                        string[] Datos =
                        {
                            trabajo.id_trabajo.ToString(),
                            trabajo.id_empleado.id_empleado.ToString(),
                            trabajo.id_vehiculo.id_vehiculo.ToString(),
                            trabajo.nombre,
                            trabajo.descripcion,
                            trabajo.estado
                        };
                        dgDatos.Rows.Add(Datos);
                    }
                    break;
                case 4: //Facturas
                    dgDatos.Columns.Add("id_factura", "ID Factura");
                    dgDatos.Columns.Add("id_vehiculo", "ID Vehiculo");
                    dgDatos.Columns.Add("trabajos", "Trabajos");
                    dgDatos.Columns.Add("descripcion", "Descripcion");
                    dgDatos.Columns.Add("total", "Total");
                    foreach (CFacturas factura in taller.Facturas)
                    {
                        string[] Datos =
                        {
                            factura.id_factura.ToString(),
                            factura.id_vehiculo.id_vehiculo.ToString(),
                            factura.cuentas.Count.ToString(),
                            factura.descripcion,
                            factura.total.ToString()
                        };
                        dgDatos.Rows.Add(Datos);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
