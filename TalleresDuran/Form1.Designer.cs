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
            this.rbTPrincipal = new System.Windows.Forms.RibbonTab();
            this.rbTClientes = new System.Windows.Forms.RibbonTab();
            this.rbPClientes = new System.Windows.Forms.RibbonPanel();
            this.rbPCAdministracion = new System.Windows.Forms.RibbonPanel();
            this.rbTEmpleados = new System.Windows.Forms.RibbonTab();
            this.rbPEmpleados = new System.Windows.Forms.RibbonPanel();
            this.rbPEAdministracion = new System.Windows.Forms.RibbonPanel();
            this.rbTVehiculos = new System.Windows.Forms.RibbonTab();
            this.rbPVehiculo = new System.Windows.Forms.RibbonPanel();
            this.rbPVAdministracion = new System.Windows.Forms.RibbonPanel();
            this.rbTFacturas = new System.Windows.Forms.RibbonTab();
            this.rbPFacturas = new System.Windows.Forms.RibbonPanel();
            this.rbPFAdministracion = new System.Windows.Forms.RibbonPanel();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.rbBMostrarClientes = new System.Windows.Forms.RibbonButton();
            this.rbBAgregarCliente = new System.Windows.Forms.RibbonButton();
            this.rbBModificarCliente = new System.Windows.Forms.RibbonButton();
            this.rbBEliminarCliente = new System.Windows.Forms.RibbonButton();
            this.rbBMostrarEmpleados = new System.Windows.Forms.RibbonButton();
            this.rbBAgregarEmpleados = new System.Windows.Forms.RibbonButton();
            this.rbBModificarEmpleado = new System.Windows.Forms.RibbonButton();
            this.rbBEliminarEmpleado = new System.Windows.Forms.RibbonButton();
            this.rbBMostrarCarros = new System.Windows.Forms.RibbonButton();
            this.rbBAgregarCarro = new System.Windows.Forms.RibbonButton();
            this.rbBModificarCarro = new System.Windows.Forms.RibbonButton();
            this.rbBEliminarAuto = new System.Windows.Forms.RibbonButton();
            this.rbBMostrarFacturas = new System.Windows.Forms.RibbonButton();
            this.rbBAgregarFactura = new System.Windows.Forms.RibbonButton();
            this.rbBModificarFactura = new System.Windows.Forms.RibbonButton();
            this.rbBEliminarFactura = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
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
            // rbTVehiculos
            // 
            this.rbTVehiculos.Panels.Add(this.rbPVehiculo);
            this.rbTVehiculos.Panels.Add(this.rbPVAdministracion);
            this.rbTVehiculos.Tag = null;
            this.rbTVehiculos.Text = "Vehiculos";
            this.rbTVehiculos.ToolTip = null;
            this.rbTVehiculos.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.rbTVehiculos.ToolTipImage = null;
            this.rbTVehiculos.ToolTipTitle = null;
            this.rbTVehiculos.Value = null;
            // 
            // rbPVehiculo
            // 
            this.rbPVehiculo.Items.Add(this.rbBMostrarCarros);
            this.rbPVehiculo.Tag = null;
            this.rbPVehiculo.Text = "Vehiculos";
            // 
            // rbPVAdministracion
            // 
            this.rbPVAdministracion.Items.Add(this.rbBAgregarCarro);
            this.rbPVAdministracion.Items.Add(this.rbBModificarCarro);
            this.rbPVAdministracion.Items.Add(this.rbBEliminarAuto);
            this.rbPVAdministracion.Tag = null;
            this.rbPVAdministracion.Text = "Administracion";
            // 
            // rbTFacturas
            // 
            this.rbTFacturas.Panels.Add(this.rbPFacturas);
            this.rbTFacturas.Panels.Add(this.rbPFAdministracion);
            this.rbTFacturas.Tag = null;
            this.rbTFacturas.Text = "Facturas";
            this.rbTFacturas.ToolTip = null;
            this.rbTFacturas.ToolTipIcon = System.Windows.Forms.ToolTipIcon.None;
            this.rbTFacturas.ToolTipImage = null;
            this.rbTFacturas.ToolTipTitle = null;
            this.rbTFacturas.Value = null;
            // 
            // rbPFacturas
            // 
            this.rbPFacturas.Items.Add(this.rbBMostrarFacturas);
            this.rbPFacturas.Tag = null;
            this.rbPFacturas.Text = "Facturas";
            // 
            // rbPFAdministracion
            // 
            this.rbPFAdministracion.Items.Add(this.rbBAgregarFactura);
            this.rbPFAdministracion.Items.Add(this.rbBModificarFactura);
            this.rbPFAdministracion.Items.Add(this.rbBEliminarFactura);
            this.rbPFAdministracion.Tag = null;
            this.rbPFAdministracion.Text = "Administracion";
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
            this.ribbon1.OrbImage = global::TalleresDuran.Properties.Resources.TalleresDuran;
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
            this.ribbon1.Tabs.Add(this.rbTVehiculos);
            this.ribbon1.Tabs.Add(this.rbTFacturas);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.TabSpacing = 6;
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ActiveTabChanged += new System.EventHandler(this.ribbon1_ActiveTabChanged);
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
            this.rbBMostrarEmpleados.Click += new System.EventHandler(this.rbBMostrarEmpleados_Click);
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
            this.rbBAgregarEmpleados.Click += new System.EventHandler(this.rbBAgregarEmpleados_Click);
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
            // rbBMostrarCarros
            // 
            this.rbBMostrarCarros.AltKey = null;
            this.rbBMostrarCarros.CheckedGroup = null;
            this.rbBMostrarCarros.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBMostrarCarros.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBMostrarCarros.Image = global::TalleresDuran.Properties.Resources.show_car;
            this.rbBMostrarCarros.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBMostrarCarros.SmallImage")));
            this.rbBMostrarCarros.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBMostrarCarros.Tag = null;
            this.rbBMostrarCarros.Text = "Mostrar";
            this.rbBMostrarCarros.ToolTip = null;
            this.rbBMostrarCarros.ToolTipTitle = null;
            this.rbBMostrarCarros.Value = null;
            this.rbBMostrarCarros.Click += new System.EventHandler(this.rbBMostrarCarros_Click);
            // 
            // rbBAgregarCarro
            // 
            this.rbBAgregarCarro.AltKey = null;
            this.rbBAgregarCarro.CheckedGroup = null;
            this.rbBAgregarCarro.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBAgregarCarro.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBAgregarCarro.Image = global::TalleresDuran.Properties.Resources.add_car;
            this.rbBAgregarCarro.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBAgregarCarro.SmallImage")));
            this.rbBAgregarCarro.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBAgregarCarro.Tag = null;
            this.rbBAgregarCarro.Text = "Agregar";
            this.rbBAgregarCarro.ToolTip = null;
            this.rbBAgregarCarro.ToolTipTitle = null;
            this.rbBAgregarCarro.Value = null;
            this.rbBAgregarCarro.Click += new System.EventHandler(this.rbBAgregarCarro_Click);
            // 
            // rbBModificarCarro
            // 
            this.rbBModificarCarro.AltKey = null;
            this.rbBModificarCarro.CheckedGroup = null;
            this.rbBModificarCarro.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBModificarCarro.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBModificarCarro.Image = global::TalleresDuran.Properties.Resources.edit_car;
            this.rbBModificarCarro.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBModificarCarro.SmallImage")));
            this.rbBModificarCarro.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBModificarCarro.Tag = null;
            this.rbBModificarCarro.Text = "Modificar";
            this.rbBModificarCarro.ToolTip = null;
            this.rbBModificarCarro.ToolTipTitle = null;
            this.rbBModificarCarro.Value = null;
            // 
            // rbBEliminarAuto
            // 
            this.rbBEliminarAuto.AltKey = null;
            this.rbBEliminarAuto.CheckedGroup = null;
            this.rbBEliminarAuto.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBEliminarAuto.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBEliminarAuto.Image = ((System.Drawing.Image)(resources.GetObject("rbBEliminarAuto.Image")));
            this.rbBEliminarAuto.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBEliminarAuto.SmallImage")));
            this.rbBEliminarAuto.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBEliminarAuto.Tag = null;
            this.rbBEliminarAuto.Text = "Eliminar";
            this.rbBEliminarAuto.ToolTip = null;
            this.rbBEliminarAuto.ToolTipTitle = null;
            this.rbBEliminarAuto.Value = null;
            // 
            // rbBMostrarFacturas
            // 
            this.rbBMostrarFacturas.AltKey = null;
            this.rbBMostrarFacturas.CheckedGroup = null;
            this.rbBMostrarFacturas.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBMostrarFacturas.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBMostrarFacturas.Image = global::TalleresDuran.Properties.Resources.show_facturas;
            this.rbBMostrarFacturas.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBMostrarFacturas.SmallImage")));
            this.rbBMostrarFacturas.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBMostrarFacturas.Tag = null;
            this.rbBMostrarFacturas.Text = "Facturas";
            this.rbBMostrarFacturas.ToolTip = null;
            this.rbBMostrarFacturas.ToolTipTitle = null;
            this.rbBMostrarFacturas.Value = null;
            // 
            // rbBAgregarFactura
            // 
            this.rbBAgregarFactura.AltKey = null;
            this.rbBAgregarFactura.CheckedGroup = null;
            this.rbBAgregarFactura.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBAgregarFactura.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBAgregarFactura.Image = global::TalleresDuran.Properties.Resources.add_facturas;
            this.rbBAgregarFactura.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBAgregarFactura.SmallImage")));
            this.rbBAgregarFactura.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBAgregarFactura.Tag = null;
            this.rbBAgregarFactura.Text = "Agregar";
            this.rbBAgregarFactura.ToolTip = null;
            this.rbBAgregarFactura.ToolTipTitle = null;
            this.rbBAgregarFactura.Value = null;
            // 
            // rbBModificarFactura
            // 
            this.rbBModificarFactura.AltKey = null;
            this.rbBModificarFactura.CheckedGroup = null;
            this.rbBModificarFactura.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBModificarFactura.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBModificarFactura.Image = global::TalleresDuran.Properties.Resources.edit_facturas;
            this.rbBModificarFactura.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBModificarFactura.SmallImage")));
            this.rbBModificarFactura.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBModificarFactura.Tag = null;
            this.rbBModificarFactura.Text = "Modificar";
            this.rbBModificarFactura.ToolTip = null;
            this.rbBModificarFactura.ToolTipTitle = null;
            this.rbBModificarFactura.Value = null;
            // 
            // rbBEliminarFactura
            // 
            this.rbBEliminarFactura.AltKey = null;
            this.rbBEliminarFactura.CheckedGroup = null;
            this.rbBEliminarFactura.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Down;
            this.rbBEliminarFactura.DropDownArrowSize = new System.Drawing.Size(5, 3);
            this.rbBEliminarFactura.Image = global::TalleresDuran.Properties.Resources.del_facturas;
            this.rbBEliminarFactura.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbBEliminarFactura.SmallImage")));
            this.rbBEliminarFactura.Style = System.Windows.Forms.RibbonButtonStyle.Normal;
            this.rbBEliminarFactura.Tag = null;
            this.rbBEliminarFactura.Text = "Eliminar";
            this.rbBEliminarFactura.ToolTip = null;
            this.rbBEliminarFactura.ToolTipTitle = null;
            this.rbBEliminarFactura.Value = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 514);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Talleres Duran";
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
        private System.Windows.Forms.RibbonTab rbTVehiculos;
        private System.Windows.Forms.RibbonPanel rbPVehiculo;
        private System.Windows.Forms.RibbonButton rbBMostrarCarros;
        private System.Windows.Forms.RibbonPanel rbPVAdministracion;
        private System.Windows.Forms.RibbonButton rbBAgregarCarro;
        private System.Windows.Forms.RibbonButton rbBModificarCarro;
        private System.Windows.Forms.RibbonButton rbBEliminarAuto;
        private System.Windows.Forms.RibbonTab rbTFacturas;
        private System.Windows.Forms.RibbonPanel rbPFacturas;
        private System.Windows.Forms.RibbonPanel rbPFAdministracion;
        private System.Windows.Forms.RibbonButton rbBAgregarFactura;
        private System.Windows.Forms.RibbonButton rbBModificarFactura;
        private System.Windows.Forms.RibbonButton rbBEliminarFactura;
        private System.Windows.Forms.RibbonButton rbBMostrarFacturas;
    }
}

