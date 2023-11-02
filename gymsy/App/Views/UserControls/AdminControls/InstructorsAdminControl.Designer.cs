namespace gymsy.UserControls.AdminControls
{
    partial class InstructorsAdminControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorsAdminControl));
            DGInstructors = new DataGridView();
            avatar = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Clientes = new DataGridViewTextBoxColumn();
            last_expiration = new DataGridViewTextBoxColumn();
            id_instructor = new DataGridViewTextBoxColumn();
            delete = new DataGridViewTextBoxColumn();
            label3 = new Label();
            BVerClients = new ClassCustom.RJButton();
            label2 = new Label();
            label1 = new Label();
            BVerClientDelete = new ClassCustom.RJButton();
            BCancelarBusqueda = new ClassCustom.RJButton();
            LModoBusqueda = new Label();
            BBuscar = new ClassCustom.RJButton();
            TBBusqueda = new CustomControls.RJControls.RJTextBox();
            BEditarCliente = new ClassCustom.RJButton();
            BEliminarCliente = new ClassCustom.RJButton();
            BAgregarCliente = new ClassCustom.RJButton();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DGInstructors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DGInstructors
            // 
            DGInstructors.AllowUserToAddRows = false;
            DGInstructors.AllowUserToDeleteRows = false;
            DGInstructors.AllowUserToResizeColumns = false;
            DGInstructors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(16, 8, 23);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 237, 243);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(69, 34, 99);
            DGInstructors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGInstructors.BackgroundColor = Color.FromArgb(16, 8, 23);
            DGInstructors.BorderStyle = BorderStyle.None;
            DGInstructors.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGInstructors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGInstructors.Columns.AddRange(new DataGridViewColumn[] { avatar, name, Telefono, Clientes, last_expiration, id_instructor, delete });
            DGInstructors.Dock = DockStyle.Bottom;
            DGInstructors.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGInstructors.Location = new Point(0, 129);
            DGInstructors.MultiSelect = false;
            DGInstructors.Name = "DGInstructors";
            DGInstructors.ReadOnly = true;
            DGInstructors.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGInstructors.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            DGInstructors.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DGInstructors.RowTemplate.Height = 25;
            DGInstructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGInstructors.ShowCellErrors = false;
            DGInstructors.Size = new Size(1000, 401);
            DGInstructors.TabIndex = 2;
            // 
            // avatar
            // 
            avatar.HeaderText = "Avatar";
            avatar.Name = "avatar";
            avatar.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Nombre";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Clientes
            // 
            Clientes.HeaderText = "Cantidad Clientes";
            Clientes.Name = "Clientes";
            Clientes.ReadOnly = true;
            // 
            // last_expiration
            // 
            last_expiration.HeaderText = "Ingreso como Instructor";
            last_expiration.Name = "last_expiration";
            last_expiration.ReadOnly = true;
            // 
            // id_instructor
            // 
            id_instructor.HeaderText = "id_instructor";
            id_instructor.Name = "id_instructor";
            id_instructor.ReadOnly = true;
            id_instructor.Visible = false;
            // 
            // delete
            // 
            delete.HeaderText = "delete";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(138, 8);
            label3.Name = "label3";
            label3.Size = new Size(174, 41);
            label3.TabIndex = 10;
            label3.Text = "Instructores";
            // 
            // BVerClients
            // 
            BVerClients.BackColor = Color.FromArgb(41, 147, 45);
            BVerClients.BackgroundColor = Color.FromArgb(41, 147, 45);
            BVerClients.BorderColor = Color.PaleVioletRed;
            BVerClients.BorderRadius = 15;
            BVerClients.BorderSize = 0;
            BVerClients.FlatAppearance.BorderSize = 0;
            BVerClients.FlatStyle = FlatStyle.Flat;
            BVerClients.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BVerClients.ForeColor = Color.White;
            BVerClients.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            BVerClients.IconColor = Color.FromArgb(230, 237, 243);
            BVerClients.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BVerClients.IconSize = 45;
            BVerClients.ImageAlign = ContentAlignment.MiddleRight;
            BVerClients.Location = new Point(849, 33);
            BVerClients.Name = "BVerClients";
            BVerClients.Padding = new Padding(10, 0, 0, 0);
            BVerClients.Size = new Size(130, 40);
            BVerClients.TabIndex = 100;
            BVerClients.Text = "Activos";
            BVerClients.TextAlign = ContentAlignment.MiddleLeft;
            BVerClients.TextColor = Color.White;
            BVerClients.UseVisualStyleBackColor = false;
            BVerClients.Click += BVerClients_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(230, 237, 243);
            label2.Location = new Point(832, 12);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 99;
            label2.Text = "Listar Instructores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(230, 237, 243);
            label1.Location = new Point(586, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 98;
            label1.Text = "Controles de Instructor";
            // 
            // BVerClientDelete
            // 
            BVerClientDelete.BackColor = Color.FromArgb(192, 0, 0);
            BVerClientDelete.BackgroundColor = Color.FromArgb(192, 0, 0);
            BVerClientDelete.BorderColor = Color.PaleVioletRed;
            BVerClientDelete.BorderRadius = 15;
            BVerClientDelete.BorderSize = 0;
            BVerClientDelete.FlatAppearance.BorderSize = 0;
            BVerClientDelete.FlatStyle = FlatStyle.Flat;
            BVerClientDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BVerClientDelete.ForeColor = Color.White;
            BVerClientDelete.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            BVerClientDelete.IconColor = Color.White;
            BVerClientDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BVerClientDelete.IconSize = 45;
            BVerClientDelete.ImageAlign = ContentAlignment.MiddleRight;
            BVerClientDelete.Location = new Point(849, 79);
            BVerClientDelete.Name = "BVerClientDelete";
            BVerClientDelete.Padding = new Padding(8, 0, 0, 0);
            BVerClientDelete.Size = new Size(131, 40);
            BVerClientDelete.TabIndex = 96;
            BVerClientDelete.Text = "Inactivos";
            BVerClientDelete.TextAlign = ContentAlignment.MiddleLeft;
            BVerClientDelete.TextColor = Color.White;
            BVerClientDelete.UseVisualStyleBackColor = false;
            BVerClientDelete.Click += BVerClientDelete_Click;
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
            BCancelarBusqueda.Location = new Point(306, 77);
            BCancelarBusqueda.Name = "BCancelarBusqueda";
            BCancelarBusqueda.Padding = new Padding(10, 0, 0, 0);
            BCancelarBusqueda.Size = new Size(204, 39);
            BCancelarBusqueda.TabIndex = 94;
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
            LModoBusqueda.Location = new Point(327, 8);
            LModoBusqueda.Name = "LModoBusqueda";
            LModoBusqueda.Size = new Size(151, 25);
            LModoBusqueda.TabIndex = 95;
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
            BBuscar.Location = new Point(512, 31);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(50, 50);
            BBuscar.TabIndex = 93;
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
            TBBusqueda.Location = new Point(306, 38);
            TBBusqueda.Margin = new Padding(4);
            TBBusqueda.Multiline = false;
            TBBusqueda.Name = "TBBusqueda";
            TBBusqueda.Padding = new Padding(10, 7, 10, 7);
            TBBusqueda.PasswordChar = false;
            TBBusqueda.PlaceholderColor = Color.DarkGray;
            TBBusqueda.PlaceholderText = "Ingrese un nombre...";
            TBBusqueda.ReadOnly = false;
            TBBusqueda.Size = new Size(199, 31);
            TBBusqueda.TabIndex = 92;
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
            BEditarCliente.Location = new Point(565, 76);
            BEditarCliente.Name = "BEditarCliente";
            BEditarCliente.Padding = new Padding(10, 0, 0, 0);
            BEditarCliente.Size = new Size(131, 40);
            BEditarCliente.TabIndex = 91;
            BEditarCliente.Text = "Editar";
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
            BEliminarCliente.Location = new Point(705, 34);
            BEliminarCliente.Name = "BEliminarCliente";
            BEliminarCliente.Padding = new Padding(10, 0, 0, 0);
            BEliminarCliente.Size = new Size(122, 40);
            BEliminarCliente.TabIndex = 90;
            BEliminarCliente.Text = "Eliminar";
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
            BAgregarCliente.Location = new Point(565, 37);
            BAgregarCliente.Name = "BAgregarCliente";
            BAgregarCliente.Padding = new Padding(10, 0, 0, 0);
            BAgregarCliente.Size = new Size(131, 40);
            BAgregarCliente.TabIndex = 89;
            BAgregarCliente.Text = "Agregar";
            BAgregarCliente.TextAlign = ContentAlignment.MiddleLeft;
            BAgregarCliente.TextColor = Color.White;
            BAgregarCliente.UseVisualStyleBackColor = false;
            BAgregarCliente.Click += BAgregarCliente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 101;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(BVerClientDelete);
            panel1.Controls.Add(LModoBusqueda);
            panel1.Controls.Add(BVerClients);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BEditarCliente);
            panel1.Controls.Add(BAgregarCliente);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 122);
            panel1.TabIndex = 102;
            // 
            // InstructorsAdminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 8, 23);
            Controls.Add(BCancelarBusqueda);
            Controls.Add(BBuscar);
            Controls.Add(TBBusqueda);
            Controls.Add(BEliminarCliente);
            Controls.Add(DGInstructors);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "InstructorsAdminControl";
            Size = new Size(1000, 530);
            ((System.ComponentModel.ISupportInitialize)DGInstructors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DGInstructors;
        private Label label3;
        private ClassCustom.RJButton BVerClients;
        private Label label2;
        private Label label1;
        private ClassCustom.RJButton BVerClientDelete;
        private ClassCustom.RJButton BCancelarBusqueda;
        private Label LModoBusqueda;
        private ClassCustom.RJButton BBuscar;
        private CustomControls.RJControls.RJTextBox TBBusqueda;
        private ClassCustom.RJButton BEditarCliente;
        private ClassCustom.RJButton BEliminarCliente;
        private ClassCustom.RJButton BAgregarCliente;
        private DataGridViewImageColumn avatar;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Clientes;
        private DataGridViewTextBoxColumn last_expiration;
        private DataGridViewTextBoxColumn id_instructor;
        private DataGridViewTextBoxColumn delete;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
