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
            label12 = new Label();
            a = new Label();
            panel2 = new Panel();
            label13 = new Label();
            label10 = new Label();
            label11 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1204, 491);
            label1.Name = "label1";
            label1.Size = new Size(277, 37);
            label1.TabIndex = 0;
            label1.Text = "AddClientUserControl";
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Controls.Add(a);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 1;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(1057, 112);
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
            a.ForeColor = SystemColors.ActiveCaptionText;
            a.Location = new Point(390, 4);
            a.Name = "a";
            a.Size = new Size(263, 52);
            a.TabIndex = 33;
            a.Text = "Nuevo Cliente";
            // 
            // panel2
            // 
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(iconButton1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(270, 96);
            panel2.Name = "panel2";
            panel2.Size = new Size(442, 405);
            panel2.TabIndex = 51;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(148, 35);
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
            label11.Location = new Point(244, 255);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 49;
            label11.Text = "*Campo requerido";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.BackgroundImageLayout = ImageLayout.Center;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 129;
            iconPictureBox1.Location = new Point(228, 123);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(149, 129);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 35;
            iconPictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 324);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 47;
            label8.Text = "Correo";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.DarkOrange;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.ImageAlign = ContentAlignment.MiddleRight;
            iconButton1.Location = new Point(222, 277);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(155, 51);
            iconButton1.TabIndex = 34;
            iconButton1.Text = "Agregar Imagen";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(16, 372);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 46;
            label9.Text = "*Campo requerido";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(17, 344);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(199, 23);
            textBox4.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(16, 151);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 37;
            label2.Text = "*Campo requerido";
            label2.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 247);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 44;
            label6.Text = "Usurio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 103);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 38;
            label3.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(16, 295);
            label7.Name = "label7";
            label7.Size = new Size(105, 15);
            label7.TabIndex = 43;
            label7.Text = "*Campo requerido";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 23);
            textBox2.TabIndex = 39;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(17, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 23);
            textBox3.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(16, 221);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 40;
            label5.Text = "*Campo requerido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 173);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 41;
            label4.Text = "Apellido";
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
            Size = new Size(1003, 533);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label9;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private Panel panel2;
        private Label label13;
    }
}
