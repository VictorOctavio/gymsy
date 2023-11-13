namespace gymsy.UserControls.ClientControls
{
    partial class AboutClientControl
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            LbRegistros = new Label();
            label3 = new Label();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            LbCuotaExp = new Label();
            LbPlanActual = new Label();
            LbTimeActivo = new Label();
            PanelInvoiceWallet = new Panel();
            PictureBoxAvatar = new PictureBox();
            panel2 = new Panel();
            label8 = new Label();
            BeforeIngreso = new Label();
            LbName = new Label();
            label7 = new Label();
            LbIngreso = new Label();
            BeforeAltura = new Label();
            label6 = new Label();
            BtnDownload = new ClassCustom.RJButton();
            LbAltura = new Label();
            rjButton1 = new ClassCustom.RJButton();
            label5 = new Label();
            BeforePeso = new Label();
            LbPeso = new Label();
            rjButton2 = new ClassCustom.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelInvoiceWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAvatar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LbRegistros);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(LbCuotaExp);
            panel1.Controls.Add(LbPlanActual);
            panel1.Controls.Add(LbTimeActivo);
            panel1.Controls.Add(PanelInvoiceWallet);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 424);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.FromArgb(16, 8, 30);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = Properties.Resources._6f76e01a03ae8f111c6fc392404f5d66;
            pictureBox1.InitialImage = Properties.Resources._6f76e01a03ae8f111c6fc392404f5d66;
            pictureBox1.Location = new Point(22, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 65;
            pictureBox1.TabStop = false;
            // 
            // LbRegistros
            // 
            LbRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LbRegistros.AutoSize = true;
            LbRegistros.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LbRegistros.ForeColor = Color.White;
            LbRegistros.ImageAlign = ContentAlignment.MiddleLeft;
            LbRegistros.Location = new Point(148, 264);
            LbRegistros.Name = "LbRegistros";
            LbRegistros.Size = new Size(75, 25);
            LbRegistros.TabIndex = 58;
            LbRegistros.Text = "23 años";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(45, 21);
            label3.Name = "label3";
            label3.Size = new Size(145, 37);
            label3.TabIndex = 7;
            label3.Text = "Mis Datos";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.ImageAlign = ContentAlignment.MiddleLeft;
            label9.Location = new Point(22, 264);
            label9.Name = "label9";
            label9.Size = new Size(94, 25);
            label9.TabIndex = 57;
            label9.Text = "Registros: ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(22, 375);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 55;
            label1.Text = "Cuota Expira: ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(22, 338);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 54;
            label2.Text = "Plan Actual:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(22, 298);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 53;
            label4.Text = "Tiempo:";
            // 
            // LbCuotaExp
            // 
            LbCuotaExp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LbCuotaExp.AutoSize = true;
            LbCuotaExp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LbCuotaExp.ForeColor = Color.White;
            LbCuotaExp.ImageAlign = ContentAlignment.MiddleLeft;
            LbCuotaExp.Location = new Point(148, 375);
            LbCuotaExp.Name = "LbCuotaExp";
            LbCuotaExp.Size = new Size(69, 25);
            LbCuotaExp.TabIndex = 14;
            LbCuotaExp.Text = "15 dias";
            // 
            // LbPlanActual
            // 
            LbPlanActual.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LbPlanActual.AutoSize = true;
            LbPlanActual.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LbPlanActual.ForeColor = Color.White;
            LbPlanActual.ImageAlign = ContentAlignment.MiddleLeft;
            LbPlanActual.Location = new Point(145, 338);
            LbPlanActual.Name = "LbPlanActual";
            LbPlanActual.Size = new Size(91, 25);
            LbPlanActual.TabIndex = 13;
            LbPlanActual.Text = "Avanzado";
            // 
            // LbTimeActivo
            // 
            LbTimeActivo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            LbTimeActivo.AutoSize = true;
            LbTimeActivo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LbTimeActivo.ForeColor = Color.White;
            LbTimeActivo.ImageAlign = ContentAlignment.MiddleLeft;
            LbTimeActivo.Location = new Point(145, 298);
            LbTimeActivo.Name = "LbTimeActivo";
            LbTimeActivo.Size = new Size(77, 25);
            LbTimeActivo.TabIndex = 12;
            LbTimeActivo.Text = "6 meses";
            // 
            // PanelInvoiceWallet
            // 
            PanelInvoiceWallet.AutoSize = true;
            PanelInvoiceWallet.BackColor = Color.Transparent;
            PanelInvoiceWallet.BorderStyle = BorderStyle.FixedSingle;
            PanelInvoiceWallet.Controls.Add(PictureBoxAvatar);
            PanelInvoiceWallet.Dock = DockStyle.Top;
            PanelInvoiceWallet.Location = new Point(0, 0);
            PanelInvoiceWallet.Margin = new Padding(0);
            PanelInvoiceWallet.Name = "PanelInvoiceWallet";
            PanelInvoiceWallet.Size = new Size(257, 2);
            PanelInvoiceWallet.TabIndex = 63;
            PanelInvoiceWallet.Visible = false;
            // 
            // PictureBoxAvatar
            // 
            PictureBoxAvatar.Dock = DockStyle.Left;
            PictureBoxAvatar.Image = Properties.Resources.gorilla_avatar;
            PictureBoxAvatar.Location = new Point(0, 0);
            PictureBoxAvatar.Name = "PictureBoxAvatar";
            PictureBoxAvatar.Size = new Size(218, 0);
            PictureBoxAvatar.TabIndex = 59;
            PictureBoxAvatar.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 8, 30);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(BeforeIngreso);
            panel2.Controls.Add(LbName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(LbIngreso);
            panel2.Controls.Add(BeforeAltura);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(BtnDownload);
            panel2.Controls.Add(LbAltura);
            panel2.Controls.Add(rjButton1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(BeforePeso);
            panel2.Controls.Add(LbPeso);
            panel2.Controls.Add(rjButton2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(257, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 424);
            panel2.TabIndex = 64;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(20, 21);
            label8.Name = "label8";
            label8.Size = new Size(191, 28);
            label8.TabIndex = 63;
            label8.Text = "Nombre y Apellido";
            // 
            // BeforeIngreso
            // 
            BeforeIngreso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BeforeIngreso.AutoSize = true;
            BeforeIngreso.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BeforeIngreso.ForeColor = Color.White;
            BeforeIngreso.ImageAlign = ContentAlignment.MiddleLeft;
            BeforeIngreso.Location = new Point(155, 224);
            BeforeIngreso.Name = "BeforeIngreso";
            BeforeIngreso.Size = new Size(19, 25);
            BeforeIngreso.TabIndex = 62;
            BeforeIngreso.Text = "-";
            // 
            // LbName
            // 
            LbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LbName.AutoSize = true;
            LbName.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LbName.ForeColor = Color.White;
            LbName.ImageAlign = ContentAlignment.MiddleLeft;
            LbName.Location = new Point(240, 21);
            LbName.Name = "LbName";
            LbName.Size = new Size(145, 28);
            LbName.TabIndex = 8;
            LbName.Text = "Julian Alvarez";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(20, 140);
            label7.Name = "label7";
            label7.Size = new Size(53, 25);
            label7.TabIndex = 50;
            label7.Text = "Peso:";
            // 
            // LbIngreso
            // 
            LbIngreso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LbIngreso.AutoSize = true;
            LbIngreso.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LbIngreso.ForeColor = Color.White;
            LbIngreso.ImageAlign = ContentAlignment.MiddleLeft;
            LbIngreso.Location = new Point(299, 224);
            LbIngreso.Name = "LbIngreso";
            LbIngreso.Size = new Size(19, 25);
            LbIngreso.TabIndex = 11;
            LbIngreso.Text = "-";
            // 
            // BeforeAltura
            // 
            BeforeAltura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BeforeAltura.AutoSize = true;
            BeforeAltura.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BeforeAltura.ForeColor = Color.White;
            BeforeAltura.ImageAlign = ContentAlignment.MiddleLeft;
            BeforeAltura.Location = new Point(155, 180);
            BeforeAltura.Name = "BeforeAltura";
            BeforeAltura.Size = new Size(19, 25);
            BeforeAltura.TabIndex = 61;
            BeforeAltura.Text = "-";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(19, 180);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 51;
            label6.Text = "Altura: ";
            // 
            // BtnDownload
            // 
            BtnDownload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnDownload.BackColor = Color.DarkCyan;
            BtnDownload.BackgroundColor = Color.DarkCyan;
            BtnDownload.BorderColor = Color.PaleVioletRed;
            BtnDownload.BorderRadius = 12;
            BtnDownload.BorderSize = 0;
            BtnDownload.Cursor = Cursors.Hand;
            BtnDownload.FlatAppearance.BorderSize = 0;
            BtnDownload.FlatStyle = FlatStyle.Flat;
            BtnDownload.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDownload.ForeColor = Color.White;
            BtnDownload.IconChar = FontAwesome.Sharp.IconChar.Download;
            BtnDownload.IconColor = Color.White;
            BtnDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnDownload.IconSize = 30;
            BtnDownload.ImageAlign = ContentAlignment.MiddleRight;
            BtnDownload.Location = new Point(279, 375);
            BtnDownload.Margin = new Padding(0);
            BtnDownload.Name = "BtnDownload";
            BtnDownload.Padding = new Padding(10, 0, 10, 0);
            BtnDownload.Size = new Size(150, 35);
            BtnDownload.TabIndex = 47;
            BtnDownload.Text = "Descargar";
            BtnDownload.TextAlign = ContentAlignment.MiddleLeft;
            BtnDownload.TextColor = Color.White;
            BtnDownload.UseVisualStyleBackColor = false;
            BtnDownload.Visible = false;
            // 
            // LbAltura
            // 
            LbAltura.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LbAltura.AutoSize = true;
            LbAltura.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LbAltura.ForeColor = Color.White;
            LbAltura.ImageAlign = ContentAlignment.MiddleLeft;
            LbAltura.Location = new Point(299, 180);
            LbAltura.Name = "LbAltura";
            LbAltura.Size = new Size(19, 25);
            LbAltura.TabIndex = 10;
            LbAltura.Text = "-";
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Top;
            rjButton1.BackColor = Color.DarkOrange;
            rjButton1.BackgroundColor = Color.DarkOrange;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 12;
            rjButton1.BorderSize = 0;
            rjButton1.Cursor = Cursors.Hand;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.IconChar = FontAwesome.Sharp.IconChar.Download;
            rjButton1.IconColor = Color.White;
            rjButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton1.IconSize = 1;
            rjButton1.ImageAlign = ContentAlignment.MiddleRight;
            rjButton1.Location = new Point(144, 85);
            rjButton1.Margin = new Padding(0);
            rjButton1.Name = "rjButton1";
            rjButton1.Padding = new Padding(10, 0, 10, 0);
            rjButton1.Size = new Size(111, 37);
            rjButton1.TabIndex = 48;
            rjButton1.Text = "Comienzo";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(20, 224);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 52;
            label5.Text = "Ingreso: ";
            // 
            // BeforePeso
            // 
            BeforePeso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            BeforePeso.AutoSize = true;
            BeforePeso.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BeforePeso.ForeColor = Color.White;
            BeforePeso.ImageAlign = ContentAlignment.MiddleLeft;
            BeforePeso.Location = new Point(155, 140);
            BeforePeso.Name = "BeforePeso";
            BeforePeso.Size = new Size(19, 25);
            BeforePeso.TabIndex = 60;
            BeforePeso.Text = "-";
            // 
            // LbPeso
            // 
            LbPeso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            LbPeso.AutoSize = true;
            LbPeso.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            LbPeso.ForeColor = Color.White;
            LbPeso.ImageAlign = ContentAlignment.MiddleLeft;
            LbPeso.Location = new Point(299, 140);
            LbPeso.Name = "LbPeso";
            LbPeso.Size = new Size(19, 25);
            LbPeso.TabIndex = 9;
            LbPeso.Text = "-";
            // 
            // rjButton2
            // 
            rjButton2.Anchor = AnchorStyles.Top;
            rjButton2.BackColor = Color.DarkCyan;
            rjButton2.BackgroundColor = Color.DarkCyan;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 12;
            rjButton2.BorderSize = 0;
            rjButton2.Cursor = Cursors.Hand;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.White;
            rjButton2.IconChar = FontAwesome.Sharp.IconChar.Download;
            rjButton2.IconColor = Color.White;
            rjButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton2.IconSize = 1;
            rjButton2.ImageAlign = ContentAlignment.MiddleRight;
            rjButton2.Location = new Point(279, 85);
            rjButton2.Margin = new Padding(0);
            rjButton2.Name = "rjButton2";
            rjButton2.Padding = new Padding(10, 0, 10, 0);
            rjButton2.Size = new Size(106, 37);
            rjButton2.TabIndex = 49;
            rjButton2.Text = "Ahora";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // AboutClientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 8, 23);
            Controls.Add(panel1);
            Name = "AboutClientControl";
            Size = new Size(700, 424);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelInvoiceWallet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBoxAvatar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LbTimeActivo;
        private Label LbName;
        private Label LbPlanActual;
        private Label LbCuotaExp;
        private ClassCustom.RJButton BtnDownload;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label LbRegistros;
        private Label label9;
        private Panel PanelInvoiceWallet;
        private Label BeforeIngreso;
        private Label label3;
        private Label BeforeAltura;
        private ClassCustom.RJButton rjButton1;
        private Label BeforePeso;
        private ClassCustom.RJButton rjButton2;
        private PictureBox PictureBoxAvatar;
        private Label LbPeso;
        private Label LbAltura;
        private Label LbIngreso;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label8;
    }
}
