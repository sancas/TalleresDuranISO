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
            else
            {

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
    }
}
