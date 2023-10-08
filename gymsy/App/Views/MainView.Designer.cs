namespace gymsy
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            sidebar = new Panel();
            panelAddAdmin = new Panel();
            btnAddAdmin = new Button();
            button3 = new Button();
            btnAddInstructor = new Button();
            tableLayoutAdmin = new TableLayoutPanel();
            btnNavPaysAdmin = new Button();
            btnNavInstructorAdmin = new Button();
            btnNavDashAdmin = new Button();
            tableLayout = new TableLayoutPanel();
            btnNavPayments = new Button();
            btnNavClients = new Button();
            btnNavDashboard = new Button();
            tableLayoutClient = new TableLayoutPanel();
            btnNavPaysClient = new Button();
            btnNavProgress = new Button();
            btnNavAboutme = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panelNavUser = new Panel();
            btnNavSignout = new Button();
            LabelNavRol = new Label();
            btnNavSettings = new Button();
            BtnUserAvatar = new Button();
            panelBtnAdd = new Panel();
            btnNavAddPlan = new Button();
            btnNavAddClient = new Button();
            btnAdd = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            btnAddTimer = new System.Windows.Forms.Timer(components);
            mainWrapper = new Panel();
            navbar = new Panel();
            panelNavRight = new Panel();
            btnWalletNav = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnNotifications = new Button();
            panel5 = new Panel();
            panelNotifications = new Panel();
            label6 = new Label();
            timerNavbarNotifications = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            timerAddAdmin = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            panelAddAdmin.SuspendLayout();
            tableLayoutAdmin.SuspendLayout();
            tableLayout.SuspendLayout();
            tableLayoutClient.SuspendLayout();
            panel3.SuspendLayout();
            panelNavUser.SuspendLayout();
            panelBtnAdd.SuspendLayout();
            mainWrapper.SuspendLayout();
            navbar.SuspendLayout();
            panelNavRight.SuspendLayout();
            panel2.SuspendLayout();
            panelNotifications.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.people_item;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 20);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(200, 80);
            button1.TabIndex = 1;
            button1.Text = "     Clients";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(9, 0, 20);
            sidebar.Controls.Add(panelAddAdmin);
            sidebar.Controls.Add(tableLayoutAdmin);
            sidebar.Controls.Add(tableLayout);
            sidebar.Controls.Add(tableLayoutClient);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panelNavUser);
            sidebar.Controls.Add(panelBtnAdd);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(0);
            sidebar.MaximumSize = new Size(260, 0);
            sidebar.MinimumSize = new Size(70, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(260, 749);
            sidebar.TabIndex = 0;
            // 
            // panelAddAdmin
            // 
            panelAddAdmin.BackColor = Color.Transparent;
            panelAddAdmin.Controls.Add(btnAddAdmin);
            panelAddAdmin.Controls.Add(button3);
            panelAddAdmin.Controls.Add(btnAddInstructor);
            panelAddAdmin.Location = new Point(0, 331);
            panelAddAdmin.MaximumSize = new Size(260, 154);
            panelAddAdmin.MinimumSize = new Size(260, 60);
            panelAddAdmin.Name = "panelAddAdmin";
            panelAddAdmin.Size = new Size(260, 60);
            panelAddAdmin.TabIndex = 5;
            panelAddAdmin.Visible = false;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.Transparent;
            btnAddAdmin.Cursor = Cursors.Hand;
            btnAddAdmin.FlatAppearance.BorderSize = 0;
            btnAddAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnAddAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnAddAdmin.FlatStyle = FlatStyle.Flat;
            btnAddAdmin.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddAdmin.ForeColor = Color.White;
            btnAddAdmin.Image = Properties.Resources.add_item;
            btnAddAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddAdmin.Location = new Point(0, -2);
            btnAddAdmin.Margin = new Padding(0);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Padding = new Padding(18, 0, 0, 0);
            btnAddAdmin.Size = new Size(257, 65);
            btnAddAdmin.TabIndex = 0;
            btnAddAdmin.Text = "    Add";
            btnAddAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAddAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(2, 106);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(258, 39);
            button3.TabIndex = 2;
            button3.Text = "       ...";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            // 
            // btnAddInstructor
            // 
            btnAddInstructor.BackColor = Color.Transparent;
            btnAddInstructor.Cursor = Cursors.Hand;
            btnAddInstructor.FlatAppearance.BorderSize = 0;
            btnAddInstructor.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnAddInstructor.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnAddInstructor.FlatStyle = FlatStyle.Flat;
            btnAddInstructor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddInstructor.ForeColor = Color.White;
            btnAddInstructor.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddInstructor.Location = new Point(2, 65);
            btnAddInstructor.Margin = new Padding(0);
            btnAddInstructor.Name = "btnAddInstructor";
            btnAddInstructor.Padding = new Padding(20, 0, 0, 0);
            btnAddInstructor.Size = new Size(258, 39);
            btnAddInstructor.TabIndex = 1;
            btnAddInstructor.Text = "       Instructor";
            btnAddInstructor.TextAlign = ContentAlignment.MiddleLeft;
            btnAddInstructor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddInstructor.UseVisualStyleBackColor = false;
            btnAddInstructor.Click += btnAddInstructor_Click;
            // 
            // tableLayoutAdmin
            // 
            tableLayoutAdmin.BackColor = Color.Transparent;
            tableLayoutAdmin.ColumnCount = 1;
            tableLayoutAdmin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutAdmin.Controls.Add(btnNavPaysAdmin, 0, 2);
            tableLayoutAdmin.Controls.Add(btnNavInstructorAdmin, 0, 1);
            tableLayoutAdmin.Controls.Add(btnNavDashAdmin, 0, 0);
            tableLayoutAdmin.Location = new Point(0, 131);
            tableLayoutAdmin.Name = "tableLayoutAdmin";
            tableLayoutAdmin.RowCount = 3;
            tableLayoutAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutAdmin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutAdmin.Size = new Size(259, 192);
            tableLayoutAdmin.TabIndex = 3;
            tableLayoutAdmin.Visible = false;
            // 
            // btnNavPaysAdmin
            // 
            btnNavPaysAdmin.BackColor = Color.Transparent;
            btnNavPaysAdmin.Cursor = Cursors.Hand;
            btnNavPaysAdmin.Dock = DockStyle.Fill;
            btnNavPaysAdmin.FlatAppearance.BorderSize = 0;
            btnNavPaysAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavPaysAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavPaysAdmin.FlatStyle = FlatStyle.Flat;
            btnNavPaysAdmin.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavPaysAdmin.ForeColor = Color.White;
            btnNavPaysAdmin.Image = Properties.Resources.payments_item;
            btnNavPaysAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavPaysAdmin.Location = new Point(0, 128);
            btnNavPaysAdmin.Margin = new Padding(0);
            btnNavPaysAdmin.Name = "btnNavPaysAdmin";
            btnNavPaysAdmin.Padding = new Padding(10, 0, 0, 0);
            btnNavPaysAdmin.RightToLeft = RightToLeft.No;
            btnNavPaysAdmin.Size = new Size(259, 64);
            btnNavPaysAdmin.TabIndex = 3;
            btnNavPaysAdmin.Text = "  Payments";
            btnNavPaysAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavPaysAdmin.UseVisualStyleBackColor = false;
            btnNavPaysAdmin.Click += btnNavPaysAdmin_Click;
            // 
            // btnNavInstructorAdmin
            // 
            btnNavInstructorAdmin.BackColor = Color.Transparent;
            btnNavInstructorAdmin.Cursor = Cursors.Hand;
            btnNavInstructorAdmin.Dock = DockStyle.Fill;
            btnNavInstructorAdmin.FlatAppearance.BorderSize = 0;
            btnNavInstructorAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavInstructorAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavInstructorAdmin.FlatStyle = FlatStyle.Flat;
            btnNavInstructorAdmin.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavInstructorAdmin.ForeColor = Color.White;
            btnNavInstructorAdmin.Image = Properties.Resources.people_item;
            btnNavInstructorAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavInstructorAdmin.Location = new Point(0, 64);
            btnNavInstructorAdmin.Margin = new Padding(0);
            btnNavInstructorAdmin.Name = "btnNavInstructorAdmin";
            btnNavInstructorAdmin.Padding = new Padding(20, 0, 0, 0);
            btnNavInstructorAdmin.RightToLeft = RightToLeft.No;
            btnNavInstructorAdmin.Size = new Size(259, 64);
            btnNavInstructorAdmin.TabIndex = 2;
            btnNavInstructorAdmin.Text = "    Instructors";
            btnNavInstructorAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavInstructorAdmin.UseVisualStyleBackColor = false;
            btnNavInstructorAdmin.Click += btnNavInstructorAdmin_Click;
            // 
            // btnNavDashAdmin
            // 
            btnNavDashAdmin.BackColor = Color.Transparent;
            btnNavDashAdmin.Cursor = Cursors.Hand;
            btnNavDashAdmin.Dock = DockStyle.Fill;
            btnNavDashAdmin.FlatAppearance.BorderSize = 0;
            btnNavDashAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavDashAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavDashAdmin.FlatStyle = FlatStyle.Flat;
            btnNavDashAdmin.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavDashAdmin.ForeColor = Color.White;
            btnNavDashAdmin.Image = Properties.Resources.dashboard_item;
            btnNavDashAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavDashAdmin.Location = new Point(0, 0);
            btnNavDashAdmin.Margin = new Padding(0);
            btnNavDashAdmin.Name = "btnNavDashAdmin";
            btnNavDashAdmin.Padding = new Padding(10, 0, 0, 0);
            btnNavDashAdmin.RightToLeft = RightToLeft.No;
            btnNavDashAdmin.Size = new Size(259, 64);
            btnNavDashAdmin.TabIndex = 1;
            btnNavDashAdmin.Text = " Dashboard";
            btnNavDashAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavDashAdmin.UseVisualStyleBackColor = false;
            btnNavDashAdmin.Click += btnNavDashAdmin_Click;
            // 
            // tableLayout
            // 
            tableLayout.Anchor = AnchorStyles.Top;
            tableLayout.BackColor = Color.Transparent;
            tableLayout.ColumnCount = 1;
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayout.Controls.Add(btnNavPayments, 0, 2);
            tableLayout.Controls.Add(btnNavClients, 0, 1);
            tableLayout.Controls.Add(btnNavDashboard, 0, 0);
            tableLayout.Location = new Point(0, 136);
            tableLayout.Name = "tableLayout";
            tableLayout.RowCount = 3;
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayout.Size = new Size(260, 192);
            tableLayout.TabIndex = 1;
            tableLayout.Visible = false;
            // 
            // btnNavPayments
            // 
            btnNavPayments.BackColor = Color.Transparent;
            btnNavPayments.Cursor = Cursors.Hand;
            btnNavPayments.Dock = DockStyle.Fill;
            btnNavPayments.FlatAppearance.BorderSize = 0;
            btnNavPayments.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavPayments.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavPayments.FlatStyle = FlatStyle.Flat;
            btnNavPayments.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavPayments.ForeColor = Color.White;
            btnNavPayments.Image = Properties.Resources.payments_item;
            btnNavPayments.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavPayments.Location = new Point(0, 128);
            btnNavPayments.Margin = new Padding(0);
            btnNavPayments.Name = "btnNavPayments";
            btnNavPayments.Padding = new Padding(10, 0, 0, 0);
            btnNavPayments.RightToLeft = RightToLeft.No;
            btnNavPayments.Size = new Size(260, 64);
            btnNavPayments.TabIndex = 3;
            btnNavPayments.Text = "  Payments";
            btnNavPayments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavPayments.UseVisualStyleBackColor = false;
            btnNavPayments.Click += btnNavPayments_Click;
            // 
            // btnNavClients
            // 
            btnNavClients.BackColor = Color.Transparent;
            btnNavClients.Cursor = Cursors.Hand;
            btnNavClients.Dock = DockStyle.Fill;
            btnNavClients.FlatAppearance.BorderSize = 0;
            btnNavClients.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavClients.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavClients.FlatStyle = FlatStyle.Flat;
            btnNavClients.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavClients.ForeColor = Color.White;
            btnNavClients.Image = Properties.Resources.people_item;
            btnNavClients.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavClients.Location = new Point(0, 64);
            btnNavClients.Margin = new Padding(0);
            btnNavClients.Name = "btnNavClients";
            btnNavClients.Padding = new Padding(20, 0, 0, 0);
            btnNavClients.RightToLeft = RightToLeft.No;
            btnNavClients.Size = new Size(260, 64);
            btnNavClients.TabIndex = 2;
            btnNavClients.Text = "    Clients";
            btnNavClients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavClients.UseVisualStyleBackColor = false;
            btnNavClients.Click += btnNavClients_Click;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.BackColor = Color.Transparent;
            btnNavDashboard.Cursor = Cursors.Hand;
            btnNavDashboard.Dock = DockStyle.Fill;
            btnNavDashboard.FlatAppearance.BorderSize = 0;
            btnNavDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavDashboard.ForeColor = Color.White;
            btnNavDashboard.Image = Properties.Resources.dashboard_item;
            btnNavDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.Location = new Point(0, 0);
            btnNavDashboard.Margin = new Padding(0);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Padding = new Padding(10, 0, 0, 0);
            btnNavDashboard.RightToLeft = RightToLeft.No;
            btnNavDashboard.Size = new Size(260, 64);
            btnNavDashboard.TabIndex = 1;
            btnNavDashboard.Text = "  Dashboard";
            btnNavDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavDashboard.UseVisualStyleBackColor = false;
            btnNavDashboard.Click += btnNavDashboard_Click;
            // 
            // tableLayoutClient
            // 
            tableLayoutClient.BackColor = Color.Transparent;
            tableLayoutClient.ColumnCount = 1;
            tableLayoutClient.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutClient.Controls.Add(btnNavPaysClient, 0, 2);
            tableLayoutClient.Controls.Add(btnNavProgress, 0, 1);
            tableLayoutClient.Controls.Add(btnNavAboutme, 0, 0);
            tableLayoutClient.Location = new Point(0, 132);
            tableLayoutClient.Name = "tableLayoutClient";
            tableLayoutClient.RowCount = 3;
            tableLayoutClient.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutClient.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutClient.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutClient.Size = new Size(257, 192);
            tableLayoutClient.TabIndex = 4;
            tableLayoutClient.Visible = false;
            // 
            // btnNavPaysClient
            // 
            btnNavPaysClient.BackColor = Color.Transparent;
            btnNavPaysClient.Cursor = Cursors.Hand;
            btnNavPaysClient.Dock = DockStyle.Fill;
            btnNavPaysClient.FlatAppearance.BorderSize = 0;
            btnNavPaysClient.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavPaysClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavPaysClient.FlatStyle = FlatStyle.Flat;
            btnNavPaysClient.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavPaysClient.ForeColor = Color.White;
            btnNavPaysClient.Image = Properties.Resources.payments_item;
            btnNavPaysClient.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavPaysClient.Location = new Point(0, 128);
            btnNavPaysClient.Margin = new Padding(0);
            btnNavPaysClient.Name = "btnNavPaysClient";
            btnNavPaysClient.Padding = new Padding(10, 0, 0, 0);
            btnNavPaysClient.RightToLeft = RightToLeft.No;
            btnNavPaysClient.Size = new Size(257, 64);
            btnNavPaysClient.TabIndex = 3;
            btnNavPaysClient.Text = "  Pays";
            btnNavPaysClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavPaysClient.UseVisualStyleBackColor = false;
            btnNavPaysClient.Click += btnNavPaysClient_Click;
            // 
            // btnNavProgress
            // 
            btnNavProgress.BackColor = Color.Transparent;
            btnNavProgress.Cursor = Cursors.Hand;
            btnNavProgress.Dock = DockStyle.Fill;
            btnNavProgress.FlatAppearance.BorderSize = 0;
            btnNavProgress.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavProgress.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavProgress.FlatStyle = FlatStyle.Flat;
            btnNavProgress.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavProgress.ForeColor = Color.White;
            btnNavProgress.Image = Properties.Resources.people_item;
            btnNavProgress.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavProgress.Location = new Point(0, 64);
            btnNavProgress.Margin = new Padding(0);
            btnNavProgress.Name = "btnNavProgress";
            btnNavProgress.Padding = new Padding(20, 0, 0, 0);
            btnNavProgress.RightToLeft = RightToLeft.No;
            btnNavProgress.Size = new Size(257, 64);
            btnNavProgress.TabIndex = 2;
            btnNavProgress.Text = "    Progress";
            btnNavProgress.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavProgress.UseVisualStyleBackColor = false;
            btnNavProgress.Click += btnNavProgress_Click;
            // 
            // btnNavAboutme
            // 
            btnNavAboutme.BackColor = Color.Transparent;
            btnNavAboutme.Cursor = Cursors.Hand;
            btnNavAboutme.Dock = DockStyle.Fill;
            btnNavAboutme.FlatAppearance.BorderSize = 0;
            btnNavAboutme.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavAboutme.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavAboutme.FlatStyle = FlatStyle.Flat;
            btnNavAboutme.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavAboutme.ForeColor = Color.White;
            btnNavAboutme.Image = Properties.Resources.dashboard_item;
            btnNavAboutme.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAboutme.Location = new Point(0, 0);
            btnNavAboutme.Margin = new Padding(0);
            btnNavAboutme.Name = "btnNavAboutme";
            btnNavAboutme.Padding = new Padding(10, 0, 0, 0);
            btnNavAboutme.RightToLeft = RightToLeft.No;
            btnNavAboutme.Size = new Size(257, 64);
            btnNavAboutme.TabIndex = 1;
            btnNavAboutme.Text = " About me";
            btnNavAboutme.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavAboutme.UseVisualStyleBackColor = false;
            btnNavAboutme.Click += btnNavAboutme_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(label1);
            panel3.ForeColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 70);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 14);
            label1.Name = "label1";
            label1.Size = new Size(138, 46);
            label1.TabIndex = 1;
            label1.Text = "GYMSY";
            // 
            // panelNavUser
            // 
            panelNavUser.BackColor = Color.DarkOrange;
            panelNavUser.Controls.Add(btnNavSignout);
            panelNavUser.Controls.Add(LabelNavRol);
            panelNavUser.Controls.Add(btnNavSettings);
            panelNavUser.Controls.Add(BtnUserAvatar);
            panelNavUser.Dock = DockStyle.Bottom;
            panelNavUser.Location = new Point(0, 626);
            panelNavUser.Margin = new Padding(0);
            panelNavUser.Name = "panelNavUser";
            panelNavUser.Size = new Size(260, 123);
            panelNavUser.TabIndex = 2;
            // 
            // btnNavSignout
            // 
            btnNavSignout.Cursor = Cursors.Hand;
            btnNavSignout.FlatAppearance.BorderSize = 0;
            btnNavSignout.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNavSignout.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNavSignout.FlatStyle = FlatStyle.Flat;
            btnNavSignout.ForeColor = SystemColors.ButtonFace;
            btnNavSignout.Image = Properties.Resources.logout_item;
            btnNavSignout.Location = new Point(220, 41);
            btnNavSignout.Margin = new Padding(0);
            btnNavSignout.Name = "btnNavSignout";
            btnNavSignout.Size = new Size(27, 43);
            btnNavSignout.TabIndex = 3;
            btnNavSignout.UseVisualStyleBackColor = true;
            btnNavSignout.Click += btnNavSignout_Click;
            // 
            // LabelNavRol
            // 
            LabelNavRol.AutoSize = true;
            LabelNavRol.BackColor = Color.Transparent;
            LabelNavRol.FlatStyle = FlatStyle.Flat;
            LabelNavRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LabelNavRol.ForeColor = Color.FromArgb(9, 0, 20);
            LabelNavRol.Location = new Point(76, 74);
            LabelNavRol.Name = "LabelNavRol";
            LabelNavRol.Size = new Size(82, 15);
            LabelNavRol.TabIndex = 2;
            LabelNavRol.Text = "INSTRUCTOR";
            // 
            // btnNavSettings
            // 
            btnNavSettings.Cursor = Cursors.Hand;
            btnNavSettings.FlatAppearance.BorderSize = 0;
            btnNavSettings.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNavSettings.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNavSettings.FlatStyle = FlatStyle.Flat;
            btnNavSettings.ForeColor = SystemColors.ButtonFace;
            btnNavSettings.Image = Properties.Resources.setting_item;
            btnNavSettings.Location = new Point(186, 41);
            btnNavSettings.Margin = new Padding(0);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Size = new Size(33, 43);
            btnNavSettings.TabIndex = 1;
            btnNavSettings.UseVisualStyleBackColor = true;
            btnNavSettings.Click += btnNavSettings_Click;
            // 
            // BtnUserAvatar
            // 
            BtnUserAvatar.BackColor = Color.Transparent;
            BtnUserAvatar.FlatAppearance.BorderSize = 0;
            BtnUserAvatar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnUserAvatar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnUserAvatar.FlatStyle = FlatStyle.Flat;
            BtnUserAvatar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUserAvatar.ForeColor = Color.White;
            BtnUserAvatar.Image = Properties.Resources.gorilla_avatar;
            BtnUserAvatar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnUserAvatar.Location = new Point(2, 24);
            BtnUserAvatar.Margin = new Padding(0);
            BtnUserAvatar.Name = "BtnUserAvatar";
            BtnUserAvatar.Size = new Size(162, 75);
            BtnUserAvatar.TabIndex = 0;
            BtnUserAvatar.TabStop = false;
            BtnUserAvatar.Text = "Barco1";
            BtnUserAvatar.TextAlign = ContentAlignment.MiddleLeft;
            BtnUserAvatar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUserAvatar.UseVisualStyleBackColor = false;
            // 
            // panelBtnAdd
            // 
            panelBtnAdd.BackColor = Color.Transparent;
            panelBtnAdd.Controls.Add(btnNavAddPlan);
            panelBtnAdd.Controls.Add(btnNavAddClient);
            panelBtnAdd.Controls.Add(btnAdd);
            panelBtnAdd.Location = new Point(0, 334);
            panelBtnAdd.MaximumSize = new Size(260, 154);
            panelBtnAdd.MinimumSize = new Size(260, 60);
            panelBtnAdd.Name = "panelBtnAdd";
            panelBtnAdd.Size = new Size(260, 60);
            panelBtnAdd.TabIndex = 2;
            panelBtnAdd.Visible = false;
            // 
            // btnNavAddPlan
            // 
            btnNavAddPlan.BackColor = Color.Transparent;
            btnNavAddPlan.Cursor = Cursors.Hand;
            btnNavAddPlan.FlatAppearance.BorderSize = 0;
            btnNavAddPlan.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavAddPlan.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavAddPlan.FlatStyle = FlatStyle.Flat;
            btnNavAddPlan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavAddPlan.ForeColor = Color.White;
            btnNavAddPlan.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAddPlan.Location = new Point(2, 106);
            btnNavAddPlan.Margin = new Padding(0);
            btnNavAddPlan.Name = "btnNavAddPlan";
            btnNavAddPlan.Padding = new Padding(20, 0, 0, 0);
            btnNavAddPlan.Size = new Size(258, 39);
            btnNavAddPlan.TabIndex = 2;
            btnNavAddPlan.Text = "       Plan";
            btnNavAddPlan.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAddPlan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavAddPlan.UseVisualStyleBackColor = false;
            btnNavAddPlan.Click += btnNavAddPlan_Click;
            // 
            // btnNavAddClient
            // 
            btnNavAddClient.BackColor = Color.Transparent;
            btnNavAddClient.Cursor = Cursors.Hand;
            btnNavAddClient.FlatAppearance.BorderSize = 0;
            btnNavAddClient.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnNavAddClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnNavAddClient.FlatStyle = FlatStyle.Flat;
            btnNavAddClient.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNavAddClient.ForeColor = Color.White;
            btnNavAddClient.Image = Properties.Resources.people_item;
            btnNavAddClient.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAddClient.Location = new Point(2, 65);
            btnNavAddClient.Margin = new Padding(0);
            btnNavAddClient.Name = "btnNavAddClient";
            btnNavAddClient.Padding = new Padding(20, 0, 0, 0);
            btnNavAddClient.Size = new Size(258, 39);
            btnNavAddClient.TabIndex = 1;
            btnNavAddClient.Text = "       Client";
            btnNavAddClient.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAddClient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavAddClient.UseVisualStyleBackColor = false;
            btnNavAddClient.Click += btnNavAddClient_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Image = Properties.Resources.add_item;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(0, -2);
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Padding = new Padding(18, 0, 0, 0);
            btnAdd.Size = new Size(260, 65);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "    Add";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += timer1_Tick;
            // 
            // btnAddTimer
            // 
            btnAddTimer.Interval = 5;
            btnAddTimer.Tick += btnAddTimer_Tick;
            // 
            // mainWrapper
            // 
            mainWrapper.BackColor = Color.FromArgb(16, 8, 30);
            mainWrapper.BackgroundImageLayout = ImageLayout.None;
            mainWrapper.Controls.Add(navbar);
            mainWrapper.Dock = DockStyle.Fill;
            mainWrapper.ForeColor = Color.Black;
            mainWrapper.Location = new Point(0, 0);
            mainWrapper.Margin = new Padding(0);
            mainWrapper.Name = "mainWrapper";
            mainWrapper.Padding = new Padding(260, 0, 0, 0);
            mainWrapper.Size = new Size(1358, 749);
            mainWrapper.TabIndex = 0;
            // 
            // navbar
            // 
            navbar.BackColor = Color.Transparent;
            navbar.Controls.Add(panelNavRight);
            navbar.Controls.Add(panel5);
            navbar.Controls.Add(panelNotifications);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(260, 0);
            navbar.Margin = new Padding(0);
            navbar.MaximumSize = new Size(0, 133);
            navbar.MinimumSize = new Size(0, 70);
            navbar.Name = "navbar";
            navbar.Size = new Size(1098, 71);
            navbar.TabIndex = 0;
            // 
            // panelNavRight
            // 
            panelNavRight.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelNavRight.BackColor = Color.DarkCyan;
            panelNavRight.Controls.Add(btnWalletNav);
            panelNavRight.Controls.Add(panel2);
            panelNavRight.Controls.Add(btnNotifications);
            panelNavRight.ForeColor = Color.White;
            panelNavRight.Location = new Point(750, 0);
            panelNavRight.Margin = new Padding(0);
            panelNavRight.Name = "panelNavRight";
            panelNavRight.Size = new Size(348, 71);
            panelNavRight.TabIndex = 0;
            // 
            // btnWalletNav
            // 
            btnWalletNav.BackColor = Color.Transparent;
            btnWalletNav.BackgroundImageLayout = ImageLayout.Stretch;
            btnWalletNav.Cursor = Cursors.Hand;
            btnWalletNav.FlatAppearance.BorderSize = 0;
            btnWalletNav.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnWalletNav.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnWalletNav.FlatStyle = FlatStyle.Flat;
            btnWalletNav.Image = Properties.Resources.wallet__2_;
            btnWalletNav.Location = new Point(292, 12);
            btnWalletNav.Name = "btnWalletNav";
            btnWalletNav.Size = new Size(50, 50);
            btnWalletNav.TabIndex = 4;
            btnWalletNav.UseVisualStyleBackColor = false;
            btnWalletNav.Click += btnWalletNav_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(283, 69);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(143, 27);
            label5.Name = "label5";
            label5.Size = new Size(93, 32);
            label5.TabIndex = 3;
            label5.Text = "$ 155K";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(148, 8);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 2;
            label4.Text = "TOTAL/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 9);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 1;
            label3.Text = "MES/";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 28);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 0;
            label2.Text = "$ 4.5K";
            // 
            // btnNotifications
            // 
            btnNotifications.BackColor = Color.DarkOrange;
            btnNotifications.Cursor = Cursors.Hand;
            btnNotifications.Enabled = false;
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.Location = new Point(287, 1);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(61, 71);
            btnNotifications.TabIndex = 0;
            btnNotifications.UseVisualStyleBackColor = false;
            btnNotifications.Click += btnNotifications_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(9, 0, 20);
            panel5.Dock = DockStyle.Top;
            panel5.ForeColor = Color.Black;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1098, 71);
            panel5.TabIndex = 2;
            // 
            // panelNotifications
            // 
            panelNotifications.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelNotifications.BackColor = Color.White;
            panelNotifications.Controls.Add(label6);
            panelNotifications.Location = new Point(743, 70);
            panelNotifications.MaximumSize = new Size(0, 62);
            panelNotifications.Name = "panelNotifications";
            panelNotifications.Size = new Size(348, 10);
            panelNotifications.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 21);
            label6.Name = "label6";
            label6.Size = new Size(255, 21);
            label6.TabIndex = 0;
            label6.Text = "No tienes notificaciones pendientes";
            // 
            // timerNavbarNotifications
            // 
            timerNavbarNotifications.Interval = 5;
            timerNavbarNotifications.Tick += timerNavbarNotifications_Tick;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 0, 40);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 0, 40);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.payments_item;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(200, 63);
            button2.TabIndex = 2;
            button2.Text = "   Payments";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // timerAddAdmin
            // 
            timerAddAdmin.Interval = 5;
            timerAddAdmin.Tick += btnAddAdminTimer_Tick;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1358, 749);
            Controls.Add(sidebar);
            Controls.Add(mainWrapper);
            ForeColor = SystemColors.ActiveCaptionText;
            MinimumSize = new Size(1364, 700);
            Name = "MainView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gymsy";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            panelAddAdmin.ResumeLayout(false);
            tableLayoutAdmin.ResumeLayout(false);
            tableLayout.ResumeLayout(false);
            tableLayoutClient.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelNavUser.ResumeLayout(false);
            panelNavUser.PerformLayout();
            panelBtnAdd.ResumeLayout(false);
            mainWrapper.ResumeLayout(false);
            navbar.ResumeLayout(false);
            panelNavRight.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelNotifications.ResumeLayout(false);
            panelNotifications.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Panel panel3;
        private Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panelBtnAdd;
        private Button btnAdd;
        private Button btnNavAddClient;
        private Button btnNavAddPlan;
        private System.Windows.Forms.Timer btnAddTimer;
        private Panel panelNavUser;
        private Button BtnUserAvatar;
        private Button btnNavSettings;
        private Label LabelNavRol;
        private Button btnNavSignout;
        private Panel mainWrapper;
        private Panel navbar;
        private Panel panelNavRight;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnNotifications;
        private Panel panelNotifications;
        private Panel panel5;
        private Label label6;
        private System.Windows.Forms.Timer timerNavbarNotifications;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayout;
        private Button btnNavDashboard;
        private Button btnNavPayments;
        private Button btnNavClients;
        private TableLayoutPanel tableLayoutAdmin;
        private Button btnNavPaysAdmin;
        private Button btnNavInstructorAdmin;
        private Button btnNavDashAdmin;
        private TableLayoutPanel tableLayoutClient;
        private Button btnNavPaysClient;
        private Button btnNavProgress;
        private Button btnNavAboutme;
        private Panel panelAddAdmin;
        private Button button3;
        private Button btnAddInstructor;
        private Button btnAddAdmin;
        private System.Windows.Forms.Timer timerAddAdmin;
        private Button btnWalletNav;
    }
}