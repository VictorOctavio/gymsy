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
            panel3 = new Panel();
            label1 = new Label();
            panelNavUser = new Panel();
            btnNavSignout = new Button();
            labelNavRol = new Label();
            btnNavSettings = new Button();
            button4 = new Button();
            panelBtnAdd = new Panel();
            btnNavAddPlan = new Button();
            btnNavAddClient = new Button();
            btnAdd = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            btnAddTimer = new System.Windows.Forms.Timer(components);
            mainWrapper = new Panel();
            panelTest = new Panel();
            navbar = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuButton = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            panelNavUser.SuspendLayout();
            panelBtnAdd.SuspendLayout();
            mainWrapper.SuspendLayout();
            navbar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            menuButton.Location = new Point(30, 19);
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
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panelNavUser);
            sidebar.Controls.Add(panelBtnAdd);
            sidebar.Controls.Add(tableLayoutPanel1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(0);
            sidebar.MaximumSize = new Size(260, 0);
            sidebar.MinimumSize = new Size(70, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(260, 533);
            sidebar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(menuButton);
            panel3.ForeColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(-8, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 70);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 20);
            label1.Name = "label1";
            label1.Size = new Size(88, 30);
            label1.TabIndex = 1;
            label1.Text = "GYMSY";
            // 
            // panelNavUser
            // 
            panelNavUser.BackColor = Color.DarkOrange;
            panelNavUser.Controls.Add(btnNavSignout);
            panelNavUser.Controls.Add(labelNavRol);
            panelNavUser.Controls.Add(btnNavSettings);
            panelNavUser.Controls.Add(button4);
            panelNavUser.Dock = DockStyle.Bottom;
            panelNavUser.Location = new Point(0, 410);
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
            button4.Location = new Point(2, 24);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(162, 75);
            button4.TabIndex = 0;
            button4.TabStop = false;
            button4.Text = "Barco1";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // panelBtnAdd
            // 
            panelBtnAdd.BackColor = Color.Transparent;
            panelBtnAdd.Controls.Add(btnNavAddPlan);
            panelBtnAdd.Controls.Add(btnNavAddClient);
            panelBtnAdd.Controls.Add(btnAdd);
            panelBtnAdd.Location = new Point(0, 330);
            panelBtnAdd.MaximumSize = new Size(260, 154);
            panelBtnAdd.MinimumSize = new Size(260, 60);
            panelBtnAdd.Name = "panelBtnAdd";
            panelBtnAdd.Size = new Size(260, 60);
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
            btnNavAddClient.Image = (Image)resources.GetObject("btnNavAddClient.Image");
            btnNavAddClient.ImageAlign = ContentAlignment.MiddleLeft;
            btnNavAddClient.Location = new Point(2, 65);
            btnNavAddClient.Margin = new Padding(0);
            btnNavAddClient.Name = "btnNavAddClient";
            btnNavAddClient.Padding = new Padding(30, 0, 0, 0);
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
            mainWrapper.BackColor = Color.White;
            mainWrapper.BackgroundImageLayout = ImageLayout.None;
            mainWrapper.Controls.Add(panelTest);
            mainWrapper.Controls.Add(navbar);
            mainWrapper.Dock = DockStyle.Fill;
            mainWrapper.ForeColor = Color.Black;
            mainWrapper.Location = new Point(0, 0);
            mainWrapper.Margin = new Padding(0);
            mainWrapper.Name = "mainWrapper";
            mainWrapper.Padding = new Padding(260, 0, 0, 0);
            mainWrapper.Size = new Size(1177, 533);
            mainWrapper.TabIndex = 0;
            // 
            // panelTest
            // 
            panelTest.BackColor = Color.IndianRed;
            panelTest.Location = new Point(366, 102);
            panelTest.Name = "panelTest";
            panelTest.Size = new Size(556, 276);
            panelTest.TabIndex = 1;
            panelTest.Paint += panelTest_Paint;
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(9, 0, 20);
            navbar.Controls.Add(panel1);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(260, 0);
            navbar.Margin = new Padding(0);
            navbar.Name = "navbar";
            navbar.Size = new Size(917, 70);
            navbar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(573, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(344, 70);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 70);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Transparent;
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
            label4.ForeColor = Color.Transparent;
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
            label3.ForeColor = Color.Transparent;
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
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(35, 28);
            label2.Name = "label2";
            label2.Size = new Size(86, 32);
            label2.TabIndex = 0;
            label2.Text = "$ 4.5K";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(285, 0);
            button1.Name = "button1";
            button1.Size = new Size(61, 70);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1177, 533);
            Controls.Add(sidebar);
            Controls.Add(mainWrapper);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Gymsy";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panelNavUser.ResumeLayout(false);
            panelNavUser.PerformLayout();
            panelBtnAdd.ResumeLayout(false);
            mainWrapper.ResumeLayout(false);
            navbar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel navbar;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panelTest;
    }
}