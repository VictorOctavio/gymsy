namespace gymsy.UserControls
{
    partial class AddClientUserControl
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
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            rjButton1 = new ClassCustom.RJButton();
            label19 = new Label();
            label20 = new Label();
            label17 = new Label();
            label18 = new Label();
            label15 = new Label();
            label16 = new Label();
            label14 = new Label();
            label12 = new Label();
            a = new Label();
            panel2 = new Panel();
            rjButton4 = new ClassCustom.RJButton();
            label13 = new Label();
            label10 = new Label();
            label11 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            label9 = new Label();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1469, 490);
            label1.Name = "label1";
            label1.Size = new Size(277, 37);
            label1.TabIndex = 0;
            label1.Text = "AddClientUserControl";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(a);
            panel1.Controls.Add(panel2);
            panel1.ForeColor = Color.FromArgb(230, 237, 243);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(rjButton1);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(539, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(412, 439);
            panel3.TabIndex = 52;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(41, 147, 45);
            rjButton1.BackgroundColor = Color.FromArgb(41, 147, 45);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            rjButton1.IconColor = Color.FromArgb(230, 237, 243);
            rjButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton1.ImageAlign = ContentAlignment.MiddleRight;
            rjButton1.Location = new Point(211, 369);
            rjButton1.Name = "rjButton1";
            rjButton1.Padding = new Padding(10, 0, 0, 0);
            rjButton1.Size = new Size(188, 53);
            rjButton1.TabIndex = 64;
            rjButton1.Text = "Guardar Cliente";
            rjButton1.TextAlign = ContentAlignment.MiddleLeft;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Red;
            label19.Location = new Point(34, 310);
            label19.Name = "label19";
            label19.Size = new Size(105, 15);
            label19.TabIndex = 60;
            label19.Text = "*Campo requerido";
            label19.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.FromArgb(230, 237, 243);
            label20.Location = new Point(34, 262);
            label20.Name = "label20";
            label20.Size = new Size(58, 15);
            label20.TabIndex = 61;
            label20.Text = "Instructor";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(34, 234);
            label17.Name = "label17";
            label17.Size = new Size(105, 15);
            label17.TabIndex = 57;
            label17.Text = "*Campo requerido";
            label17.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.FromArgb(230, 237, 243);
            label18.Location = new Point(34, 186);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 58;
            label18.Text = "Descripcion";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(34, 148);
            label15.Name = "label15";
            label15.Size = new Size(105, 15);
            label15.TabIndex = 54;
            label15.Text = "*Campo requerido";
            label15.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(230, 237, 243);
            label16.Location = new Point(34, 100);
            label16.Name = "label16";
            label16.Size = new Size(40, 15);
            label16.TabIndex = 55;
            label16.Text = "Precio";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(230, 237, 243);
            label14.Location = new Point(146, 12);
            label14.Name = "label14";
            label14.Size = new Size(118, 25);
            label14.TabIndex = 53;
            label14.Text = "Asignar plan";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(1323, 112);
            label12.Name = "label12";
            label12.Size = new Size(153, 25);
            label12.TabIndex = 50;
            label12.Text = "Asignale un plan";
            // 
            // a
            // 
            a.Anchor = AnchorStyles.Top;
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            a.ForeColor = Color.FromArgb(230, 237, 243);
            a.Location = new Point(418, 12);
            a.Name = "a";
            a.Size = new Size(263, 52);
            a.TabIndex = 33;
            a.Text = "Nuevo Cliente";
            // 
            // panel2
            // 
            panel2.Controls.Add(rjTextBox4);
            panel2.Controls.Add(rjTextBox3);
            panel2.Controls.Add(rjTextBox2);
            panel2.Controls.Add(rjTextBox1);
            panel2.Controls.Add(rjButton4);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(78, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 439);
            panel2.TabIndex = 51;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.DarkOrange;
            rjButton4.BackgroundColor = Color.DarkOrange;
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 15;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton4.ForeColor = Color.White;
            rjButton4.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            rjButton4.IconColor = Color.FromArgb(230, 237, 243);
            rjButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton4.ImageAlign = ContentAlignment.MiddleRight;
            rjButton4.Location = new Point(235, 234);
            rjButton4.Name = "rjButton4";
            rjButton4.Padding = new Padding(10, 0, 0, 0);
            rjButton4.Size = new Size(186, 53);
            rjButton4.TabIndex = 66;
            rjButton4.Text = "Agregar Imagen";
            rjButton4.TextAlign = ContentAlignment.MiddleLeft;
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(230, 237, 243);
            label13.Location = new Point(132, 12);
            label13.Name = "label13";
            label13.Size = new Size(155, 25);
            label13.TabIndex = 52;
            label13.Text = "Datos del Cliente";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(-163, 40);
            label10.Name = "label10";
            label10.Size = new Size(155, 25);
            label10.TabIndex = 48;
            label10.Text = "Datos del Cliente";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(249, 214);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 49;
            label11.Text = "*Campo requerido";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.FromArgb(16, 8, 23);
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Center;
            iconPictureBox1.ForeColor = Color.FromArgb(230, 237, 243);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = Color.FromArgb(230, 237, 243);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 149;
            iconPictureBox1.Location = new Point(235, 50);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(149, 159);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 35;
            iconPictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(230, 237, 243);
            label8.Location = new Point(23, 271);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 47;
            label8.Text = "Correo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(23, 325);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 46;
            label9.Text = "*Campo requerido";
            label9.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(23, 104);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 37;
            label2.Text = "*Campo requerido";
            label2.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(230, 237, 243);
            label6.Location = new Point(23, 194);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 44;
            label6.Text = "Usurio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(230, 237, 243);
            label3.Location = new Point(23, 50);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 38;
            label3.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(23, 248);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 43;
            label7.Text = "*Campo requerido";
            label7.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(23, 174);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 40;
            label5.Text = "*Campo requerido";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(230, 237, 243);
            label4.Location = new Point(23, 120);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 41;
            label4.Text = "Apellido";
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.FromArgb(69, 34, 99);
            rjTextBox1.BorderColor = Color.Transparent;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 15;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(23, 69);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "Ingrese un nombre...";
            rjTextBox1.Size = new Size(204, 31);
            rjTextBox1.TabIndex = 67;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = Color.FromArgb(69, 34, 99);
            rjTextBox2.BorderColor = Color.Transparent;
            rjTextBox2.BorderFocusColor = Color.HotPink;
            rjTextBox2.BorderRadius = 15;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(23, 139);
            rjTextBox2.Margin = new Padding(4);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DarkGray;
            rjTextBox2.PlaceholderText = "Ingrese un apellido...";
            rjTextBox2.Size = new Size(204, 31);
            rjTextBox2.TabIndex = 68;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            rjTextBox3.BackColor = Color.FromArgb(69, 34, 99);
            rjTextBox3.BorderColor = Color.Transparent;
            rjTextBox3.BorderFocusColor = Color.HotPink;
            rjTextBox3.BorderRadius = 15;
            rjTextBox3.BorderSize = 2;
            rjTextBox3.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox3.Location = new Point(23, 213);
            rjTextBox3.Margin = new Padding(4);
            rjTextBox3.Multiline = false;
            rjTextBox3.Name = "rjTextBox3";
            rjTextBox3.Padding = new Padding(10, 7, 10, 7);
            rjTextBox3.PasswordChar = false;
            rjTextBox3.PlaceholderColor = Color.DarkGray;
            rjTextBox3.PlaceholderText = "Ingrese un usuario...";
            rjTextBox3.Size = new Size(204, 31);
            rjTextBox3.TabIndex = 69;
            rjTextBox3.Texts = "";
            rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            rjTextBox4.BackColor = Color.FromArgb(69, 34, 99);
            rjTextBox4.BorderColor = Color.Transparent;
            rjTextBox4.BorderFocusColor = Color.HotPink;
            rjTextBox4.BorderRadius = 15;
            rjTextBox4.BorderSize = 2;
            rjTextBox4.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox4.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox4.Location = new Point(23, 290);
            rjTextBox4.Margin = new Padding(4);
            rjTextBox4.Multiline = false;
            rjTextBox4.Name = "rjTextBox4";
            rjTextBox4.Padding = new Padding(10, 7, 10, 7);
            rjTextBox4.PasswordChar = false;
            rjTextBox4.PlaceholderColor = Color.DarkGray;
            rjTextBox4.PlaceholderText = "Ingrese un correo...";
            rjTextBox4.Size = new Size(204, 31);
            rjTextBox4.TabIndex = 70;
            rjTextBox4.Texts = "";
            rjTextBox4.UnderlinedStyle = false;
            // 
            // AddClientUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "AddClientUserControl";
            Size = new Size(1000, 530);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label a;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Label label13;
        private Panel panel3;
        private Label label14;
        private Label label19;
        private Label label20;
        private Label label17;
        private Label label18;
        private Label label15;
        private Label label16;
        private ClassCustom.RJButton rjButton1;
        private ClassCustom.RJButton rjButton4;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
    }
}
