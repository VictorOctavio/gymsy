namespace gymsy.UserControls
{
    partial class SettingsUserControl
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
            a = new Label();
            settingsWrapper = new Panel();
            comboBoxAvatar = new ComboBox();
            gorilla_avatar = new PictureBox();
            panelError = new Panel();
            panelErrorBtnClose = new Button();
            panelErrorText = new Label();
            btnChangePassword = new Button();
            label13 = new Label();
            panel5 = new Panel();
            tbCurrentPassword = new TextBox();
            label9 = new Label();
            textErrorCurrPass = new Label();
            panel6 = new Panel();
            tbNewPassword = new TextBox();
            label11 = new Label();
            textErrorNewPass = new Label();
            btnSaveChanges = new Button();
            btnEditAvatar = new Button();
            panel2 = new Panel();
            tbName = new TextBox();
            label1 = new Label();
            textErrorName = new Label();
            textBox2 = new TextBox();
            panel3 = new Panel();
            tbEmail = new TextBox();
            label5 = new Label();
            textErrorEmail = new Label();
            panel1 = new Panel();
            tbNickname = new TextBox();
            label2 = new Label();
            textErrorNickname = new Label();
            panel4 = new Panel();
            tbSurname = new TextBox();
            label7 = new Label();
            textErrorSurname = new Label();
            settingsWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gorilla_avatar).BeginInit();
            panelError.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // a
            // 
            a.Anchor = AnchorStyles.Top;
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            a.ForeColor = Color.White;
            a.Location = new Point(535, 25);
            a.Name = "a";
            a.Size = new Size(263, 52);
            a.TabIndex = 0;
            a.Text = "Configuracion";
            // 
            // settingsWrapper
            // 
            settingsWrapper.AutoScroll = true;
            settingsWrapper.AutoScrollMinSize = new Size(800, 700);
            settingsWrapper.AutoSize = true;
            settingsWrapper.BackColor = Color.FromArgb(16, 8, 30);
            settingsWrapper.Controls.Add(comboBoxAvatar);
            settingsWrapper.Controls.Add(gorilla_avatar);
            settingsWrapper.Controls.Add(panelError);
            settingsWrapper.Controls.Add(btnChangePassword);
            settingsWrapper.Controls.Add(label13);
            settingsWrapper.Controls.Add(panel5);
            settingsWrapper.Controls.Add(panel6);
            settingsWrapper.Controls.Add(btnSaveChanges);
            settingsWrapper.Controls.Add(a);
            settingsWrapper.Controls.Add(btnEditAvatar);
            settingsWrapper.Controls.Add(panel2);
            settingsWrapper.Controls.Add(textBox2);
            settingsWrapper.Controls.Add(panel3);
            settingsWrapper.Controls.Add(panel1);
            settingsWrapper.Controls.Add(panel4);
            settingsWrapper.Dock = DockStyle.Fill;
            settingsWrapper.Location = new Point(0, 0);
            settingsWrapper.Margin = new Padding(0);
            settingsWrapper.Name = "settingsWrapper";
            settingsWrapper.Size = new Size(1366, 768);
            settingsWrapper.TabIndex = 1;
            settingsWrapper.Paint += SettingsWrapper_Paint;
            // 
            // comboBoxAvatar
            // 
            comboBoxAvatar.Anchor = AnchorStyles.Top;
            comboBoxAvatar.FormattingEnabled = true;
            comboBoxAvatar.Items.AddRange(new object[] { "gorilla_avatar", "duck_avatar", "dog_avatar", "cat_avatar", "panda_avatar", "chicken_avatar", "raccoon_avatar", "penguin_avatar" });
            comboBoxAvatar.Location = new Point(590, 182);
            comboBoxAvatar.Name = "comboBoxAvatar";
            comboBoxAvatar.Size = new Size(121, 23);
            comboBoxAvatar.TabIndex = 50;
            // 
            // gorilla_avatar
            // 
            gorilla_avatar.Anchor = AnchorStyles.Top;
            gorilla_avatar.Image = Properties.Resources.gorilla_avatar;
            gorilla_avatar.Location = new Point(623, 108);
            gorilla_avatar.Name = "gorilla_avatar";
            gorilla_avatar.Size = new Size(69, 68);
            gorilla_avatar.TabIndex = 45;
            gorilla_avatar.TabStop = false;
            // 
            // panelError
            // 
            panelError.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelError.BackColor = Color.Crimson;
            panelError.Controls.Add(panelErrorBtnClose);
            panelError.Controls.Add(panelErrorText);
            panelError.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panelError.ForeColor = Color.White;
            panelError.Location = new Point(1086, 718);
            panelError.Margin = new Padding(0);
            panelError.Name = "panelError";
            panelError.Size = new Size(280, 50);
            panelError.TabIndex = 40;
            panelError.Visible = false;
            // 
            // panelErrorBtnClose
            // 
            panelErrorBtnClose.BackColor = Color.Transparent;
            panelErrorBtnClose.Cursor = Cursors.Hand;
            panelErrorBtnClose.FlatAppearance.BorderSize = 0;
            panelErrorBtnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            panelErrorBtnClose.FlatStyle = FlatStyle.Flat;
            panelErrorBtnClose.ForeColor = Color.LightGray;
            panelErrorBtnClose.Location = new Point(251, 3);
            panelErrorBtnClose.Name = "panelErrorBtnClose";
            panelErrorBtnClose.Size = new Size(26, 23);
            panelErrorBtnClose.TabIndex = 1;
            panelErrorBtnClose.Text = "X";
            panelErrorBtnClose.UseVisualStyleBackColor = false;
            panelErrorBtnClose.Click += PanelErrorBtnClose_Click;
            // 
            // panelErrorText
            // 
            panelErrorText.AutoSize = true;
            panelErrorText.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            panelErrorText.Location = new Point(63, 19);
            panelErrorText.Name = "panelErrorText";
            panelErrorText.Size = new Size(145, 18);
            panelErrorText.TabIndex = 0;
            panelErrorText.Text = "Campos Requeridos";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.Top;
            btnChangePassword.BackColor = Color.DarkCyan;
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(919, 472);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(87, 34);
            btnChangePassword.TabIndex = 39;
            btnChangePassword.Text = "Cambiar ";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += BtnChangePassword_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(320, 473);
            label13.Name = "label13";
            label13.Size = new Size(145, 36);
            label13.TabIndex = 38;
            label13.Text = "Contraseña";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top;
            panel5.Controls.Add(tbCurrentPassword);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(textErrorCurrPass);
            panel5.Location = new Point(666, 512);
            panel5.Name = "panel5";
            panel5.Size = new Size(340, 88);
            panel5.TabIndex = 37;
            // 
            // tbCurrentPassword
            // 
            tbCurrentPassword.Anchor = AnchorStyles.None;
            tbCurrentPassword.Cursor = Cursors.Hand;
            tbCurrentPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbCurrentPassword.ForeColor = Color.FromArgb(9, 0, 20);
            tbCurrentPassword.Location = new Point(0, 37);
            tbCurrentPassword.Margin = new Padding(5);
            tbCurrentPassword.Multiline = true;
            tbCurrentPassword.Name = "tbCurrentPassword";
            tbCurrentPassword.Size = new Size(335, 40);
            tbCurrentPassword.TabIndex = 11;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(4, 12);
            label9.Name = "label9";
            label9.Size = new Size(108, 25);
            label9.TabIndex = 1;
            label9.Text = "Actual Clave";
            // 
            // textErrorCurrPass
            // 
            textErrorCurrPass.AutoSize = true;
            textErrorCurrPass.BackColor = Color.Transparent;
            textErrorCurrPass.FlatStyle = FlatStyle.Flat;
            textErrorCurrPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textErrorCurrPass.ForeColor = Color.Crimson;
            textErrorCurrPass.Location = new Point(254, 18);
            textErrorCurrPass.Name = "textErrorCurrPass";
            textErrorCurrPass.Size = new Size(82, 19);
            textErrorCurrPass.TabIndex = 29;
            textErrorCurrPass.Text = "*requerido";
            textErrorCurrPass.Visible = false;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top;
            panel6.Controls.Add(tbNewPassword);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(textErrorNewPass);
            panel6.Location = new Point(320, 512);
            panel6.Name = "panel6";
            panel6.Size = new Size(340, 88);
            panel6.TabIndex = 36;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Anchor = AnchorStyles.None;
            tbNewPassword.Cursor = Cursors.Hand;
            tbNewPassword.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbNewPassword.ForeColor = Color.FromArgb(9, 0, 20);
            tbNewPassword.Location = new Point(2, 37);
            tbNewPassword.Margin = new Padding(5);
            tbNewPassword.Multiline = true;
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(335, 40);
            tbNewPassword.TabIndex = 11;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(4, 12);
            label11.Name = "label11";
            label11.Size = new Size(106, 25);
            label11.TabIndex = 1;
            label11.Text = "Nueva clave";
            // 
            // textErrorNewPass
            // 
            textErrorNewPass.AutoSize = true;
            textErrorNewPass.BackColor = Color.Transparent;
            textErrorNewPass.FlatStyle = FlatStyle.Flat;
            textErrorNewPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textErrorNewPass.ForeColor = Color.Crimson;
            textErrorNewPass.Location = new Point(256, 13);
            textErrorNewPass.Name = "textErrorNewPass";
            textErrorNewPass.Size = new Size(82, 19);
            textErrorNewPass.TabIndex = 29;
            textErrorNewPass.Text = "*requerido";
            textErrorNewPass.Visible = false;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Anchor = AnchorStyles.Top;
            btnSaveChanges.BackColor = Color.DarkOrange;
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(561, 636);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Padding = new Padding(10);
            btnSaveChanges.Size = new Size(225, 55);
            btnSaveChanges.TabIndex = 10;
            btnSaveChanges.Text = "Guardar Cambios";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += BtnSaveChanges_Click;
            // 
            // btnEditAvatar
            // 
            btnEditAvatar.Anchor = AnchorStyles.Top;
            btnEditAvatar.BackColor = Color.DarkCyan;
            btnEditAvatar.Cursor = Cursors.Hand;
            btnEditAvatar.FlatAppearance.BorderSize = 0;
            btnEditAvatar.FlatStyle = FlatStyle.Flat;
            btnEditAvatar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditAvatar.ForeColor = Color.White;
            btnEditAvatar.Location = new Point(717, 183);
            btnEditAvatar.Name = "btnEditAvatar";
            btnEditAvatar.Size = new Size(28, 23);
            btnEditAvatar.TabIndex = 3;
            btnEditAvatar.Text = "Editar";
            btnEditAvatar.UseVisualStyleBackColor = false;
            btnEditAvatar.Click += BtnEditAvatar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(tbName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textErrorName);
            panel2.Location = new Point(321, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 88);
            panel2.TabIndex = 30;
            // 
            // tbName
            // 
            tbName.Anchor = AnchorStyles.None;
            tbName.Cursor = Cursors.Hand;
            tbName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.ForeColor = Color.FromArgb(9, 0, 20);
            tbName.Location = new Point(5, 46);
            tbName.Margin = new Padding(5);
            tbName.Multiline = true;
            tbName.Name = "tbName";
            tbName.Size = new Size(335, 37);
            tbName.TabIndex = 11;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 22);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // textErrorName
            // 
            textErrorName.AutoSize = true;
            textErrorName.BackColor = Color.Transparent;
            textErrorName.FlatStyle = FlatStyle.Flat;
            textErrorName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textErrorName.ForeColor = Color.Crimson;
            textErrorName.Location = new Point(257, 26);
            textErrorName.Name = "textErrorName";
            textErrorName.Size = new Size(82, 19);
            textErrorName.TabIndex = 29;
            textErrorName.Text = "*requerido";
            textErrorName.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top;
            textBox2.Cursor = Cursors.Hand;
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(692, 531);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 31);
            textBox2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(tbEmail);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textErrorEmail);
            panel3.Location = new Point(666, 357);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 88);
            panel3.TabIndex = 33;
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.None;
            tbEmail.Cursor = Cursors.Hand;
            tbEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.ForeColor = Color.FromArgb(9, 0, 20);
            tbEmail.Location = new Point(0, 43);
            tbEmail.Margin = new Padding(5);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(335, 40);
            tbEmail.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 18);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // textErrorEmail
            // 
            textErrorEmail.AutoSize = true;
            textErrorEmail.BackColor = Color.Transparent;
            textErrorEmail.FlatStyle = FlatStyle.Flat;
            textErrorEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textErrorEmail.ForeColor = Color.Crimson;
            textErrorEmail.Location = new Point(253, 23);
            textErrorEmail.Name = "textErrorEmail";
            textErrorEmail.Size = new Size(82, 19);
            textErrorEmail.TabIndex = 29;
            textErrorEmail.Text = "*requerido";
            textErrorEmail.Visible = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(tbNickname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textErrorNickname);
            panel1.Location = new Point(321, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 88);
            panel1.TabIndex = 31;
            // 
            // tbNickname
            // 
            tbNickname.Anchor = AnchorStyles.None;
            tbNickname.Cursor = Cursors.Hand;
            tbNickname.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbNickname.ForeColor = Color.FromArgb(9, 0, 20);
            tbNickname.Location = new Point(0, 43);
            tbNickname.Margin = new Padding(5);
            tbNickname.Multiline = true;
            tbNickname.Name = "tbNickname";
            tbNickname.Size = new Size(335, 40);
            tbNickname.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "Nickname";
            // 
            // textErrorNickname
            // 
            textErrorNickname.AutoSize = true;
            textErrorNickname.BackColor = Color.Transparent;
            textErrorNickname.FlatStyle = FlatStyle.Flat;
            textErrorNickname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textErrorNickname.ForeColor = Color.Crimson;
            textErrorNickname.Location = new Point(257, 23);
            textErrorNickname.Name = "textErrorNickname";
            textErrorNickname.Size = new Size(82, 19);
            textErrorNickname.TabIndex = 29;
            textErrorNickname.Text = "*requerido";
            textErrorNickname.Visible = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(tbSurname);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(textErrorSurname);
            panel4.Location = new Point(666, 263);
            panel4.Name = "panel4";
            panel4.Size = new Size(340, 88);
            panel4.TabIndex = 32;
            // 
            // tbSurname
            // 
            tbSurname.Anchor = AnchorStyles.None;
            tbSurname.Cursor = Cursors.Hand;
            tbSurname.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbSurname.ForeColor = Color.FromArgb(9, 0, 20);
            tbSurname.Location = new Point(0, 46);
            tbSurname.Margin = new Padding(5);
            tbSurname.Multiline = true;
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(335, 37);
            tbSurname.TabIndex = 11;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(2, 18);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 1;
            label7.Text = "Apellido";
            // 
            // textErrorSurname
            // 
            textErrorSurname.AutoSize = true;
            textErrorSurname.BackColor = Color.Transparent;
            textErrorSurname.FlatStyle = FlatStyle.Flat;
            textErrorSurname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textErrorSurname.ForeColor = Color.Crimson;
            textErrorSurname.Location = new Point(255, 22);
            textErrorSurname.Name = "textErrorSurname";
            textErrorSurname.Size = new Size(82, 19);
            textErrorSurname.TabIndex = 29;
            textErrorSurname.Text = "*requerido";
            textErrorSurname.Visible = false;
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(settingsWrapper);
            Margin = new Padding(100);
            Name = "SettingsUserControl";
            Size = new Size(1366, 768);
            settingsWrapper.ResumeLayout(false);
            settingsWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gorilla_avatar).EndInit();
            panelError.ResumeLayout(false);
            panelError.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label a;
        private Panel settingsWrapper;
        private Panel panel5;
        private TextBox tbCurrentPassword;
        private Label label9;
        private Label textErrorCurrPass;
        private Panel panel6;
        private TextBox tbNewPassword;
        private Label label11;
        private Label textErrorNewPass;
        private Button btnSaveChanges;
        private Button btnEditAvatar;
        private Panel panel2;
        private TextBox tbName;
        private Label label1;
        private Label textErrorName;
        private TextBox textBox2;
        private Panel panel3;
        private TextBox tbEmail;
        private Label label5;
        private Label textErrorEmail;
        private Panel panel1;
        private TextBox tbNickname;
        private Label label2;
        private Label textErrorNickname;
        private Panel panel4;
        private TextBox tbSurname;
        private Label label7;
        private Label textErrorSurname;
        private Button btnChangePassword;
        private Label label13;
        private Panel panelError;
        private Label panelErrorText;
        private Button panelErrorBtnClose;
        private PictureBox gorilla_avatar;
        private ComboBox comboBoxAvatar;
    }
}
