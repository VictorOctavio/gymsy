﻿namespace gymsy.UserControls
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
            back = new ClassCustom.RJButton();
            gorilla_avatar = new ClassCustom.RJCircularPictureBox();
            TBRutaImagen = new TextBox();
            label3 = new Label();
            BTAgregarImagen = new ClassCustom.RJButton();
            LRuraImagen = new Label();
            LbErrorChangePass = new Label();
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
            panel2 = new Panel();
            TbFirstName = new TextBox();
            label1 = new Label();
            textErrorName = new Label();
            textBox2 = new TextBox();
            panel3 = new Panel();
            TbPhone = new TextBox();
            label5 = new Label();
            textErrorEmail = new Label();
            panel1 = new Panel();
            TbCBU = new TextBox();
            label2 = new Label();
            textErrorNickname = new Label();
            panel4 = new Panel();
            TbLastName = new TextBox();
            label7 = new Label();
            textErrorSurname = new Label();
            openFileDialog1 = new OpenFileDialog();
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
            a.Location = new Point(372, 12);
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
            settingsWrapper.BackColor = Color.FromArgb(16, 8, 23);
            settingsWrapper.Controls.Add(back);
            settingsWrapper.Controls.Add(gorilla_avatar);
            settingsWrapper.Controls.Add(TBRutaImagen);
            settingsWrapper.Controls.Add(label3);
            settingsWrapper.Controls.Add(BTAgregarImagen);
            settingsWrapper.Controls.Add(LRuraImagen);
            settingsWrapper.Controls.Add(LbErrorChangePass);
            settingsWrapper.Controls.Add(panelError);
            settingsWrapper.Controls.Add(btnChangePassword);
            settingsWrapper.Controls.Add(label13);
            settingsWrapper.Controls.Add(panel5);
            settingsWrapper.Controls.Add(panel6);
            settingsWrapper.Controls.Add(btnSaveChanges);
            settingsWrapper.Controls.Add(a);
            settingsWrapper.Controls.Add(panel2);
            settingsWrapper.Controls.Add(textBox2);
            settingsWrapper.Controls.Add(panel3);
            settingsWrapper.Controls.Add(panel1);
            settingsWrapper.Controls.Add(panel4);
            settingsWrapper.Dock = DockStyle.Fill;
            settingsWrapper.Location = new Point(0, 0);
            settingsWrapper.Margin = new Padding(0);
            settingsWrapper.Name = "settingsWrapper";
            settingsWrapper.Size = new Size(1038, 703);
            settingsWrapper.TabIndex = 1;
            // 
            // back
            // 
            back.BackColor = Color.DarkOrange;
            back.BackgroundColor = Color.DarkOrange;
            back.BorderColor = Color.PaleVioletRed;
            back.BorderRadius = 15;
            back.BorderSize = 0;
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = Color.White;
            back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeftLong;
            back.IconColor = Color.FromArgb(230, 237, 243);
            back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            back.IconSize = 90;
            back.ImageAlign = ContentAlignment.MiddleRight;
            back.Location = new Point(23, 12);
            back.Name = "back";
            back.Padding = new Padding(10, 0, 0, 0);
            back.Size = new Size(103, 64);
            back.TabIndex = 94;
            back.TextAlign = ContentAlignment.MiddleLeft;
            back.TextColor = Color.White;
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // gorilla_avatar
            // 
            gorilla_avatar.BackgroundImage = Properties.Resources.gorilla_avatar;
            gorilla_avatar.BackgroundImageLayout = ImageLayout.Zoom;
            gorilla_avatar.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            gorilla_avatar.BorderColor = Color.RoyalBlue;
            gorilla_avatar.BorderColor2 = Color.HotPink;
            gorilla_avatar.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            gorilla_avatar.BorderSize = 2;
            gorilla_avatar.ErrorImage = Properties.Resources.gorilla_avatar;
            gorilla_avatar.GradientAngle = 50F;
            gorilla_avatar.Location = new Point(447, 67);
            gorilla_avatar.Name = "gorilla_avatar";
            gorilla_avatar.Size = new Size(100, 100);
            gorilla_avatar.SizeMode = PictureBoxSizeMode.StretchImage;
            gorilla_avatar.TabIndex = 93;
            gorilla_avatar.TabStop = false;
            // 
            // TBRutaImagen
            // 
            TBRutaImagen.BackColor = Color.FromArgb(69, 34, 99);
            TBRutaImagen.BorderStyle = BorderStyle.None;
            TBRutaImagen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBRutaImagen.ForeColor = Color.FromArgb(230, 237, 243);
            TBRutaImagen.Location = new Point(412, 206);
            TBRutaImagen.Name = "TBRutaImagen";
            TBRutaImagen.PlaceholderText = "Ruta...";
            TBRutaImagen.ReadOnly = true;
            TBRutaImagen.Size = new Size(186, 22);
            TBRutaImagen.TabIndex = 92;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(230, 237, 243);
            label3.Location = new Point(442, 177);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 91;
            label3.Text = "Ruta de la imagen";
            // 
            // BTAgregarImagen
            // 
            BTAgregarImagen.BackColor = Color.DarkOrange;
            BTAgregarImagen.BackgroundColor = Color.DarkOrange;
            BTAgregarImagen.BorderColor = Color.PaleVioletRed;
            BTAgregarImagen.BorderRadius = 15;
            BTAgregarImagen.BorderSize = 0;
            BTAgregarImagen.FlatAppearance.BorderSize = 0;
            BTAgregarImagen.FlatStyle = FlatStyle.Flat;
            BTAgregarImagen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTAgregarImagen.ForeColor = Color.White;
            BTAgregarImagen.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            BTAgregarImagen.IconColor = Color.FromArgb(230, 237, 243);
            BTAgregarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTAgregarImagen.ImageAlign = ContentAlignment.MiddleRight;
            BTAgregarImagen.Location = new Point(620, 190);
            BTAgregarImagen.Name = "BTAgregarImagen";
            BTAgregarImagen.Padding = new Padding(10, 0, 0, 0);
            BTAgregarImagen.Size = new Size(186, 53);
            BTAgregarImagen.TabIndex = 90;
            BTAgregarImagen.Text = "Agregar Imagen";
            BTAgregarImagen.TextAlign = ContentAlignment.MiddleLeft;
            BTAgregarImagen.TextColor = Color.White;
            BTAgregarImagen.UseVisualStyleBackColor = false;
            BTAgregarImagen.Click += BTAgregarImagen_Click;
            // 
            // LRuraImagen
            // 
            LRuraImagen.AutoSize = true;
            LRuraImagen.ForeColor = Color.Red;
            LRuraImagen.Location = new Point(441, 231);
            LRuraImagen.Name = "LRuraImagen";
            LRuraImagen.Size = new Size(105, 15);
            LRuraImagen.TabIndex = 89;
            LRuraImagen.Text = "*Campo requerido";
            LRuraImagen.Visible = false;
            // 
            // LbErrorChangePass
            // 
            LbErrorChangePass.Anchor = AnchorStyles.Top;
            LbErrorChangePass.AutoSize = true;
            LbErrorChangePass.BackColor = Color.Transparent;
            LbErrorChangePass.FlatStyle = FlatStyle.Flat;
            LbErrorChangePass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LbErrorChangePass.ForeColor = Color.Crimson;
            LbErrorChangePass.Location = new Point(307, 487);
            LbErrorChangePass.Name = "LbErrorChangePass";
            LbErrorChangePass.Size = new Size(82, 19);
            LbErrorChangePass.TabIndex = 30;
            LbErrorChangePass.Text = "*requerido";
            LbErrorChangePass.Visible = false;
            // 
            // panelError
            // 
            panelError.Anchor = AnchorStyles.Right;
            panelError.BackColor = Color.Crimson;
            panelError.Controls.Add(panelErrorBtnClose);
            panelError.Controls.Add(panelErrorText);
            panelError.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panelError.ForeColor = Color.White;
            panelError.Location = new Point(755, 653);
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
            panelErrorText.Location = new Point(69, 17);
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
            btnChangePassword.Location = new Point(755, 472);
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
            label13.Location = new Point(156, 473);
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
            panel5.Location = new Point(502, 512);
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
            tbCurrentPassword.PasswordChar = '*';
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
            panel6.Location = new Point(156, 512);
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
            tbNewPassword.PasswordChar = '*';
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
            btnSaveChanges.Location = new Point(397, 636);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Padding = new Padding(10);
            btnSaveChanges.Size = new Size(225, 55);
            btnSaveChanges.TabIndex = 10;
            btnSaveChanges.Text = "Guardar Cambios";
            btnSaveChanges.UseVisualStyleBackColor = false;
            btnSaveChanges.Click += BtnSaveChanges_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(TbFirstName);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textErrorName);
            panel2.Location = new Point(157, 263);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 88);
            panel2.TabIndex = 30;
            // 
            // TbFirstName
            // 
            TbFirstName.Anchor = AnchorStyles.None;
            TbFirstName.Cursor = Cursors.Hand;
            TbFirstName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TbFirstName.ForeColor = Color.FromArgb(9, 0, 20);
            TbFirstName.Location = new Point(5, 46);
            TbFirstName.Margin = new Padding(5);
            TbFirstName.Multiline = true;
            TbFirstName.Name = "TbFirstName";
            TbFirstName.Size = new Size(335, 37);
            TbFirstName.TabIndex = 11;
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
            textBox2.Location = new Point(528, 531);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 31);
            textBox2.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Controls.Add(TbPhone);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(textErrorEmail);
            panel3.Location = new Point(502, 357);
            panel3.Name = "panel3";
            panel3.Size = new Size(340, 88);
            panel3.TabIndex = 33;
            // 
            // TbPhone
            // 
            TbPhone.Anchor = AnchorStyles.None;
            TbPhone.Cursor = Cursors.Hand;
            TbPhone.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TbPhone.ForeColor = Color.FromArgb(9, 0, 20);
            TbPhone.Location = new Point(0, 43);
            TbPhone.Margin = new Padding(5);
            TbPhone.Multiline = true;
            TbPhone.Name = "TbPhone";
            TbPhone.Size = new Size(335, 40);
            TbPhone.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 18);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 1;
            label5.Text = "Telefono";
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
            panel1.Controls.Add(TbCBU);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textErrorNickname);
            panel1.Location = new Point(157, 357);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 88);
            panel1.TabIndex = 31;
            // 
            // TbCBU
            // 
            TbCBU.Anchor = AnchorStyles.None;
            TbCBU.Cursor = Cursors.Hand;
            TbCBU.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TbCBU.ForeColor = Color.FromArgb(9, 0, 20);
            TbCBU.Location = new Point(0, 43);
            TbCBU.Margin = new Padding(5);
            TbCBU.Multiline = true;
            TbCBU.Name = "TbCBU";
            TbCBU.Size = new Size(335, 40);
            TbCBU.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(45, 25);
            label2.TabIndex = 1;
            label2.Text = "CBU";
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
            panel4.Controls.Add(TbLastName);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(textErrorSurname);
            panel4.Location = new Point(502, 263);
            panel4.Name = "panel4";
            panel4.Size = new Size(340, 88);
            panel4.TabIndex = 32;
            // 
            // TbLastName
            // 
            TbLastName.Anchor = AnchorStyles.None;
            TbLastName.Cursor = Cursors.Hand;
            TbLastName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TbLastName.ForeColor = Color.FromArgb(9, 0, 20);
            TbLastName.Location = new Point(0, 46);
            TbLastName.Margin = new Padding(5);
            TbLastName.Multiline = true;
            TbLastName.Name = "TbLastName";
            TbLastName.Size = new Size(335, 37);
            TbLastName.TabIndex = 11;
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(settingsWrapper);
            Margin = new Padding(100);
            Name = "SettingsUserControl";
            Size = new Size(1038, 703);
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
        private Panel panel2;
        private TextBox TbFirstName;
        private Label label1;
        private Label textErrorName;
        private TextBox textBox2;
        private Panel panel3;
        private TextBox TbPhone;
        private Label label5;
        private Label textErrorEmail;
        private Panel panel1;
        private TextBox TbCBU;
        private Label label2;
        private Label textErrorNickname;
        private Panel panel4;
        private TextBox TbLastName;
        private Label label7;
        private Label textErrorSurname;
        private Button btnChangePassword;
        private Label label13;
        private Panel panelError;
        private Label panelErrorText;
        private Button panelErrorBtnClose;
        private Label LbErrorChangePass;
        private ClassCustom.RJCircularPictureBox gorilla_avatar;
        private TextBox TBRutaImagen;
        private Label label3;
        private ClassCustom.RJButton BTAgregarImagen;
        private Label LRuraImagen;
        private OpenFileDialog openFileDialog1;
        private ClassCustom.RJButton back;
    }
}
