namespace gymsy.UserControls
{
    partial class AddPlanUserControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            DGPlan = new DataGridView();
            id_plan = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            delete = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            TBPrecio = new CustomControls.RJControls.RJTextBox();
            LModoEditOrAdd = new Label();
            BAgregarPlan = new ClassCustom.RJButton();
            BEditarPlan = new ClassCustom.RJButton();
            label16 = new Label();
            BEliminarPlan = new ClassCustom.RJButton();
            label18 = new Label();
            LDescripcionRequerido = new Label();
            LPrecioRequerido = new Label();
            TBDescripcion = new CustomControls.RJControls.RJTextBox();
            nav = new Panel();
            panel3 = new Panel();
            BVerPlanes = new ClassCustom.RJButton();
            label1 = new Label();
            BVerPlanesEliminados = new ClassCustom.RJButton();
            BCancelarBusqueda = new ClassCustom.RJButton();
            LModoBusqueda = new Label();
            TBBusqueda = new CustomControls.RJControls.RJTextBox();
            BBuscar = new ClassCustom.RJButton();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGPlan).BeginInit();
            panel2.SuspendLayout();
            nav.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(nav);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(DGPlan);
            panel4.Location = new Point(0, 130);
            panel4.Name = "panel4";
            panel4.Size = new Size(759, 400);
            panel4.TabIndex = 80;
            // 
            // DGPlan
            // 
            DGPlan.AllowUserToAddRows = false;
            DGPlan.AllowUserToDeleteRows = false;
            DGPlan.AllowUserToResizeColumns = false;
            DGPlan.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(69, 34, 99);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 237, 243);
            DGPlan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGPlan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGPlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGPlan.BackgroundColor = Color.FromArgb(16, 8, 23);
            DGPlan.BorderStyle = BorderStyle.None;
            DGPlan.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGPlan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGPlan.Columns.AddRange(new DataGridViewColumn[] { id_plan, precio, descripcion, delete });
            DGPlan.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGPlan.Location = new Point(0, 0);
            DGPlan.MultiSelect = false;
            DGPlan.Name = "DGPlan";
            DGPlan.ReadOnly = true;
            DGPlan.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGPlan.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            DGPlan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGPlan.RowTemplate.Height = 25;
            DGPlan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGPlan.ShowCellErrors = false;
            DGPlan.Size = new Size(759, 400);
            DGPlan.TabIndex = 5;
            DGPlan.VisibleChanged += DGPlan_VisibleChanged;
            // 
            // id_plan
            // 
            id_plan.HeaderText = "Identificador";
            id_plan.Name = "id_plan";
            id_plan.ReadOnly = true;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            // 
            // delete
            // 
            delete.HeaderText = "Eliminado";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Visible = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(TBPrecio);
            panel2.Controls.Add(LModoEditOrAdd);
            panel2.Controls.Add(BAgregarPlan);
            panel2.Controls.Add(BEditarPlan);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(BEliminarPlan);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(LDescripcionRequerido);
            panel2.Controls.Add(LPrecioRequerido);
            panel2.Controls.Add(TBDescripcion);
            panel2.Location = new Point(765, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(238, 400);
            panel2.TabIndex = 79;
            // 
            // TBPrecio
            // 
            TBPrecio.BackColor = Color.FromArgb(69, 34, 99);
            TBPrecio.BorderColor = Color.Transparent;
            TBPrecio.BorderFocusColor = Color.HotPink;
            TBPrecio.BorderRadius = 15;
            TBPrecio.BorderSize = 2;
            TBPrecio.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBPrecio.ForeColor = Color.FromArgb(230, 237, 243);
            TBPrecio.Location = new Point(18, 70);
            TBPrecio.Margin = new Padding(4);
            TBPrecio.Multiline = false;
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Padding = new Padding(10, 7, 10, 7);
            TBPrecio.PasswordChar = false;
            TBPrecio.PlaceholderColor = Color.DarkGray;
            TBPrecio.PlaceholderText = "Ingrese un nombre...";
            TBPrecio.ReadOnly = false;
            TBPrecio.Size = new Size(204, 31);
            TBPrecio.TabIndex = 73;
            TBPrecio.UnderlinedStyle = false;
            TBPrecio.KeyPress += TBPrecio_KeyPress;
            // 
            // LModoEditOrAdd
            // 
            LModoEditOrAdd.AutoSize = true;
            LModoEditOrAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LModoEditOrAdd.ForeColor = Color.FromArgb(230, 237, 243);
            LModoEditOrAdd.Location = new Point(52, 10);
            LModoEditOrAdd.Name = "LModoEditOrAdd";
            LModoEditOrAdd.Size = new Size(137, 25);
            LModoEditOrAdd.TabIndex = 78;
            LModoEditOrAdd.Text = "Modo Agregar";
            // 
            // BAgregarPlan
            // 
            BAgregarPlan.BackColor = Color.FromArgb(41, 147, 45);
            BAgregarPlan.BackgroundColor = Color.FromArgb(41, 147, 45);
            BAgregarPlan.BorderColor = Color.PaleVioletRed;
            BAgregarPlan.BorderRadius = 15;
            BAgregarPlan.BorderSize = 0;
            BAgregarPlan.FlatAppearance.BorderSize = 0;
            BAgregarPlan.FlatStyle = FlatStyle.Flat;
            BAgregarPlan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BAgregarPlan.ForeColor = Color.White;
            BAgregarPlan.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            BAgregarPlan.IconColor = Color.White;
            BAgregarPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregarPlan.ImageAlign = ContentAlignment.MiddleRight;
            BAgregarPlan.Location = new Point(34, 225);
            BAgregarPlan.Name = "BAgregarPlan";
            BAgregarPlan.Padding = new Padding(10, 0, 0, 0);
            BAgregarPlan.Size = new Size(172, 49);
            BAgregarPlan.TabIndex = 5;
            BAgregarPlan.Text = "Guardar Plan";
            BAgregarPlan.TextAlign = ContentAlignment.MiddleLeft;
            BAgregarPlan.TextColor = Color.White;
            BAgregarPlan.UseVisualStyleBackColor = false;
            BAgregarPlan.Click += BAgregarPlan_Click;
            // 
            // BEditarPlan
            // 
            BEditarPlan.BackColor = Color.FromArgb(0, 0, 192);
            BEditarPlan.BackgroundColor = Color.FromArgb(0, 0, 192);
            BEditarPlan.BorderColor = Color.PaleVioletRed;
            BEditarPlan.BorderRadius = 15;
            BEditarPlan.BorderSize = 0;
            BEditarPlan.FlatAppearance.BorderSize = 0;
            BEditarPlan.FlatStyle = FlatStyle.Flat;
            BEditarPlan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BEditarPlan.ForeColor = Color.White;
            BEditarPlan.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            BEditarPlan.IconColor = Color.White;
            BEditarPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BEditarPlan.IconSize = 45;
            BEditarPlan.ImageAlign = ContentAlignment.MiddleRight;
            BEditarPlan.Location = new Point(34, 280);
            BEditarPlan.Name = "BEditarPlan";
            BEditarPlan.Padding = new Padding(10, 0, 0, 0);
            BEditarPlan.Size = new Size(172, 49);
            BEditarPlan.TabIndex = 77;
            BEditarPlan.Text = "Editar Plan";
            BEditarPlan.TextAlign = ContentAlignment.MiddleLeft;
            BEditarPlan.TextColor = Color.White;
            BEditarPlan.UseVisualStyleBackColor = false;
            BEditarPlan.Click += BEditarPlan_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(230, 237, 243);
            label16.Location = new Point(100, 51);
            label16.Name = "label16";
            label16.Size = new Size(40, 15);
            label16.TabIndex = 70;
            label16.Text = "Precio";
            // 
            // BEliminarPlan
            // 
            BEliminarPlan.BackColor = Color.FromArgb(192, 0, 0);
            BEliminarPlan.BackgroundColor = Color.FromArgb(192, 0, 0);
            BEliminarPlan.BorderColor = Color.PaleVioletRed;
            BEliminarPlan.BorderRadius = 15;
            BEliminarPlan.BorderSize = 0;
            BEliminarPlan.FlatAppearance.BorderSize = 0;
            BEliminarPlan.FlatStyle = FlatStyle.Flat;
            BEliminarPlan.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BEliminarPlan.ForeColor = Color.White;
            BEliminarPlan.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BEliminarPlan.IconColor = Color.White;
            BEliminarPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BEliminarPlan.IconSize = 40;
            BEliminarPlan.ImageAlign = ContentAlignment.MiddleRight;
            BEliminarPlan.Location = new Point(34, 335);
            BEliminarPlan.Name = "BEliminarPlan";
            BEliminarPlan.Padding = new Padding(10, 0, 0, 0);
            BEliminarPlan.Size = new Size(172, 49);
            BEliminarPlan.TabIndex = 76;
            BEliminarPlan.Text = "Eliminar Plan";
            BEliminarPlan.TextAlign = ContentAlignment.MiddleLeft;
            BEliminarPlan.TextColor = Color.White;
            BEliminarPlan.UseVisualStyleBackColor = false;
            BEliminarPlan.Click += BEliminarPlan_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.FromArgb(230, 237, 243);
            label18.Location = new Point(86, 130);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 71;
            label18.Text = "Descripcion";
            // 
            // LDescripcionRequerido
            // 
            LDescripcionRequerido.AutoSize = true;
            LDescripcionRequerido.ForeColor = Color.Red;
            LDescripcionRequerido.Location = new Point(68, 188);
            LDescripcionRequerido.Name = "LDescripcionRequerido";
            LDescripcionRequerido.Size = new Size(105, 15);
            LDescripcionRequerido.TabIndex = 75;
            LDescripcionRequerido.Text = "*Error en el campo";
            LDescripcionRequerido.Visible = false;
            // 
            // LPrecioRequerido
            // 
            LPrecioRequerido.AutoSize = true;
            LPrecioRequerido.ForeColor = Color.Red;
            LPrecioRequerido.Location = new Point(68, 105);
            LPrecioRequerido.Name = "LPrecioRequerido";
            LPrecioRequerido.Size = new Size(105, 15);
            LPrecioRequerido.TabIndex = 72;
            LPrecioRequerido.Text = "*Error en el campo";
            LPrecioRequerido.Visible = false;
            // 
            // TBDescripcion
            // 
            TBDescripcion.BackColor = Color.FromArgb(69, 34, 99);
            TBDescripcion.BorderColor = Color.Transparent;
            TBDescripcion.BorderFocusColor = Color.HotPink;
            TBDescripcion.BorderRadius = 15;
            TBDescripcion.BorderSize = 2;
            TBDescripcion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBDescripcion.ForeColor = Color.FromArgb(230, 237, 243);
            TBDescripcion.Location = new Point(18, 153);
            TBDescripcion.Margin = new Padding(4);
            TBDescripcion.Multiline = false;
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Padding = new Padding(10, 7, 10, 7);
            TBDescripcion.PasswordChar = false;
            TBDescripcion.PlaceholderColor = Color.DarkGray;
            TBDescripcion.PlaceholderText = "Ingrese un nombre...";
            TBDescripcion.ReadOnly = false;
            TBDescripcion.Size = new Size(204, 31);
            TBDescripcion.TabIndex = 74;
            TBDescripcion.UnderlinedStyle = false;
            // 
            // nav
            // 
            nav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nav.BackColor = Color.FromArgb(16, 8, 23);
            nav.Controls.Add(panel3);
            nav.Controls.Add(BVerPlanes);
            nav.Controls.Add(label1);
            nav.Controls.Add(BVerPlanesEliminados);
            nav.Controls.Add(BCancelarBusqueda);
            nav.Controls.Add(LModoBusqueda);
            nav.Controls.Add(TBBusqueda);
            nav.Controls.Add(BBuscar);
            nav.ForeColor = Color.FromArgb(16, 8, 23);
            nav.Location = new Point(0, 0);
            nav.Name = "nav";
            nav.Size = new Size(1000, 124);
            nav.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 397);
            panel3.TabIndex = 80;
            // 
            // BVerPlanes
            // 
            BVerPlanes.BackColor = Color.FromArgb(41, 147, 45);
            BVerPlanes.BackgroundColor = Color.FromArgb(41, 147, 45);
            BVerPlanes.BorderColor = Color.PaleVioletRed;
            BVerPlanes.BorderRadius = 15;
            BVerPlanes.BorderSize = 0;
            BVerPlanes.FlatAppearance.BorderSize = 0;
            BVerPlanes.FlatStyle = FlatStyle.Flat;
            BVerPlanes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BVerPlanes.ForeColor = Color.White;
            BVerPlanes.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            BVerPlanes.IconColor = Color.White;
            BVerPlanes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BVerPlanes.IconSize = 55;
            BVerPlanes.ImageAlign = ContentAlignment.MiddleRight;
            BVerPlanes.Location = new Point(648, 40);
            BVerPlanes.Name = "BVerPlanes";
            BVerPlanes.Padding = new Padding(10, 0, 0, 0);
            BVerPlanes.Size = new Size(166, 60);
            BVerPlanes.TabIndex = 82;
            BVerPlanes.Text = "Ver planes";
            BVerPlanes.TextAlign = ContentAlignment.MiddleLeft;
            BVerPlanes.TextColor = Color.White;
            BVerPlanes.UseVisualStyleBackColor = false;
            BVerPlanes.Click += BVerPlanes_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(230, 237, 243);
            label1.Location = new Point(753, 12);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 81;
            label1.Text = "Listar planes";
            // 
            // BVerPlanesEliminados
            // 
            BVerPlanesEliminados.BackColor = Color.FromArgb(192, 0, 0);
            BVerPlanesEliminados.BackgroundColor = Color.FromArgb(192, 0, 0);
            BVerPlanesEliminados.BorderColor = Color.PaleVioletRed;
            BVerPlanesEliminados.BorderRadius = 15;
            BVerPlanesEliminados.BorderSize = 0;
            BVerPlanesEliminados.FlatAppearance.BorderSize = 0;
            BVerPlanesEliminados.FlatStyle = FlatStyle.Flat;
            BVerPlanesEliminados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BVerPlanesEliminados.ForeColor = Color.White;
            BVerPlanesEliminados.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            BVerPlanesEliminados.IconColor = Color.White;
            BVerPlanesEliminados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BVerPlanesEliminados.IconSize = 40;
            BVerPlanesEliminados.ImageAlign = ContentAlignment.MiddleRight;
            BVerPlanesEliminados.Location = new Point(820, 40);
            BVerPlanesEliminados.Name = "BVerPlanesEliminados";
            BVerPlanesEliminados.Padding = new Padding(10, 0, 0, 0);
            BVerPlanesEliminados.Size = new Size(154, 60);
            BVerPlanesEliminados.TabIndex = 80;
            BVerPlanesEliminados.Text = "Ver planes eliminados";
            BVerPlanesEliminados.TextAlign = ContentAlignment.MiddleLeft;
            BVerPlanesEliminados.TextColor = Color.White;
            BVerPlanesEliminados.UseVisualStyleBackColor = false;
            BVerPlanesEliminados.Click += BVerPlanesEliminados_Click;
            // 
            // BCancelarBusqueda
            // 
            BCancelarBusqueda.BackColor = Color.FromArgb(192, 0, 0);
            BCancelarBusqueda.BackgroundColor = Color.FromArgb(192, 0, 0);
            BCancelarBusqueda.BorderColor = Color.PaleVioletRed;
            BCancelarBusqueda.BorderRadius = 15;
            BCancelarBusqueda.BorderSize = 0;
            BCancelarBusqueda.FlatAppearance.BorderSize = 0;
            BCancelarBusqueda.FlatStyle = FlatStyle.Flat;
            BCancelarBusqueda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BCancelarBusqueda.ForeColor = Color.White;
            BCancelarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BCancelarBusqueda.IconColor = Color.White;
            BCancelarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BCancelarBusqueda.IconSize = 40;
            BCancelarBusqueda.ImageAlign = ContentAlignment.MiddleRight;
            BCancelarBusqueda.Location = new Point(484, 40);
            BCancelarBusqueda.Name = "BCancelarBusqueda";
            BCancelarBusqueda.Padding = new Padding(10, 0, 0, 0);
            BCancelarBusqueda.Size = new Size(143, 50);
            BCancelarBusqueda.TabIndex = 79;
            BCancelarBusqueda.Text = "Cancelar Busqueda";
            BCancelarBusqueda.TextAlign = ContentAlignment.MiddleLeft;
            BCancelarBusqueda.TextColor = Color.White;
            BCancelarBusqueda.UseVisualStyleBackColor = false;
            BCancelarBusqueda.Visible = false;
            BCancelarBusqueda.Click += BCancelarBusqueda_Click;
            // 
            // LModoBusqueda
            // 
            LModoBusqueda.AutoSize = true;
            LModoBusqueda.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LModoBusqueda.ForeColor = Color.FromArgb(230, 237, 243);
            LModoBusqueda.Location = new Point(105, 16);
            LModoBusqueda.Name = "LModoBusqueda";
            LModoBusqueda.Size = new Size(151, 25);
            LModoBusqueda.TabIndex = 79;
            LModoBusqueda.Text = "Modo Busqueda";
            LModoBusqueda.Visible = false;
            // 
            // TBBusqueda
            // 
            TBBusqueda.BackColor = Color.FromArgb(69, 34, 99);
            TBBusqueda.BorderColor = Color.Transparent;
            TBBusqueda.BorderFocusColor = Color.HotPink;
            TBBusqueda.BorderRadius = 15;
            TBBusqueda.BorderSize = 2;
            TBBusqueda.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBBusqueda.ForeColor = Color.FromArgb(230, 237, 243);
            TBBusqueda.Location = new Point(26, 49);
            TBBusqueda.Margin = new Padding(4);
            TBBusqueda.Multiline = false;
            TBBusqueda.Name = "TBBusqueda";
            TBBusqueda.Padding = new Padding(10, 7, 10, 7);
            TBBusqueda.PasswordChar = false;
            TBBusqueda.PlaceholderColor = Color.DarkGray;
            TBBusqueda.PlaceholderText = "Ingrese una busqueda...";
            TBBusqueda.ReadOnly = false;
            TBBusqueda.Size = new Size(385, 31);
            TBBusqueda.TabIndex = 69;
            TBBusqueda.UnderlinedStyle = false;
            // 
            // BBuscar
            // 
            BBuscar.BackColor = Color.DarkOrange;
            BBuscar.BackgroundColor = Color.DarkOrange;
            BBuscar.BorderColor = Color.PaleVioletRed;
            BBuscar.BorderRadius = 25;
            BBuscar.BorderSize = 0;
            BBuscar.FlatAppearance.BorderSize = 0;
            BBuscar.FlatStyle = FlatStyle.Flat;
            BBuscar.ForeColor = Color.White;
            BBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BBuscar.IconColor = Color.White;
            BBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscar.IconSize = 30;
            BBuscar.Location = new Point(428, 40);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(50, 50);
            BBuscar.TabIndex = 6;
            BBuscar.TextColor = Color.White;
            BBuscar.UseVisualStyleBackColor = false;
            BBuscar.Click += BBuscar_Click;
            // 
            // AddPlanUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "AddPlanUserControl";
            Size = new Size(1000, 530);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGPlan).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            nav.ResumeLayout(false);
            nav.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel nav;
        private DataGridView DGPlan;
        private ClassCustom.RJButton BAgregarPlan;
        private ClassCustom.RJButton BBuscar;
        private CustomControls.RJControls.RJTextBox TBBusqueda;
        private Label LDescripcionRequerido;
        private CustomControls.RJControls.RJTextBox TBDescripcion;
        private CustomControls.RJControls.RJTextBox TBPrecio;
        private Label LPrecioRequerido;
        private Label label18;
        private Label label16;
        private ClassCustom.RJButton BEliminarPlan;
        private ClassCustom.RJButton BEditarPlan;
        private Label LModoEditOrAdd;
        private ClassCustom.RJButton BCancelarBusqueda;
        private Label LModoBusqueda;
        private Panel panel2;
        private ClassCustom.RJButton BVerPlanes;
        private Label label1;
        private ClassCustom.RJButton BVerPlanesEliminados;
        private Panel panel3;
        private Panel panel4;
        private DataGridViewTextBoxColumn id_plan;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn delete;
    }
}
