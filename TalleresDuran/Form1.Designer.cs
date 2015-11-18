namespace TalleresDuran
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.rbTPrincipal = new System.Windows.Forms.RibbonTab();
            this.rbTClientes = new System.Windows.Forms.RibbonTab();
            this.rbPClientes = new System.Windows.Forms.RibbonPanel();
            this.rbPCAdministracion = new System.Windows.Forms.RibbonPanel();
            this.rbTEmpleados = new System.Windows.Forms.RibbonTab();
            this.rbPEmpleados = new System.Windows.Forms.RibbonPanel();
            this.rbPEAdministracion = new System.Windows.Forms.RibbonPanel();
            this.rbBMostrarClientes = new System.Windows.Forms.RibbonButton();
            this.rbBAgregarCliente = new System.Windows.Forms.RibbonButton();
            this.rbBModificarCliente = new System.Windows.Forms.RibbonButton();
            this.rbBEliminarCliente = new System.Windows.Forms.RibbonButton();
            this.rbBMostrarEmpleados = new System.Windows.Forms.RibbonButton();
            this.rbBAgregarEmpleados = new System.Windows.Forms.RibbonButton();
            this.rbBModificarEmpleado = new System.Windows.Forms.RibbonButton();
            this.rbBEliminarEmpleado = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.RecentItemsCaption = null;
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbText = null;
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.AltKey = null;
            this.ribbon1.QuickAcessToolbar.CheckedGroup = null;
            this.ribbon1.QuickAcessToolbar.Image = null;
            this.ribbon1.QuickAcessToolbar.Tag = null;
            this.ribbon1.QuickAcessToolbar.Text = null;
            this.ribbon1.QuickAcessToolbar.ToolTip = null;
            this.ribbon1.QuickAcessToolbar.ToolTipTitle = null;
            this.ribbon1.QuickAcessToolbar.Value = null;
            this.ribbon1.Size = new System.Drawing.Size(737, 159);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.rbTPrincipal);
            this.ribbon1.Tabs.Add(this.rbTClientes);
            this.ribbon1.Tabs.Add(this.rbTEmpleados);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.TabSpacing = 6;
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ActiveTabChanged += new System.EventHandler(this.ribbon1_ActiveTabChanged);
            // 
            // rbTPrincipal
            // 
            this.rbTPrincipal.Tag = null;
            this.rbTPrincipal.Text = "Principal";
            this.rbTPrincipal.ToolTip = null;
            this.rbTPrincipal.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.rbTPrincipal.ToolTipImage = null;
            this.rbTPrincipal.ToolTipTitle = null;
            this.rbTPrincipal.Value = null;
            // 
            // rbTClientes
            // 
            this.rbTClientes.Panels.Add(this.rbPClientes);
            this.rbTClientes.Panels.Add(this.rbPCAdministracion);
            this.rbTClientes.Tag = null;
            this.rbTClientes.Text = "Clientes";
            this.rbTClientes.ToolTip = null;
            this.rbTClientes.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.rbTClientes.ToolTipImage = null;
            this.rbTClientes.ToolTipTitle = null;
            this.rbTClientes.Value = null;
            // 
            // rbPClientes
            // 
            this.rbPClientes.Items.Add(this.rbBMostrarClientes);
            this.rbPClientes.Tag = null;
            this.rbPClientes.Text = "Clientes";
            // 
            // rbPCAdministracion
            // 
            this.rbPCAdministracion.Items.Add(this.rbBAgregarCliente);
            this.rbPCAdministracion.Items.Add(this.rbBModificarCliente);
            this.rbPCAdministracion.Items.Add(this.rbBEliminarCliente);
            this.rbPCAdministracion.Tag = null;
            this.rbPCAdministracion.Text = "Administracion";
            // 
            // rbTEmpleados
            // 
            this.rbTEmpleados.Panels.Add(this.rbPEmpleados);
            this.rbTEmpleados.Panels.Add(this.rbPEAdministracion);
            this.rbTEmpleados.Tag = null;
            this.rbTEmpleados.Text = "Empleados";
            this.rbTEmpleados.ToolTip = null;
            this.rbTEmpleados.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.rbTEmpleados.ToolTipImage = null;
            this.rbTEmpleados.ToolTipTitle = null;
            this.rbTEmpleados.Value = null;
            // 
            // rbPEmpleados
            // 
            this.rbPEmpleados.Items.Add(this.rbBMostrarEmpleados);
            this.rbPEmpleados.Tag = null;
            this.rbPEmpleados.Text = "Empleados";
            // 
            // rbPEAdministracion
            // 
            this.rbPEAdministracion.Items.Add(this.rbBAgregarEmpleados);
            this.rbPEAdministracion.Items.Add(this.rbBModificarEmpleado);
            this.rbPEAdministracion.Items.Add(this.rbBEliminarEmpleado);
            this.rbPEAdministracion.Tag = null;
            this.rbPEAdministracion.Text = "Administracion";
            // 
            // rbBMostrarClientes
            // 
            this.rbBMostrarClientes.AltKey = null;
            this.rbBMostrarClientes.CheckedGroup = null;
            this.rbBMostrarClientes.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBMostrarClientes.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBMostrarClientes.Image = global::TalleresDuran.Properties.Resources.show_cliente;
            this.rbBMostrarClientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBMostrarClientes.SmallImage")));
            this.rbBMostrarClientes.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBMostrarClientes.Tag = null;
            this.rbBMostrarClientes.Text = "Mostrar";
            this.rbBMostrarClientes.ToolTip = null;
            this.rbBMostrarClientes.ToolTipTitle = null;
            this.rbBMostrarClientes.Value = null;
            this.rbBMostrarClientes.Click += new System.EventHandler(this.rbBMostrarClientes_Click);
            // 
            // rbBAgregarCliente
            // 
            this.rbBAgregarCliente.AltKey = null;
            this.rbBAgregarCliente.CheckedGroup = null;
            this.rbBAgregarCliente.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBAgregarCliente.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBAgregarCliente.Image = global::TalleresDuran.Properties.Resources.add_cliente;
            this.rbBAgregarCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBAgregarCliente.SmallImage")));
            this.rbBAgregarCliente.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBAgregarCliente.Tag = null;
            this.rbBAgregarCliente.Text = "Agregar";
            this.rbBAgregarCliente.ToolTip = null;
            this.rbBAgregarCliente.ToolTipTitle = null;
            this.rbBAgregarCliente.Value = null;
            this.rbBAgregarCliente.Click += new System.EventHandler(this.rbBAgregarCliente_Click);
            // 
            // rbBModificarCliente
            // 
            this.rbBModificarCliente.AltKey = null;
            this.rbBModificarCliente.CheckedGroup = null;
            this.rbBModificarCliente.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBModificarCliente.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBModificarCliente.Image = global::TalleresDuran.Properties.Resources.edit_cliente;
            this.rbBModificarCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBModificarCliente.SmallImage")));
            this.rbBModificarCliente.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBModificarCliente.Tag = null;
            this.rbBModificarCliente.Text = "Modificar";
            this.rbBModificarCliente.ToolTip = null;
            this.rbBModificarCliente.ToolTipTitle = null;
            this.rbBModificarCliente.Value = null;
            // 
            // rbBEliminarCliente
            // 
            this.rbBEliminarCliente.AltKey = null;
            this.rbBEliminarCliente.CheckedGroup = null;
            this.rbBEliminarCliente.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBEliminarCliente.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBEliminarCliente.Image = global::TalleresDuran.Properties.Resources.del_cliente;
            this.rbBEliminarCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBEliminarCliente.SmallImage")));
            this.rbBEliminarCliente.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBEliminarCliente.Tag = null;
            this.rbBEliminarCliente.Text = "Eliminar";
            this.rbBEliminarCliente.ToolTip = null;
            this.rbBEliminarCliente.ToolTipTitle = null;
            this.rbBEliminarCliente.Value = null;
            this.rbBEliminarCliente.Click += new System.EventHandler(this.rbBEliminarCliente_Click);
            // 
            // rbBMostrarEmpleados
            // 
            this.rbBMostrarEmpleados.AltKey = null;
            this.rbBMostrarEmpleados.CheckedGroup = null;
            this.rbBMostrarEmpleados.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBMostrarEmpleados.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBMostrarEmpleados.Image = global::TalleresDuran.Properties.Resources.show_employee;
            this.rbBMostrarEmpleados.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBMostrarEmpleados.SmallImage")));
            this.rbBMostrarEmpleados.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBMostrarEmpleados.Tag = null;
            this.rbBMostrarEmpleados.Text = "Mostrar";
            this.rbBMostrarEmpleados.ToolTip = null;
            this.rbBMostrarEmpleados.ToolTipTitle = null;
            this.rbBMostrarEmpleados.Value = null;
            // 
            // rbBAgregarEmpleados
            // 
            this.rbBAgregarEmpleados.AltKey = null;
            this.rbBAgregarEmpleados.CheckedGroup = null;
            this.rbBAgregarEmpleados.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBAgregarEmpleados.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBAgregarEmpleados.Image = global::TalleresDuran.Properties.Resources.add_employee;
            this.rbBAgregarEmpleados.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBAgregarEmpleados.SmallImage")));
            this.rbBAgregarEmpleados.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBAgregarEmpleados.Tag = null;
            this.rbBAgregarEmpleados.Text = "Agregar";
            this.rbBAgregarEmpleados.ToolTip = null;
            this.rbBAgregarEmpleados.ToolTipTitle = null;
            this.rbBAgregarEmpleados.Value = null;
            // 
            // rbBModificarEmpleado
            // 
            this.rbBModificarEmpleado.AltKey = null;
            this.rbBModificarEmpleado.CheckedGroup = null;
            this.rbBModificarEmpleado.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBModificarEmpleado.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBModificarEmpleado.Image = global::TalleresDuran.Properties.Resources.edit_employee;
            this.rbBModificarEmpleado.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBModificarEmpleado.SmallImage")));
            this.rbBModificarEmpleado.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBModificarEmpleado.Tag = null;
            this.rbBModificarEmpleado.Text = "Modificar";
            this.rbBModificarEmpleado.ToolTip = null;
            this.rbBModificarEmpleado.ToolTipTitle = null;
            this.rbBModificarEmpleado.Value = null;
            // 
            // rbBEliminarEmpleado
            // 
            this.rbBEliminarEmpleado.AltKey = null;
            this.rbBEliminarEmpleado.CheckedGroup = null;
            this.rbBEliminarEmpleado.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBEliminarEmpleado.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBEliminarEmpleado.Image = global::TalleresDuran.Properties.Resources.del_employee;
            this.rbBEliminarEmpleado.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBEliminarEmpleado.SmallImage")));
            this.rbBEliminarEmpleado.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBEliminarEmpleado.Tag = null;
            this.rbBEliminarEmpleado.Text = "Eliminar";
            this.rbBEliminarEmpleado.ToolTip = null;
            this.rbBEliminarEmpleado.ToolTipTitle = null;
            this.rbBEliminarEmpleado.Value = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 514);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab rbTClientes;
        private System.Windows.Forms.RibbonPanel rbPCAdministracion;
        private System.Windows.Forms.RibbonButton rbBAgregarCliente;
        private System.Windows.Forms.RibbonButton rbBEliminarCliente;
        private System.Windows.Forms.RibbonButton rbBModificarCliente;
        private System.Windows.Forms.RibbonTab rbTPrincipal;
        private System.Windows.Forms.RibbonPanel rbPClientes;
        private System.Windows.Forms.RibbonButton rbBMostrarClientes;
        private System.Windows.Forms.RibbonTab rbTEmpleados;
        private System.Windows.Forms.RibbonPanel rbPEmpleados;
        private System.Windows.Forms.RibbonPanel rbPEAdministracion;
        private System.Windows.Forms.RibbonButton rbBMostrarEmpleados;
        private System.Windows.Forms.RibbonButton rbBAgregarEmpleados;
        private System.Windows.Forms.RibbonButton rbBModificarEmpleado;
        private System.Windows.Forms.RibbonButton rbBEliminarEmpleado;
    }
}

