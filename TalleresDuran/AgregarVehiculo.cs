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
    public partial class AgregarVehiculo : Form
    {
        public AgregarVehiculo()
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
            if (txtIdVehiculo.Text.Trim() != "" && cmbIdCliente.Text.Trim() != "Elija un cliente:" && txtVehiculo.Text.Trim() != "" &&
                txtPlacas.Text.Trim() != "" && txtColor.Text.Trim() != "" && txtModelo.Text.Trim() != "" && txtDescripcion.Text.Trim() != "")
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
