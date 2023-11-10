namespace gymsy.App.Views.UserControls.receptionist
{
    partial class addPay
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
            panel1 = new Panel();
            panel4 = new Panel();
            TBBusqueda = new CustomControls.RJControls.RJTextBox();
            BBuscar = new ClassCustom.RJButton();
            LModoBusqueda = new Label();
            BCancelarBusqueda = new ClassCustom.RJButton();
            label3 = new Label();
            DGUsers = new DataGridView();
            Avatar = new DataGridViewImageColumn();
            FullNameColumn = new DataGridViewTextBoxColumn();
            plan = new DataGridViewTextBoxColumn();
            last_expiration = new DataGridViewTextBoxColumn();
            IdClient = new DataGridViewTextBoxColumn();
            delete = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Lid_client = new Label();
            BEditarCliente = new ClassCustom.RJButton();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label8 = new Label();
            LInstructorFullName = new Label();
            LPlan = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            LClientFullName = new Label();
            PimagenPerson = new ClassCustom.RJCircularPictureBox();
            label1 = new Label();
            label2 = new Label();
            TbAmount = new Label();
            BAgregarCliente = new ClassCustom.RJButton();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PimagenPerson).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(230, 237, 243);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(TBBusqueda);
            panel4.Controls.Add(BBuscar);
            panel4.Controls.Add(LModoBusqueda);
            panel4.Controls.Add(BCancelarBusqueda);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(DGUsers);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(441, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(557, 530);
            panel4.TabIndex = 109;
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
            TBBusqueda.Location = new Point(234, 63);
            TBBusqueda.Margin = new Padding(4);
            TBBusqueda.Multiline = false;
            TBBusqueda.Name = "TBBusqueda";
            TBBusqueda.Padding = new Padding(10, 7, 10, 7);
            TBBusqueda.PasswordChar = false;
            TBBusqueda.PlaceholderColor = Color.DarkGray;
            TBBusqueda.PlaceholderText = "Ingrese un nombre...";
            TBBusqueda.ReadOnly = false;
            TBBusqueda.Size = new Size(203, 31);
            TBBusqueda.TabIndex = 95;
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
            BBuscar.Location = new Point(444, 48);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(50, 50);
            BBuscar.TabIndex = 96;
            BBuscar.TextColor = Color.White;
            BBuscar.UseVisualStyleBackColor = false;
            BBuscar.Click += BBuscar_Click;
            // 
            // LModoBusqueda
            // 
            LModoBusqueda.AutoSize = true;
            LModoBusqueda.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LModoBusqueda.ForeColor = Color.FromArgb(230, 237, 243);
            LModoBusqueda.Location = new Point(260, 22);
            LModoBusqueda.Name = "LModoBusqueda";
            LModoBusqueda.Size = new Size(133, 25);
            LModoBusqueda.TabIndex = 98;
            LModoBusqueda.Text = "Buscar Cliente";
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
            BCancelarBusqueda.Location = new Point(234, 101);
            BCancelarBusqueda.Name = "BCancelarBusqueda";
            BCancelarBusqueda.Padding = new Padding(10, 0, 0, 0);
            BCancelarBusqueda.Size = new Size(204, 39);
            BCancelarBusqueda.TabIndex = 97;
            BCancelarBusqueda.Text = "Cancelar Busqueda";
            BCancelarBusqueda.TextAlign = ContentAlignment.MiddleLeft;
            BCancelarBusqueda.TextColor = Color.White;
            BCancelarBusqueda.UseVisualStyleBackColor = false;
            BCancelarBusqueda.Visible = false;
            BCancelarBusqueda.Click += BCancelarBusqueda_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(104, -2);
            label3.Name = "label3";
            label3.Size = new Size(123, 41);
            label3.TabIndex = 105;
            label3.Text = "Clientes";
            // 
            // DGUsers
            // 
            DGUsers.AllowUserToAddRows = false;
            DGUsers.AllowUserToDeleteRows = false;
            DGUsers.AllowUserToOrderColumns = true;
            DGUsers.AllowUserToResizeColumns = false;
            DGUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(16, 8, 23);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 237, 243);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(69, 34, 99);
            DGUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DGUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGUsers.BackgroundColor = Color.FromArgb(16, 8, 23);
            DGUsers.BorderStyle = BorderStyle.None;
            DGUsers.CausesValidation = false;
            DGUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DGUsers.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DGUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DGUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGUsers.Columns.AddRange(new DataGridViewColumn[] { Avatar, FullNameColumn, plan, last_expiration, IdClient, delete });
            DGUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            DGUsers.Location = new Point(-2, 162);
            DGUsers.MultiSelect = false;
            DGUsers.Name = "DGUsers";
            DGUsers.ReadOnly = true;
            DGUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DGUsers.RowHeadersVisible = false;
            DGUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
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
            DGUsers.ShowCellErrors = false;
            DGUsers.Size = new Size(559, 366);
            DGUsers.TabIndex = 91;
            // 
            // Avatar
            // 
            Avatar.HeaderText = "Avatar";
            Avatar.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Avatar.Name = "Avatar";
            Avatar.ReadOnly = true;
            // 
            // FullNameColumn
            // 
            FullNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            FullNameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            FullNameColumn.HeaderText = "Nombre";
            FullNameColumn.Name = "FullNameColumn";
            FullNameColumn.ReadOnly = true;
            FullNameColumn.Width = 212;
            // 
            // plan
            // 
            plan.HeaderText = "Plan";
            plan.Name = "plan";
            plan.ReadOnly = true;
            // 
            // last_expiration
            // 
            last_expiration.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            last_expiration.HeaderText = "Vencimiento";
            last_expiration.Name = "last_expiration";
            last_expiration.ReadOnly = true;
            last_expiration.Width = 170;
            // 
            // IdClient
            // 
            IdClient.HeaderText = "id_cliente";
            IdClient.Name = "IdClient";
            IdClient.ReadOnly = true;
            IdClient.Visible = false;
            // 
            // delete
            // 
            delete.HeaderText = "Eliminado";
            delete.Name = "delete";
            delete.ReadOnly = true;
            delete.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.instr;
            pictureBox1.Location = new Point(18, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 104;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(Lid_client);
            panel2.Controls.Add(BEditarCliente);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(BAgregarCliente);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 524);
            panel2.TabIndex = 106;
            // 
            // Lid_client
            // 
            Lid_client.AutoSize = true;
            Lid_client.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Lid_client.Location = new Point(89, 66);
            Lid_client.Name = "Lid_client";
            Lid_client.Size = new Size(0, 21);
            Lid_client.TabIndex = 108;
            Lid_client.Visible = false;
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
            BEditarCliente.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            BEditarCliente.IconColor = Color.White;
            BEditarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BEditarCliente.IconSize = 40;
            BEditarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            BEditarCliente.Location = new Point(268, 44);
            BEditarCliente.Name = "BEditarCliente";
            BEditarCliente.Padding = new Padding(10, 0, 0, 0);
            BEditarCliente.Size = new Size(162, 40);
            BEditarCliente.TabIndex = 110;
            BEditarCliente.Text = "Traer Cliente";
            BEditarCliente.TextAlign = ContentAlignment.MiddleRight;
            BEditarCliente.TextColor = Color.White;
            BEditarCliente.UseVisualStyleBackColor = false;
            BEditarCliente.Click += BEditarCliente_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(122, 0);
            label4.Name = "label4";
            label4.Size = new Size(180, 41);
            label4.TabIndex = 109;
            label4.Text = "Nuevo Pago";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ogax344i;
            pictureBox2.Location = new Point(3, 273);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 248);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 106;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(LInstructorFullName);
            panel3.Controls.Add(LPlan);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(LClientFullName);
            panel3.Controls.Add(PimagenPerson);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(TbAmount);
            panel3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(13, 89);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(408, 179);
            panel3.TabIndex = 106;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(86, 102);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 61);
            label8.TabIndex = 107;
            label8.Text = "$";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LInstructorFullName
            // 
            LInstructorFullName.AutoSize = true;
            LInstructorFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LInstructorFullName.Location = new Point(222, 62);
            LInstructorFullName.Name = "LInstructorFullName";
            LInstructorFullName.Size = new Size(74, 21);
            LInstructorFullName.TabIndex = 106;
            LInstructorFullName.Text = "nombre...";
            // 
            // LPlan
            // 
            LPlan.AutoSize = true;
            LPlan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LPlan.Location = new Point(178, 38);
            LPlan.Name = "LPlan";
            LPlan.Size = new Size(98, 21);
            LPlan.TabIndex = 105;
            LPlan.Text = "descripcion...";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(230, 237, 243);
            label7.Location = new Point(118, 59);
            label7.Name = "label7";
            label7.Size = new Size(102, 25);
            label7.TabIndex = 104;
            label7.Text = "Instructor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(230, 237, 243);
            label5.Location = new Point(118, 34);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 103;
            label5.Text = "Plan:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(328, 132);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(61, 24);
            label6.TabIndex = 102;
            label6.Text = "x Mes";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LClientFullName
            // 
            LClientFullName.AutoSize = true;
            LClientFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LClientFullName.Location = new Point(178, 12);
            LClientFullName.Name = "LClientFullName";
            LClientFullName.Size = new Size(74, 21);
            LClientFullName.TabIndex = 101;
            LClientFullName.Text = "nombre...";
            // 
            // PimagenPerson
            // 
            PimagenPerson.BackgroundImage = Properties.Resources.gorilla_avatar;
            PimagenPerson.BackgroundImageLayout = ImageLayout.Zoom;
            PimagenPerson.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            PimagenPerson.BorderColor = Color.RoyalBlue;
            PimagenPerson.BorderColor2 = Color.HotPink;
            PimagenPerson.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            PimagenPerson.BorderSize = 2;
            PimagenPerson.ErrorImage = Properties.Resources.gorilla_avatar;
            PimagenPerson.GradientAngle = 50F;
            PimagenPerson.Location = new Point(15, 12);
            PimagenPerson.Name = "PimagenPerson";
            PimagenPerson.Size = new Size(97, 97);
            PimagenPerson.SizeMode = PictureBoxSizeMode.Zoom;
            PimagenPerson.TabIndex = 100;
            PimagenPerson.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(230, 237, 243);
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 99;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(2, 128);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 1;
            label2.Text = "ahora";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TbAmount
            // 
            TbAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TbAmount.AutoSize = true;
            TbAmount.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            TbAmount.ForeColor = Color.White;
            TbAmount.Location = new Point(123, 102);
            TbAmount.Margin = new Padding(2, 0, 2, 0);
            TbAmount.Name = "TbAmount";
            TbAmount.Size = new Size(201, 61);
            TbAmount.TabIndex = 0;
            TbAmount.Text = "128984";
            TbAmount.TextAlign = ContentAlignment.MiddleLeft;
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
            BAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            BAgregarCliente.IconColor = Color.FromArgb(230, 237, 243);
            BAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAgregarCliente.IconSize = 45;
            BAgregarCliente.ImageAlign = ContentAlignment.MiddleRight;
            BAgregarCliente.Location = new Point(251, 273);
            BAgregarCliente.Name = "BAgregarCliente";
            BAgregarCliente.Padding = new Padding(10, 0, 0, 0);
            BAgregarCliente.Size = new Size(170, 50);
            BAgregarCliente.TabIndex = 107;
            BAgregarCliente.Text = "Agregar Pago";
            BAgregarCliente.TextAlign = ContentAlignment.MiddleLeft;
            BAgregarCliente.TextColor = Color.White;
            BAgregarCliente.UseVisualStyleBackColor = false;
            BAgregarCliente.Click += BAgregarCliente_Click;
            // 
            // addPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "addPay";
            Size = new Size(1000, 530);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PimagenPerson).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private ClassCustom.RJButton BCancelarBusqueda;
        private Label LModoBusqueda;
        private ClassCustom.RJButton BBuscar;
        private CustomControls.RJControls.RJTextBox TBBusqueda;
        private PictureBox pictureBox1;
        private DataGridView DGUsers;
        private ClassCustom.RJButton BAgregarCliente;
        private DataGridViewImageColumn Avatar;
        private DataGridViewTextBoxColumn FullNameColumn;
        private DataGridViewTextBoxColumn plan;
        private DataGridViewTextBoxColumn last_expiration;
        private DataGridViewTextBoxColumn IdClient;
        private DataGridViewTextBoxColumn delete;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label TbAmount;
        private PictureBox pictureBox2;
        private Label label4;
        private ClassCustom.RJButton BEditarCliente;
        private Label label1;
        private Label LClientFullName;
        private ClassCustom.RJCircularPictureBox PimagenPerson;
        private Label label6;
        private Label label7;
        private Label label5;
        private Label LInstructorFullName;
        private Label LPlan;
        private Label label8;
        private Label Lid_client;
    }
}
