using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace TalleresDuran
{
    public partial class Form1 : Form
    {
        public CTaller Taller;

        public Form1()
        {
            InitializeComponent();
            Taller = new CTaller();
            Taller.Clientes.Add(new CClientes(1, "Cristian", "Sanchez", "Rpto. 1 Calle Nic", "04845876-8", 22, "MASCULINO"));
            Taller.Clientes.Add(new CClientes(2, "Kevin", "Ferman", "Haya por quezalte", "07452356-6", 22, "MASCULINO"));
            Taller.Clientes.Add(new CClientes(3, "Oscar", "Marcial", "Re-lejos... por perulapia", "06341875-4", 22, "FEMENINO"));
            Taller.Empleados.Add(new CEmpleados(1, "Juan", "Garcia", 35, "07432124-8", "Calle lopez jugar historico", "MASCULINO", "MECANICO", ""));
            Taller.Empleados.Add(new CEmpleados(2, "Lucas", "Lopez", 55, "65334215-6", "Parque el grid calle las americas", "MASCULINO", "JEFE", ""));
            Taller.Vehiculos.Add(new CVehiculo(1, Taller.Clientes[0], "Toyota", 242145, "2015", "Blanco", "Yaris", "Se vino el carro con choque delantero, con las luces arruinadas"));
            Taller.Trabajos.Add(new CTrabajos(1, Taller.Empleados[1], Taller.Vehiculos[0], "Reemplazo de capo", "Se reempazo el capo por uno nuevo", "SIN INICIAR", 225.22));
            Taller.Trabajos.Add(new CTrabajos(2, Taller.Empleados[1], Taller.Vehiculos[0], "Cambio de luces delanteras", "Se cambiaron los focos delanteros ya que quedaron inutilizables", "TERMINADO", 159.99));
        }

        public static string MD5Encrypt(string value)
        {
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();

            byte[] data = System.Text.Encoding.ASCII.GetBytes(value);
            data = provider.ComputeHash(data);

            string md5 = string.Empty;

            for (int i = 0; i < data.Length; i++)
                md5 += data[i].ToString("x2").ToLower();

            return md5;
        }

        private void rbBAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente cliente = new AgregarCliente();
            cliente.ShowDialog();
            if (cliente.DialogResult == DialogResult.OK)
            {
                Taller.Clientes.Add(new CClientes(
                    int.Parse(cliente.txtID.Text),
                    cliente.txtNombre.Text,
                    cliente.txtApellido.Text,
                    cliente.txtDireccion.Text,
                    cliente.txtDui.Text,
                    int.Parse(cliente.txtEdad.Value.ToString()),
                    cliente.cmbSexo.Text
                    ));
                MessageBox.Show("Cliente ingresado.");
                rbBMostrarClientes.PerformClick();
            }
        }

        private void rbBEliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente cliente = new EliminarCliente();
            cliente.ShowDialog();
            if (cliente.DialogResult == DialogResult.OK)
            {
                if (Taller.Clientes.Remove(Taller.Clientes.Find(v => v.id_cliente == int.Parse(cliente.txtID.Text))))
                    MessageBox.Show("Cliente eliminado correctamente.");
                else
                    MessageBox.Show("No se pudo eliminar al cliente.");
            }
            rbBMostrarClientes.PerformClick();
        }

        private void ribbon1_ActiveTabChanged(object sender, EventArgs e)
        {
            if (ribbon1.ActiveTab.Text == "Clientes")
                rbBMostrarClientes.PerformClick();
            else if (ribbon1.ActiveTab.Text == "Empleados")
                rbBMostrarEmpleados.PerformClick();
            else if (ribbon1.ActiveTab.Text == "Vehiculos")
                rbBMostrarCarros.PerformClick();
            else if (ribbon1.ActiveTab.Text == "Trabajos")
                rbBMostrarTrabajos.PerformClick();
            else if (ribbon1.ActiveTab.Text == "Facturas")
                rbBMostrarFacturas.PerformClick();
            else
            {
                while (this.ActiveMdiChild != null)
                {
                    this.ActiveMdiChild.Close();
                }
            }
        }

        private void rbBMostrarClientes_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Form1))
                {
                    f.Activate();
                    return;
                }
            }
            Mostrar clientes = new Mostrar();
            clientes.MdiParent = this;
            clientes.MeterDatos(Taller, 0);
            clientes.Show();
        }

        private void rbBMostrarEmpleados_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Form1))
                {
                    f.Activate();
                    return;
                }
            }
            Mostrar empleados = new Mostrar();
            empleados.MdiParent = this;
            empleados.MeterDatos(Taller, 1);
            empleados.Show();
        }

        private void rbBMostrarCarros_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Form1))
                {
                    f.Activate();
                    return;
                }
            }
            Mostrar vehiculos = new Mostrar();
            vehiculos.MdiParent = this;
            vehiculos.MeterDatos(Taller, 2);
            vehiculos.Show();
        }

        private void rbBAgregarEmpleados_Click(object sender, EventArgs e)
        {
            AgregarEmpleado empleado = new AgregarEmpleado();
            empleado.ShowDialog();
            if (empleado.DialogResult == DialogResult.OK)
            {
                Taller.Empleados.Add(new CEmpleados(
                    int.Parse(empleado.txtID.Text),
                    empleado.txtNombre.Text,
                    empleado.txtApellido.Text,
                    int.Parse(empleado.txtEdad.Value.ToString()),
                    empleado.txtDui.Text,
                    empleado.txtDireccion.Text,
                    empleado.cmbSexo.Text,
                    empleado.cmbCargo.Text,
                    MD5Encrypt("123456")
                    ));
                MessageBox.Show("Empleado ingresado.");
                rbBMostrarEmpleados.PerformClick();
            }
        }

        private void rbBAgregarCarro_Click(object sender, EventArgs e)
        {
            AgregarVehiculo vehiculo = new AgregarVehiculo();
            foreach (CClientes cliente in Taller.Clientes)
            {
                vehiculo.cmbIdCliente.Items.Add(cliente.id_cliente);
            }
            vehiculo.ShowDialog();
            if (vehiculo.DialogResult == DialogResult.OK)
            {
                Taller.Vehiculos.Add(new CVehiculo(
                    int.Parse(vehiculo.txtIdVehiculo.Text),
                    Taller.Clientes.Find(v => v.id_cliente.ToString() == vehiculo.cmbIdCliente.Text),
                    vehiculo.txtVehiculo.Text,
                    int.Parse(vehiculo.txtPlacas.Text),
                    vehiculo.txtAnho.Text,
                    vehiculo.txtColor.Text,
                    vehiculo.txtModelo.Text,
                    vehiculo.txtDescripcion.Text
                    ));
                MessageBox.Show("Vehiculo ingresado.");
                rbBMostrarCarros.PerformClick();
            }
        }

        private void rbBMostrarTrabajos_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Form1))
                {
                    f.Activate();
                    return;
                }
            }
            Mostrar trabajos = new Mostrar();
            trabajos.MdiParent = this;
            trabajos.MeterDatos(Taller, 3);
            trabajos.Show();
        }

        private void rbBAgregarTrabajo_Click(object sender, EventArgs e)
        {
            AgregarTrabajo trabajo = new AgregarTrabajo();
            foreach (CVehiculo vehiculo in Taller.Vehiculos)
            {
                trabajo.cmbIDEmpleado.Items.Add(vehiculo.id_vehiculo);
            }
            foreach (CEmpleados empleado in Taller.Empleados)
            {
                trabajo.cmbIDEmpleado.Items.Add(empleado.id_empleado);
            }
            trabajo.ShowDialog();
            if (trabajo.DialogResult == DialogResult.OK)
            {
                Taller.Trabajos.Add(new CTrabajos(
                    int.Parse(trabajo.txtIDTrabajo.Text),
                    Taller.Empleados.Find(v => v.id_empleado.ToString() == trabajo.cmbIDEmpleado.Text),
                    Taller.Vehiculos.Find(v => v.id_vehiculo.ToString() == trabajo.cmbIDVehiculo.Text),
                    trabajo.txtNombre.Text,
                    trabajo.txtDescripcion.Text,
                    trabajo.cmbEstado.Text,
                    double.Parse(trabajo.txtCosto.Value.ToString())
                    ));
                MessageBox.Show("Trabajo Agregado");
                rbBMostrarTrabajos.PerformClick();
            }
        }

        private void rbBEntregarAuto_Click(object sender, EventArgs e)
        {
            EntregarAuto factura = new EntregarAuto();
            foreach (CVehiculo vehiculo in Taller.Vehiculos)
            {
                factura.cmbID.Items.Add(vehiculo.id_vehiculo);
            }
            factura.ShowDialog();
            if (factura.DialogResult == DialogResult.OK)
            {
                double total = 0;
                List<CTrabajos> losTrabajos = new List<CTrabajos>();
                foreach (CTrabajos trabajo in Taller.Trabajos)
                {
                    if (trabajo.id_vehiculo == Taller.Vehiculos.Find(v => v.id_vehiculo.ToString() == factura.cmbID.Text))
                    {
                        losTrabajos.Add(trabajo);
                        total += trabajo.costo;
                        trabajo.estado = "TERMINADO";
                    }
                }
                Taller.Facturas.Add(new CFacturas(
                    Taller.Facturas.Count,
                    Taller.Vehiculos.Find(v => v.id_vehiculo.ToString() == factura.cmbID.Text),
                    losTrabajos,
                    factura.txtDescripcion.Text,
                    total
                    ));
                ribbon1.ActiveTab = ribbon1.Tabs.Find(v => v.Text == "Facturas");
                rbBMostrarFacturas.PerformClick();
            }
        }

        private void rbBMostrarFacturas_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(Form1))
                {
                    f.Activate();
                    return;
                }
            }
            Mostrar facturas = new Mostrar();
            facturas.MdiParent = this;
            facturas.MeterDatos(Taller, 4);
            facturas.Show();
        }
    }
}
