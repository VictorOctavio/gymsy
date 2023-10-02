namespace gymsy.App.Views.UserControls.ClientControls
{
    partial class AddProgressClientControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProgressClientControl));
            PanelAddProgress = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            BtnAddImgProgress = new ClassCustom.RJButton();
            label13 = new Label();
            LbErrImage = new Label();
            LbErrPeso = new Panel();
            labelError = new Label();
            label6 = new Label();
            TbTitle = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            label1 = new Label();
            TbPeso = new CustomControls.RJControls.RJTextBox();
            label10 = new Label();
            TbAltura = new CustomControls.RJControls.RJTextBox();
            LbErrAltura = new Label();
            BtnSaveProgress = new ClassCustom.RJButton();
            LbErrTitle = new Label();
            label5 = new Label();
            PanelAddProgress.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            LbErrPeso.SuspendLayout();
            SuspendLayout();
            // 
            // PanelAddProgress
            // 
            PanelAddProgress.BackColor = Color.FromArgb(16, 8, 23);
            PanelAddProgress.Controls.Add(panel1);
            PanelAddProgress.Controls.Add(LbErrPeso);
            PanelAddProgress.Dock = DockStyle.Fill;
            PanelAddProgress.Location = new Point(0, 0);
            PanelAddProgress.Name = "PanelAddProgress";
            PanelAddProgress.Size = new Size(900, 550);
            PanelAddProgress.TabIndex = 52;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BtnAddImgProgress);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(LbErrImage);
            panel1.Location = new Point(484, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 544);
            panel1.TabIndex = 72;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(81, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // BtnAddImgProgress
            // 
            BtnAddImgProgress.Anchor = AnchorStyles.None;
            BtnAddImgProgress.BackColor = Color.DarkCyan;
            BtnAddImgProgress.BackgroundColor = Color.DarkCyan;
            BtnAddImgProgress.BorderColor = Color.PaleVioletRed;
            BtnAddImgProgress.BorderRadius = 10;
            BtnAddImgProgress.BorderSize = 0;
            BtnAddImgProgress.Cursor = Cursors.Hand;
            BtnAddImgProgress.FlatAppearance.BorderSize = 0;
            BtnAddImgProgress.FlatStyle = FlatStyle.Flat;
            BtnAddImgProgress.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            BtnAddImgProgress.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddImgProgress.ForeColor = Color.White;
            BtnAddImgProgress.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            BtnAddImgProgress.IconColor = Color.FromArgb(230, 237, 243);
            BtnAddImgProgress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAddImgProgress.IconSize = 30;
            BtnAddImgProgress.ImageAlign = ContentAlignment.MiddleRight;
            BtnAddImgProgress.Location = new Point(106, 406);
            BtnAddImgProgress.Name = "BtnAddImgProgress";
            BtnAddImgProgress.Padding = new Padding(10, 0, 10, 0);
            BtnAddImgProgress.Size = new Size(177, 38);
            BtnAddImgProgress.TabIndex = 66;
            BtnAddImgProgress.Text = "Agregar Imagen";
            BtnAddImgProgress.TextAlign = ContentAlignment.MiddleLeft;
            BtnAddImgProgress.TextColor = Color.White;
            BtnAddImgProgress.UseVisualStyleBackColor = false;
            BtnAddImgProgress.Click += BtnAddImgProgress_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(230, 237, 243);
            label13.Location = new Point(152, 58);
            label13.Name = "label13";
            label13.Size = new Size(93, 25);
            label13.TabIndex = 52;
            label13.Text = "Imagenes";
            // 
            // LbErrImage
            // 
            LbErrImage.Anchor = AnchorStyles.None;
            LbErrImage.AutoSize = true;
            LbErrImage.ForeColor = Color.Red;
            LbErrImage.Location = new Point(140, 452);
            LbErrImage.Name = "LbErrImage";
            LbErrImage.Size = new Size(105, 15);
            LbErrImage.TabIndex = 49;
            LbErrImage.Text = "*Campo requerido";
            LbErrImage.Visible = false;
            // 
            // LbErrPeso
            // 
            LbErrPeso.Anchor = AnchorStyles.None;
            LbErrPeso.Controls.Add(labelError);
            LbErrPeso.Controls.Add(label6);
            LbErrPeso.Controls.Add(TbTitle);
            LbErrPeso.Controls.Add(label4);
            LbErrPeso.Controls.Add(rjTextBox4);
            LbErrPeso.Controls.Add(label3);
            LbErrPeso.Controls.Add(label1);
            LbErrPeso.Controls.Add(TbPeso);
            LbErrPeso.Controls.Add(label10);
            LbErrPeso.Controls.Add(TbAltura);
            LbErrPeso.Controls.Add(LbErrAltura);
            LbErrPeso.Controls.Add(BtnSaveProgress);
            LbErrPeso.Controls.Add(LbErrTitle);
            LbErrPeso.Controls.Add(label5);
            LbErrPeso.Location = new Point(3, 3);
            LbErrPeso.Name = "LbErrPeso";
            LbErrPeso.Size = new Size(475, 544);
            LbErrPeso.TabIndex = 73;
            // 
            // labelError
            // 
            labelError.Anchor = AnchorStyles.None;
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(155, 497);
            labelError.Name = "labelError";
            labelError.Size = new Size(139, 21);
            labelError.TabIndex = 76;
            labelError.Text = "*Campo requerido";
            labelError.Visible = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(142, 317);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 75;
            label6.Text = "Notas";
            // 
            // TbTitle
            // 
            TbTitle.Anchor = AnchorStyles.None;
            TbTitle.BackColor = Color.FromArgb(69, 34, 99);
            TbTitle.BorderColor = Color.Transparent;
            TbTitle.BorderFocusColor = Color.HotPink;
            TbTitle.BorderRadius = 15;
            TbTitle.BorderSize = 2;
            TbTitle.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TbTitle.ForeColor = Color.FromArgb(230, 237, 243);
            TbTitle.Location = new Point(142, 129);
            TbTitle.Margin = new Padding(4);
            TbTitle.Multiline = false;
            TbTitle.Name = "TbTitle";
            TbTitle.Padding = new Padding(10, 7, 10, 7);
            TbTitle.PasswordChar = false;
            TbTitle.PlaceholderColor = Color.DarkGray;
            TbTitle.PlaceholderText = "Ingrese un titulo...";
            TbTitle.Size = new Size(281, 31);
            TbTitle.TabIndex = 67;
            TbTitle.Texts = "";
            TbTitle.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(142, 242);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 74;
            label4.Text = "Altura Actual";
            // 
            // rjTextBox4
            // 
            rjTextBox4.Anchor = AnchorStyles.None;
            rjTextBox4.BackColor = Color.FromArgb(69, 34, 99);
            rjTextBox4.BorderColor = Color.Transparent;
            rjTextBox4.BorderFocusColor = Color.HotPink;
            rjTextBox4.BorderRadius = 15;
            rjTextBox4.BorderSize = 2;
            rjTextBox4.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox4.ForeColor = Color.FromArgb(230, 237, 243);
            rjTextBox4.Location = new Point(142, 342);
            rjTextBox4.Margin = new Padding(4);
            rjTextBox4.Multiline = true;
            rjTextBox4.Name = "rjTextBox4";
            rjTextBox4.Padding = new Padding(10, 7, 10, 7);
            rjTextBox4.PasswordChar = false;
            rjTextBox4.PlaceholderColor = Color.DarkGray;
            rjTextBox4.PlaceholderText = "Ingrese notas...";
            rjTextBox4.Size = new Size(281, 82);
            rjTextBox4.TabIndex = 70;
            rjTextBox4.Texts = "";
            rjTextBox4.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(142, 173);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 73;
            label3.Text = "Peso Actual";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(144, 105);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 72;
            label1.Text = "Titulo";
            // 
            // TbPeso
            // 
            TbPeso.Anchor = AnchorStyles.None;
            TbPeso.BackColor = Color.FromArgb(69, 34, 99);
            TbPeso.BorderColor = Color.Transparent;
            TbPeso.BorderFocusColor = Color.HotPink;
            TbPeso.BorderRadius = 15;
            TbPeso.BorderSize = 2;
            TbPeso.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TbPeso.ForeColor = Color.FromArgb(230, 237, 243);
            TbPeso.Location = new Point(142, 198);
            TbPeso.Margin = new Padding(4);
            TbPeso.Multiline = false;
            TbPeso.Name = "TbPeso";
            TbPeso.Padding = new Padding(10, 7, 10, 7);
            TbPeso.PasswordChar = false;
            TbPeso.PlaceholderColor = Color.DarkGray;
            TbPeso.PlaceholderText = "Ingrese un peso...";
            TbPeso.Size = new Size(281, 31);
            TbPeso.TabIndex = 68;
            TbPeso.Texts = "";
            TbPeso.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(200, 48);
            label10.Name = "label10";
            label10.Size = new Size(208, 37);
            label10.TabIndex = 48;
            label10.Text = "Nuevo Progreso";
            // 
            // TbAltura
            // 
            TbAltura.Anchor = AnchorStyles.None;
            TbAltura.BackColor = Color.FromArgb(69, 34, 99);
            TbAltura.BorderColor = Color.Transparent;
            TbAltura.BorderFocusColor = Color.HotPink;
            TbAltura.BorderRadius = 15;
            TbAltura.BorderSize = 2;
            TbAltura.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TbAltura.ForeColor = Color.FromArgb(230, 237, 243);
            TbAltura.Location = new Point(142, 267);
            TbAltura.Margin = new Padding(4);
            TbAltura.Multiline = false;
            TbAltura.Name = "TbAltura";
            TbAltura.Padding = new Padding(10, 7, 10, 7);
            TbAltura.PasswordChar = false;
            TbAltura.PlaceholderColor = Color.DarkGray;
            TbAltura.PlaceholderText = "Ingrese altura...";
            TbAltura.Size = new Size(281, 31);
            TbAltura.TabIndex = 69;
            TbAltura.Texts = "";
            TbAltura.UnderlinedStyle = false;
            // 
            // LbErrAltura
            // 
            LbErrAltura.Anchor = AnchorStyles.None;
            LbErrAltura.AutoSize = true;
            LbErrAltura.ForeColor = Color.Red;
            LbErrAltura.Location = new Point(318, 248);
            LbErrAltura.Name = "LbErrAltura";
            LbErrAltura.Size = new Size(105, 15);
            LbErrAltura.TabIndex = 43;
            LbErrAltura.Text = "*Campo requerido";
            LbErrAltura.Visible = false;
            // 
            // BtnSaveProgress
            // 
            BtnSaveProgress.Anchor = AnchorStyles.None;
            BtnSaveProgress.BackColor = Color.DarkCyan;
            BtnSaveProgress.BackgroundColor = Color.DarkCyan;
            BtnSaveProgress.BorderColor = Color.PaleVioletRed;
            BtnSaveProgress.BorderRadius = 10;
            BtnSaveProgress.BorderSize = 0;
            BtnSaveProgress.Cursor = Cursors.Hand;
            BtnSaveProgress.FlatAppearance.BorderSize = 0;
            BtnSaveProgress.FlatStyle = FlatStyle.Flat;
            BtnSaveProgress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSaveProgress.ForeColor = Color.White;
            BtnSaveProgress.IconChar = FontAwesome.Sharp.IconChar.Yammer;
            BtnSaveProgress.IconColor = Color.FromArgb(230, 237, 243);
            BtnSaveProgress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSaveProgress.IconSize = 1;
            BtnSaveProgress.ImageAlign = ContentAlignment.MiddleRight;
            BtnSaveProgress.Location = new Point(168, 441);
            BtnSaveProgress.Name = "BtnSaveProgress";
            BtnSaveProgress.Padding = new Padding(10, 0, 0, 0);
            BtnSaveProgress.Size = new Size(222, 40);
            BtnSaveProgress.TabIndex = 71;
            BtnSaveProgress.Text = "Guardar Progreso";
            BtnSaveProgress.TextColor = Color.White;
            BtnSaveProgress.UseVisualStyleBackColor = false;
            BtnSaveProgress.Click += BtnSaveProgress_Click;
            // 
            // LbErrTitle
            // 
            LbErrTitle.Anchor = AnchorStyles.None;
            LbErrTitle.AutoSize = true;
            LbErrTitle.ForeColor = Color.Red;
            LbErrTitle.Location = new Point(318, 110);
            LbErrTitle.Name = "LbErrTitle";
            LbErrTitle.Size = new Size(105, 15);
            LbErrTitle.TabIndex = 37;
            LbErrTitle.Text = "*Campo requerido";
            LbErrTitle.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(318, 179);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 40;
            label5.Text = "*Campo requerido";
            label5.Visible = false;
            // 
            // AddProgressClientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelAddProgress);
            Name = "AddProgressClientControl";
            Size = new Size(900, 550);
            PanelAddProgress.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            LbErrPeso.ResumeLayout(false);
            LbErrPeso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAddProgress;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private CustomControls.RJControls.RJTextBox TbAltura;
        private CustomControls.RJControls.RJTextBox TbPeso;
        private CustomControls.RJControls.RJTextBox TbTitle;
        private ClassCustom.RJButton BtnAddImgProgress;
        private Label label13;
        private Label label10;
        private Label LbErrImage;
        private Label LbErrTitle;
        private Label LbErrAltura;
        private Label label5;
        private ClassCustom.RJButton BtnSaveProgress;
        private Panel panel1;
        private Panel LbErrPeso;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label labelError;
    }
}
