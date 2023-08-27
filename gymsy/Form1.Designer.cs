namespace gymsy
{
    partial class Form1
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
            TableLayoutPanel tableLayoutPanel1;
            PictureBox menuButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnNavClients = new Button();
            btnNavPayments = new Button();
            btnNavDashboard = new Button();
            sidebar = new Panel();
            panelNavUser = new Panel();
            btnNavSignout = new Button();
            labelNavRol = new Label();
            btnNavSettings = new Button();
            button4 = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panelBtnAdd = new Panel();
            btnNavAddPlan = new Button();
            btnNavAddClient = new Button();
            btnAdd = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            btnAddTimer = new System.Windows.Forms.Timer(components);
            mainWrapper = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuButton = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            sidebar.SuspendLayout();
            panelNavUser.SuspendLayout();
            panel3.SuspendLayout();
            panelBtnAdd.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnNavClients, 0, 1);
            tableLayoutPanel1.Controls.Add(btnNavPayments, 0, 1);
            tableLayoutPanel1.Controls.Add(btnNavDashboard, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 143);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.4072456F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.2594223F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(260, 184);
            tableLayoutPanel1.TabIndex = 0;
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
            btnNavClients.Location = new Point(0, 61);
            btnNavClients.Margin = new Padding(0);
            btnNavClients.Name = "btnNavClients";
            btnNavClients.Padding = new Padding(20, 0, 0, 0);
            btnNavClients.RightToLeft = RightToLeft.No;
            btnNavClients.Size = new Size(260, 61);
            btnNavClients.TabIndex = 1;
            btnNavClients.Text = "     Clients";
            btnNavClients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavClients.UseVisualStyleBackColor = false;
            btnNavClients.Click += btnNavClients_Click;
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
            btnNavPayments.Location = new Point(0, 122);
            btnNavPayments.Margin = new Padding(0);
            btnNavPayments.Name = "btnNavPayments";
            btnNavPayments.Padding = new Padding(10, 0, 0, 0);
            btnNavPayments.RightToLeft = RightToLeft.No;
            btnNavPayments.Size = new Size(260, 62);
            btnNavPayments.TabIndex = 2;
            btnNavPayments.Text = "   Payments";
            btnNavPayments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavPayments.UseVisualStyleBackColor = false;
            btnNavPayments.Click += btnNavPayments_Click;
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
            btnNavDashboard.Size = new Size(260, 61);
            btnNavDashboard.TabIndex = 0;
            btnNavDashboard.Text = "  Dashboard";
            btnNavDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNavDashboard.UseVisualStyleBackColor = false;
            btnNavDashboard.Click += btnNavDashboard_Click;
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.Location = new Point(30, 32);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(30, 33);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(9, 0, 20);
            sidebar.Controls.Add(panelNavUser);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panelBtnAdd);
            sidebar.Controls.Add(tableLayoutPanel1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(0);
            sidebar.MaximumSize = new Size(260, 0);
            sidebar.MinimumSize = new Size(70, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(260, 781);
            sidebar.TabIndex = 0;
            // 
            // panelNavUser
            // 
            panelNavUser.BackColor = Color.DarkOrange;
            panelNavUser.Controls.Add(btnNavSignout);
            panelNavUser.Controls.Add(labelNavRol);
            panelNavUser.Controls.Add(btnNavSettings);
            panelNavUser.Controls.Add(button4);
            panelNavUser.Dock = DockStyle.Bottom;
            panelNavUser.Location = new Point(0, 657);
            panelNavUser.Margin = new Padding(0);
            panelNavUser.Name = "panelNavUser";
            panelNavUser.Size = new Size(260, 124);
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
            // labelNavRol
            // 
            labelNavRol.AutoSize = true;
            labelNavRol.BackColor = Color.Transparent;
            labelNavRol.FlatStyle = FlatStyle.Flat;
            labelNavRol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNavRol.ForeColor = Color.FromArgb(9, 0, 20);
            labelNavRol.Location = new Point(76, 74);
            labelNavRol.Name = "labelNavRol";
            labelNavRol.Size = new Size(82, 15);
            labelNavRol.TabIndex = 2;
            labelNavRol.Text = "INSTRUCTOR";
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
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.gorilla_avatar;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 24);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(164, 75);
            button4.TabIndex = 0;
            button4.TabStop = false;
            button4.Text = "Barco1";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(menuButton);
            panel3.ForeColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(-8, -6);
            panel3.Name = "panel3";
            panel3.Size = new Size(310, 98);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 34);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 1;
            label1.Text = "GYMSY";
            // 
            // panelBtnAdd
            // 
            panelBtnAdd.BackColor = Color.Transparent;
            panelBtnAdd.Controls.Add(btnNavAddPlan);
            panelBtnAdd.Controls.Add(btnNavAddClient);
            panelBtnAdd.Controls.Add(btnAdd);
            panelBtnAdd.Location = new Point(0, 330);
            panelBtnAdd.MaximumSize = new Size(300, 154);
            panelBtnAdd.MinimumSize = new Size(300, 60);
            panelBtnAdd.Name = "panelBtnAdd";
            panelBtnAdd.Size = new Size(300, 60);
            panelBtnAdd.TabIndex = 2;
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
            btnNavAddPlan.Image = (Image)resources.GetObject("btnNavAddPlan.Image");
            btnNavAddPlan.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAddPlan.Location = new Point(2, 106);
            btnNavAddPlan.Margin = new Padding(0);
            btnNavAddPlan.Name = "btnNavAddPlan";
            btnNavAddPlan.Padding = new Padding(30, 0, 0, 0);
            btnNavAddPlan.Size = new Size(298, 39);
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
            btnNavAddClient.Image = (Image)resources.GetObject("btnNavAddClient.Image");
            btnNavAddClient.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAddClient.Location = new Point(2, 65);
            btnNavAddClient.Margin = new Padding(0);
            btnNavAddClient.Name = "btnNavAddClient";
            btnNavAddClient.Padding = new Padding(30, 0, 0, 0);
            btnNavAddClient.Size = new Size(297, 39);
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
            mainWrapper.BackColor = Color.FromArgb(15, 0, 40);
            mainWrapper.BackgroundImageLayout = ImageLayout.None;
            mainWrapper.Dock = DockStyle.Fill;
            mainWrapper.ForeColor = Color.Black;
            mainWrapper.Location = new Point(0, 0);
            mainWrapper.Margin = new Padding(100, 0, 0, 0);
            mainWrapper.Name = "mainWrapper";
            mainWrapper.Padding = new Padding(300, 0, 0, 0);
            mainWrapper.Size = new Size(1154, 781);
            mainWrapper.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1154, 781);
            Controls.Add(sidebar);
            Controls.Add(mainWrapper);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Gymsy";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            sidebar.ResumeLayout(false);
            panelNavUser.ResumeLayout(false);
            panelNavUser.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelBtnAdd.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Button btnNavDashboard;
        private Button btnNavClients;
        private Button btnNavPayments;
        private Panel panel3;
        private PictureBox menuButton;
        private Label label1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel panelBtnAdd;
        private Button btnAdd;
        private Button btnNavAddClient;
        private Button btnNavAddPlan;
        private System.Windows.Forms.Timer btnAddTimer;
        private Panel panelNavUser;
        private Button button4;
        private Button btnNavSettings;
        private Label labelNavRol;
        private Button btnNavSignout;
        private Panel mainWrapper;
    }
}