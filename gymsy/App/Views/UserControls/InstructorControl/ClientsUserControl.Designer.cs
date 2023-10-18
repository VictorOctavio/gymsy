namespace gymsy.UserControls
{
    partial class ClientsUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DGUsers = new DataGridView();
            IdClient = new DataGridViewTextBoxColumn();
            Avatar = new DataGridViewImageColumn();
            created = new DataGridViewTextBoxColumn();
            FullNameColumn = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            last_expiration = new DataGridViewTextBoxColumn();
            plan = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            rjButton2 = new ClassCustom.RJButton();
            rjButton1 = new ClassCustom.RJButton();
            BCancelarBusqueda = new ClassCustom.RJButton();
            LModoBusqueda = new Label();
            BBuscar = new ClassCustom.RJButton();
            TBBusqueda = new CustomControls.RJControls.RJTextBox();
            BEditarCliente = new ClassCustom.RJButton();
            BEliminarCliente = new ClassCustom.RJButton();
            BAgregarCliente = new ClassCustom.RJButton();
            ((System.ComponentModel.ISupportInitialize)DGUsers).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // DGUsers
            // 
            DGUsers.AllowUserToAddRows = false;
            DGUsers.AllowUserToDeleteRows = false;
            DGUsers.AllowUserToResizeColumns = false;
            DGUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(16, 8, 23);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 237, 243);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(69, 34, 99);
            DGUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGUsers.BackgroundColor = Color.FromArgb(16, 8, 35);
            DGUsers.BorderStyle = BorderStyle.None;
            DGUsers.CausesValidation = false;
            DGUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGUsers.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGUsers.Columns.AddRange(new DataGridViewColumn[] { IdClient, Avatar, created, FullNameColumn, Telefono, last_expiration, plan });
            DGUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGUsers.GridColor = SystemColors.ActiveCaptionText;
            DGUsers.Location = new Point(6, 154);
            DGUsers.Name = "DGUsers";
            DGUsers.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            DGUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DGUsers.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 35);
            DGUsers.RowTemplate.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DGUsers.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            DGUsers.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            DGUsers.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            DGUsers.RowTemplate.Height = 35;
            DGUsers.ScrollBars = ScrollBars.None;
            DGUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGUsers.Size = new Size(994, 373);
            DGUsers.TabIndex = 1;
            DGUsers.CellContentClick += DGUsers_CellContentClick;
            DGUsers.CellMouseEnter += DataGridViewCellEventArgs;
            // 
            // IdClient
            // 
            IdClient.HeaderText = "IdClientColumn";
            IdClient.Name = "IdClient";
            IdClient.Visible = false;
            // 
            // Avatar
            // 
            Avatar.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Avatar.HeaderText = "#";
            Avatar.Image = Properties.Resources.gorilla_avatar;
            Avatar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Avatar.MinimumWidth = 100;
            Avatar.Name = "Avatar";
            Avatar.ReadOnly = true;
            // 
            // created
            // 
            created.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            created.HeaderText = "Ingreso";
            created.Name = "created";
            created.Width = 130;
            // 
            // FullNameColumn
            // 
            FullNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point);
            FullNameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            FullNameColumn.HeaderText = "Nombre";
            FullNameColumn.Name = "FullNameColumn";
            FullNameColumn.Width = 212;
            // 
            // Telefono
            // 
            Telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.Width = 170;
            // 
            // last_expiration
            // 
            last_expiration.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            last_expiration.HeaderText = "Vencimiento";
            last_expiration.Name = "last_expiration";
            last_expiration.Width = 170;
            // 
            // plan
            // 
            plan.HeaderText = "Plan";
            plan.Name = "plan";
            plan.Width = 230;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(DGUsers);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 542);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(16, 8, 23);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(rjButton2);
            panel2.Controls.Add(rjButton1);
            panel2.Controls.Add(BCancelarBusqueda);
            panel2.Controls.Add(LModoBusqueda);
            panel2.Controls.Add(BBuscar);
            panel2.Controls.Add(TBBusqueda);
            panel2.Controls.Add(BEditarCliente);
            panel2.Controls.Add(BEliminarCliente);
            panel2.Controls.Add(BAgregarCliente);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 163);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(230, 237, 243);
            label2.Location = new Point(810, 6);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 87;
            label2.Text = "Listar clientes";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(230, 237, 243);
            label1.Location = new Point(472, 6);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 86;
            label1.Text = "Controles de Cliente";
            label1.Visible = false;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(41, 147, 45);
            rjButton2.BackgroundColor = Color.FromArgb(41, 147, 45);
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.White;
            rjButton2.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            rjButton2.IconColor = Color.FromArgb(230, 237, 243);
            rjButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton2.IconSize = 45;
            rjButton2.ImageAlign = ContentAlignment.MiddleRight;
            rjButton2.Location = new Point(744, 38);
            rjButton2.Name = "rjButton2";
            rjButton2.Padding = new Padding(10, 0, 0, 0);
            rjButton2.Size = new Size(228, 40);
            rjButton2.TabIndex = 85;
            rjButton2.Text = "Añadir Progreso";
            rjButton2.TextAlign = ContentAlignment.MiddleLeft;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(192, 0, 0);
            rjButton1.BackgroundColor = Color.FromArgb(192, 0, 0);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            rjButton1.IconColor = Color.White;
            rjButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton1.IconSize = 45;
            rjButton1.ImageAlign = ContentAlignment.MiddleRight;
            rjButton1.Location = new Point(744, 84);
            rjButton1.Name = "rjButton1";
            rjButton1.Padding = new Padding(8, 0, 0, 0);
            rjButton1.Size = new Size(228, 40);
            rjButton1.TabIndex = 84;
            rjButton1.Text = "Ver Clientes Eliminados";
            rjButton1.TextAlign = ContentAlignment.MiddleLeft;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // BCancelarBusqueda
            // 
            BCancelarBusqueda.BackColor = Color.FromArgb(192, 0, 0);
            BCancelarBusqueda.BackgroundColor = Color.FromArgb(192, 0, 0);
            BCancelarBusqueda.BorderColor = Color.PaleVioletRed;
            BCancelarBusqueda.BorderRadius = 12;
            BCancelarBusqueda.BorderSize = 0;
            BCancelarBusqueda.FlatAppearance.BorderSize = 0;
            BCancelarBusqueda.FlatStyle = FlatStyle.Flat;
            BCancelarBusqueda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BCancelarBusqueda.ForeColor = Color.White;
            BCancelarBusqueda.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BCancelarBusqueda.IconColor = Color.White;
            BCancelarBusqueda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BCancelarBusqueda.IconSize = 35;
            BCancelarBusqueda.ImageAlign = ContentAlignment.MiddleRight;
            BCancelarBusqueda.Location = new Point(62, 85);
            BCancelarBusqueda.Name = "BCancelarBusqueda";
            BCancelarBusqueda.Padding = new Padding(10, 0, 0, 0);
            BCancelarBusqueda.Size = new Size(204, 39);
            BCancelarBusqueda.TabIndex = 82;
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
            LModoBusqueda.Location = new Point(79, 6);
            LModoBusqueda.Name = "LModoBusqueda";
            LModoBusqueda.Size = new Size(151, 25);
            LModoBusqueda.TabIndex = 83;
            LModoBusqueda.Text = "Modo Busqueda";
            LModoBusqueda.Visible = false;
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
            BBuscar.Location = new Point(289, 41);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(50, 50);
            BBuscar.TabIndex = 81;
            BBuscar.TextColor = Color.White;
            BBuscar.UseVisualStyleBackColor = false;
            BBuscar.Click += BBuscar_Click;
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
            TBBusqueda.Location = new Point(37, 47);
            TBBusqueda.Margin = new Padding(4);
            TBBusqueda.Multiline = false;
            TBBusqueda.Name = "TBBusqueda";
            TBBusqueda.Padding = new Padding(10, 7, 10, 7);
            TBBusqueda.PasswordChar = false;
            TBBusqueda.PlaceholderColor = Color.DarkGray;
            TBBusqueda.PlaceholderText = "Ingrese un nombre...";
            TBBusqueda.ReadOnly = false;
            TBBusqueda.Size = new Size(245, 31);
            TBBusqueda.TabIndex = 80;
            TBBusqueda.UnderlinedStyle = false;
            // 
            // BEditarCliente
            // 
            BEditarCliente.BackColor = Color.FromArgb(0, 0, 192);
            BEditarCliente.BackgroundColor = Color.FromArgb(0, 0, 192);
            BEditarCliente.BorderColor = Color.PaleVioletRed;
            BEditarCliente.BorderRadius = 15;
            BEditarCliente.BorderSize = 0;
            BEditarCliente.FlatAppearance.BorderSize = 0;
            BEditarCliente.FlatStyle = FlatStyle.Flat;
            BEditarCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BEditarCliente.ForeColor = Color.White;
            BEditarCliente.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            BEditarCliente.IconColor = Color.White;
            BEditarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BEditarCliente.IconSize = 40;
            BEditarCliente.ImageAlign = ContentAlignment.MiddleRight;
            BEditarCliente.Location = new Point(366, 84);
            BEditarCliente.Name = "BEditarCliente";
            BEditarCliente.Padding = new Padding(10, 0, 0, 0);
            BEditarCliente.Size = new Size(188, 40);
            BEditarCliente.TabIndex = 79;
            BEditarCliente.Text = "Editar Cliente";
            BEditarCliente.TextAlign = ContentAlignment.MiddleLeft;
            BEditarCliente.TextColor = Color.White;
            BEditarCliente.UseVisualStyleBackColor = false;
            BEditarCliente.Click += BEditarCliente_Click;
            // 
            // BEliminarCliente
            // 
            BEliminarCliente.BackColor = Color.FromArgb(192, 0, 0);
            BEliminarCliente.BackgroundColor = Color.FromArgb(192, 0, 0);
            BEliminarCliente.BorderColor = Color.PaleVioletRed;
            BEliminarCliente.BorderRadius = 15;
            BEliminarCliente.BorderSize = 0;
            BEliminarCliente.FlatAppearance.BorderSize = 0;
            BEliminarCliente.FlatStyle = FlatStyle.Flat;
            BEliminarCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BEliminarCliente.ForeColor = Color.White;
            BEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BEliminarCliente.IconColor = Color.White;
            BEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BEliminarCliente.IconSize = 35;
            BEliminarCliente.ImageAlign = ContentAlignment.MiddleRight;
            BEliminarCliente.Location = new Point(560, 38);
            BEliminarCliente.Name = "BEliminarCliente";
            BEliminarCliente.Padding = new Padding(10, 0, 0, 0);
            BEliminarCliente.Size = new Size(178, 40);
            BEliminarCliente.TabIndex = 78;
            BEliminarCliente.Text = "Eliminar Cliente";
            BEliminarCliente.TextAlign = ContentAlignment.MiddleLeft;
            BEliminarCliente.TextColor = Color.White;
            BEliminarCliente.UseVisualStyleBackColor = false;
            BEliminarCliente.Click += BEliminarCliente_Click;
            // 
            // BAgregarCliente
            // 
            BAgregarCliente.BackColor = Color.FromArgb(41, 147, 45);
            BAgregarCliente.BackgroundColor = Color.FromArgb(41, 147, 45);
            BAgregarCliente.BorderColor = Color.PaleVioletRed;
            BAgregarCliente.BorderRadius = 15;
            BAgregarCliente.BorderSize = 0;
            BAgregarCliente.FlatAppearance.BorderSize = 0;
            BAgregarCliente.FlatStyle = FlatStyle.Flat;
            BAgregarCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BAgregarCliente.ForeColor = Color.White;
            BAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            BAgregarCliente.IconColor = Color.FromArgb(230, 237, 243);
            BAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregarCliente.IconSize = 45;
            BAgregarCliente.ImageAlign = ContentAlignment.MiddleRight;
            BAgregarCliente.Location = new Point(366, 38);
            BAgregarCliente.Name = "BAgregarCliente";
            BAgregarCliente.Padding = new Padding(10, 0, 0, 0);
            BAgregarCliente.Size = new Size(188, 40);
            BAgregarCliente.TabIndex = 65;
            BAgregarCliente.Text = "Agregar Cliente";
            BAgregarCliente.TextAlign = ContentAlignment.MiddleLeft;
            BAgregarCliente.TextColor = Color.White;
            BAgregarCliente.UseVisualStyleBackColor = false;
            BAgregarCliente.Click += BAgregarCliente_Click;
            // 
            // ClientsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "ClientsUserControl";
            Size = new Size(1000, 530);
            ((System.ComponentModel.ISupportInitialize)DGUsers).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView DGUsers;
        private Panel panel1;
        private Panel panel2;
        private ClassCustom.RJButton BAgregarCliente;
        private ClassCustom.RJButton BEditarCliente;
        private ClassCustom.RJButton BEliminarCliente;
        private CustomControls.RJControls.RJTextBox TBBusqueda;
        private ClassCustom.RJButton BBuscar;
        private ClassCustom.RJButton BCancelarBusqueda;
        private Label LModoBusqueda;
        private Label label2;
        private Label label1;
        private ClassCustom.RJButton rjButton2;
        private ClassCustom.RJButton rjButton1;
        private DataGridViewTextBoxColumn IdClient;
        private DataGridViewImageColumn Avatar;
        private DataGridViewTextBoxColumn created;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn last_expiration;
        private DataGridViewTextBoxColumn plan;
    }
}
