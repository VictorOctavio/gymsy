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
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            a = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            label6 = new Label();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            textBox9 = new TextBox();
            label5 = new Label();
            textBox8 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(354, 473);
            textBox1.Margin = new Padding(5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(322, 40);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(352, 267);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.gorilla_avatar;
            pictureBox1.Location = new Point(642, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 68);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // a
            // 
            a.Anchor = AnchorStyles.None;
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            a.ForeColor = SystemColors.ActiveCaptionText;
            a.Location = new Point(560, 47);
            a.Name = "a";
            a.Size = new Size(263, 52);
            a.TabIndex = 0;
            a.Text = "Configuracion";
            a.Click += a_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Cursor = Cursors.Hand;
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(724, 477);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(0, 31);
            textBox2.TabIndex = 21;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.DarkOrange;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(642, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 34);
            button1.TabIndex = 3;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(719, 447);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 22;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(352, 447);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 5;
            label2.Text = "Contraseña";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Cursor = Cursors.Hand;
            textBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(719, 474);
            textBox3.Margin = new Padding(5);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(318, 40);
            textBox3.TabIndex = 23;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.DarkOrange;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(531, 548);
            button2.Name = "button2";
            button2.Padding = new Padding(10);
            button2.Size = new Size(322, 55);
            button2.TabIndex = 10;
            button2.Text = "Guardar Cambios";
            button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(719, 267);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 24;
            label6.Text = "Apellido";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.None;
            textBox7.Cursor = Cursors.Hand;
            textBox7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(719, 296);
            textBox7.Margin = new Padding(5);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(318, 40);
            textBox7.TabIndex = 25;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Cursor = Cursors.Hand;
            textBox5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(354, 296);
            textBox5.Margin = new Padding(5);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(322, 40);
            textBox5.TabIndex = 11;
            // 
            // textBox9
            // 
            textBox9.Anchor = AnchorStyles.None;
            textBox9.Cursor = Cursors.Hand;
            textBox9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(719, 389);
            textBox9.Margin = new Padding(5);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(318, 40);
            textBox9.TabIndex = 26;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(353, 360);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 14;
            label5.Text = "Nickname";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.None;
            textBox8.Cursor = Cursors.Hand;
            textBox8.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(1054, 393);
            textBox8.Margin = new Padding(5);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(0, 31);
            textBox8.TabIndex = 27;
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Cursor = Cursors.Hand;
            textBox6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(354, 389);
            textBox6.Margin = new Padding(5);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(322, 40);
            textBox6.TabIndex = 15;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(720, 363);
            label7.Name = "label7";
            label7.Size = new Size(54, 25);
            label7.TabIndex = 28;
            label7.Text = "Email";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = new Size(800, 600);
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(a);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 80, 0, 60);
            panel1.Size = new Size(1366, 768);
            panel1.TabIndex = 1;
            // 
            // SettingsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Margin = new Padding(100);
            Name = "SettingsUserControl";
            Size = new Size(1366, 768);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label a;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private Button button2;
        private Label label6;
        private TextBox textBox7;
        private TextBox textBox5;
        private TextBox textBox9;
        private Label label5;
        private TextBox textBox8;
        private TextBox textBox6;
        private Label label7;
        private Panel panel1;
    }
}
