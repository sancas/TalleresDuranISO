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
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "" && txtNombre.Text.Trim() != "" && txtApellido.Text.Trim() != "" && txtDireccion.Text.Trim() != "" &&
                txtDui.Text.Trim() != "" && txtEdad.Value.ToString() != "" && cmbSexo.Text.Trim() != "Elija una opcion:".Trim() &&
                cmbCargo.Text.Trim() != "Elija una opcion:".Trim())
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
