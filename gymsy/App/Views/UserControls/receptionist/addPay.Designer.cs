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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addPay));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label14 = new Label();
            label15 = new Label();
            TbTotalAmount = new Label();
            label5 = new Label();
            label2 = new Label();
            TbAmount = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(230, 237, 243);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 262);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(538, 268);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(TbTotalAmount);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(TbAmount);
            panel4.Location = new Point(21, 69);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(517, 168);
            panel4.TabIndex = 5;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkOrange;
            label14.Location = new Point(342, 33);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(42, 21);
            label14.TabIndex = 11;
            label14.Text = "Total";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.Orange;
            label15.Location = new Point(342, 97);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(75, 21);
            label15.TabIndex = 10;
            label15.Text = "Proximo";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TbTotalAmount
            // 
            TbTotalAmount.Anchor = AnchorStyles.Top;
            TbTotalAmount.AutoSize = true;
            TbTotalAmount.Font = new Font("Microsoft Sans Serif", 24.75F, FontStyle.Regular, GraphicsUnit.Point);
            TbTotalAmount.ForeColor = Color.White;
            TbTotalAmount.Location = new Point(333, 61);
            TbTotalAmount.Margin = new Padding(2, 0, 2, 0);
            TbTotalAmount.Name = "TbTotalAmount";
            TbTotalAmount.Size = new Size(152, 38);
            TbTotalAmount.TabIndex = 9;
            TbTotalAmount.Text = "$ 128984";
            TbTotalAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(36, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 8;
            label5.Text = "Disponible";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(36, 116);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 7;
            label2.Text = "ahora";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TbAmount
            // 
            TbAmount.Anchor = AnchorStyles.Top;
            TbAmount.AutoSize = true;
            TbAmount.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            TbAmount.ForeColor = Color.White;
            TbAmount.Location = new Point(27, 47);
            TbAmount.Margin = new Padding(2, 0, 2, 0);
            TbAmount.Name = "TbAmount";
            TbAmount.Size = new Size(244, 61);
            TbAmount.TabIndex = 6;
            TbAmount.Text = "$ 128984";
            TbAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(554, 16);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 494);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(102, 16);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 7;
            label1.Text = "Nuevo Pago";
            // 
            // addPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "addPay";
            Size = new Size(1000, 530);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label14;
        private Label label15;
        private Label TbTotalAmount;
        private Label label5;
        private Label label2;
        private Label TbAmount;
        private Label label1;
        private Panel panel2;
    }
}
