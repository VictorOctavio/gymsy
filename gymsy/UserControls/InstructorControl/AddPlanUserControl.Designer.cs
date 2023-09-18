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
            LModoEditOrAdd = new Label();
            BEditarPlan = new ClassCustom.RJButton();
            BEliminarPlan = new ClassCustom.RJButton();
            LDescripcionRequerido = new Label();
            TBDescripcion = new CustomControls.RJControls.RJTextBox();
            TBPrecio = new CustomControls.RJControls.RJTextBox();
            LPrecioRequerido = new Label();
            label18 = new Label();
            label16 = new Label();
            DGPlan = new DataGridView();
            id_plan = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            nav = new Panel();
            TBBusqueda = new CustomControls.RJControls.RJTextBox();
            BBuscar = new ClassCustom.RJButton();
            BAgregarPlan = new ClassCustom.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGPlan).BeginInit();
            nav.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(LModoEditOrAdd);
            panel1.Controls.Add(BEditarPlan);
            panel1.Controls.Add(BEliminarPlan);
            panel1.Controls.Add(LDescripcionRequerido);
            panel1.Controls.Add(TBDescripcion);
            panel1.Controls.Add(TBPrecio);
            panel1.Controls.Add(LPrecioRequerido);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(DGPlan);
            panel1.Controls.Add(nav);
            panel1.Controls.Add(BAgregarPlan);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 1;
            // 
            // LModoEditOrAdd
            // 
            LModoEditOrAdd.AutoSize = true;
            LModoEditOrAdd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LModoEditOrAdd.ForeColor = Color.FromArgb(230, 237, 243);
            LModoEditOrAdd.Location = new Point(736, 140);
            LModoEditOrAdd.Name = "LModoEditOrAdd";
            LModoEditOrAdd.Size = new Size(137, 25);
            LModoEditOrAdd.TabIndex = 78;
            LModoEditOrAdd.Text = "Modo Agregar";
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
            BEditarPlan.Location = new Point(736, 410);
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
            BEliminarPlan.Location = new Point(736, 465);
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
            // LDescripcionRequerido
            // 
            LDescripcionRequerido.AutoSize = true;
            LDescripcionRequerido.ForeColor = Color.Red;
            LDescripcionRequerido.Location = new Point(736, 318);
            LDescripcionRequerido.Name = "LDescripcionRequerido";
            LDescripcionRequerido.Size = new Size(105, 15);
            LDescripcionRequerido.TabIndex = 75;
            LDescripcionRequerido.Text = "*Error en el campo";
            LDescripcionRequerido.Visible = false;
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
            TBDescripcion.Location = new Point(736, 283);
            TBDescripcion.Margin = new Padding(4);
            TBDescripcion.Multiline = false;
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Padding = new Padding(10, 7, 10, 7);
            TBDescripcion.PasswordChar = false;
            TBDescripcion.PlaceholderColor = Color.DarkGray;
            TBDescripcion.PlaceholderText = "Ingrese un nombre...";
            TBDescripcion.Size = new Size(204, 31);
            TBDescripcion.TabIndex = 74;
            TBDescripcion.Texts = "";
            TBDescripcion.UnderlinedStyle = false;
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
            TBPrecio.Location = new Point(736, 200);
            TBPrecio.Margin = new Padding(4);
            TBPrecio.Multiline = false;
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Padding = new Padding(10, 7, 10, 7);
            TBPrecio.PasswordChar = false;
            TBPrecio.PlaceholderColor = Color.DarkGray;
            TBPrecio.PlaceholderText = "Ingrese un nombre...";
            TBPrecio.Size = new Size(204, 31);
            TBPrecio.TabIndex = 73;
            TBPrecio.Texts = "";
            TBPrecio.UnderlinedStyle = false;
            TBPrecio.KeyPress += TBPrecio_KeyPress;
            // 
            // LPrecioRequerido
            // 
            LPrecioRequerido.AutoSize = true;
            LPrecioRequerido.ForeColor = Color.Red;
            LPrecioRequerido.Location = new Point(736, 235);
            LPrecioRequerido.Name = "LPrecioRequerido";
            LPrecioRequerido.Size = new Size(105, 15);
            LPrecioRequerido.TabIndex = 72;
            LPrecioRequerido.Text = "*Error en el campo";
            LPrecioRequerido.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.FromArgb(230, 237, 243);
            label18.Location = new Point(736, 260);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 71;
            label18.Text = "Descripcion";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(230, 237, 243);
            label16.Location = new Point(736, 181);
            label16.Name = "label16";
            label16.Size = new Size(40, 15);
            label16.TabIndex = 70;
            label16.Text = "Precio";
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
            DGPlan.Columns.AddRange(new DataGridViewColumn[] { id_plan, precio, descripcion });
            DGPlan.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGPlan.Location = new Point(0, 130);
            DGPlan.MultiSelect = false;
            DGPlan.Name = "DGPlan";
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
            DGPlan.Size = new Size(699, 400);
            DGPlan.TabIndex = 5;
            DGPlan.VisibleChanged += DGPlan_VisibleChanged;
            // 
            // id_plan
            // 
            id_plan.HeaderText = "Identificador";
            id_plan.Name = "id_plan";
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            // 
            // nav
            // 
            nav.BackColor = Color.FromArgb(16, 8, 23);
            nav.Controls.Add(TBBusqueda);
            nav.Controls.Add(BBuscar);
            nav.Dock = DockStyle.Top;
            nav.ForeColor = Color.FromArgb(16, 8, 23);
            nav.Location = new Point(0, 0);
            nav.Name = "nav";
            nav.Size = new Size(1000, 124);
            nav.TabIndex = 6;
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
            TBBusqueda.Location = new Point(26, 71);
            TBBusqueda.Margin = new Padding(4);
            TBBusqueda.Multiline = false;
            TBBusqueda.Name = "TBBusqueda";
            TBBusqueda.Padding = new Padding(10, 7, 10, 7);
            TBBusqueda.PasswordChar = false;
            TBBusqueda.PlaceholderColor = Color.DarkGray;
            TBBusqueda.PlaceholderText = "Ingrese una busqueda...";
            TBBusqueda.Size = new Size(582, 31);
            TBBusqueda.TabIndex = 69;
            TBBusqueda.Texts = "";
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
            BBuscar.Location = new Point(615, 61);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(50, 50);
            BBuscar.TabIndex = 6;
            BBuscar.TextColor = Color.White;
            BBuscar.UseVisualStyleBackColor = false;
            // 
            // BAgregarPlan
            // 
            BAgregarPlan.BackColor = Color.FromArgb(0, 192, 0);
            BAgregarPlan.BackgroundColor = Color.FromArgb(0, 192, 0);
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
            BAgregarPlan.Location = new Point(736, 355);
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
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGPlan).EndInit();
            nav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel nav;
        private DataGridView DGPlan;
        private DataGridViewTextBoxColumn id_plan;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn descripcion;
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
    }
}
