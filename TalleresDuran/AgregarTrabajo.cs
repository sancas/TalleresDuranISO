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
    public partial class AgregarTrabajo : Form
    {
        public AgregarTrabajo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtIDTrabajo.Text.Trim() != "" && cmbIDEmpleado.Text.Trim() != "Elija una opcion:".Trim() && cmbIDVehiculo.Text.Trim() != "Elija una opcion:" &&
                txtNombre.Text.Trim() != "" && txtDescripcion.Text.Trim() != "" && cmbEstado.Text.Trim() != "Elija una opcion:".Trim())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe completar todos los datos",
                    "Error de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
