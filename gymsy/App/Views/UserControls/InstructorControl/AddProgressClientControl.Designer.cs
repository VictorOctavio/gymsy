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
            PictureBoxImg = new PictureBox();
            BtnAddImgProgress = new ClassCustom.RJButton();
            label13 = new Label();
            LbErrImage = new Label();
            LbErrPeso = new Panel();
            labelError = new Label();
            label6 = new Label();
            TbTitle = new CustomControls.RJControls.RJTextBox();
            label4 = new Label();
            TbNotes = new CustomControls.RJControls.RJTextBox();
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
            ((System.ComponentModel.ISupportInitialize)PictureBoxImg).BeginInit();
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
            PanelAddProgress.Margin = new Padding(3, 4, 3, 4);
            PanelAddProgress.Name = "PanelAddProgress";
            PanelAddProgress.Size = new Size(1029, 733);
            PanelAddProgress.TabIndex = 52;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(PictureBoxImg);
            panel1.Controls.Add(BtnAddImgProgress);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(LbErrImage);
            panel1.Location = new Point(553, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 725);
            panel1.TabIndex = 72;
            // 
            // PictureBoxImg
            // 
            PictureBoxImg.BorderStyle = BorderStyle.FixedSingle;
            PictureBoxImg.Image = (Image)resources.GetObject("PictureBoxImg.Image");
            PictureBoxImg.InitialImage = (Image)resources.GetObject("PictureBoxImg.InitialImage");
            PictureBoxImg.Location = new Point(93, 151);
            PictureBoxImg.Margin = new Padding(3, 4, 3, 4);
            PictureBoxImg.Name = "PictureBoxImg";
            PictureBoxImg.Size = new Size(251, 371);
            PictureBoxImg.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxImg.TabIndex = 67;
            PictureBoxImg.TabStop = false;
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
            BtnAddImgProgress.Location = new Point(121, 541);
            BtnAddImgProgress.Margin = new Padding(3, 4, 3, 4);
            BtnAddImgProgress.Name = "BtnAddImgProgress";
            BtnAddImgProgress.Padding = new Padding(11, 0, 11, 0);
            BtnAddImgProgress.Size = new Size(202, 51);
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
            label13.Location = new Point(174, 77);
            label13.Name = "label13";
            label13.Size = new Size(117, 32);
            label13.TabIndex = 52;
            label13.Text = "Imagenes";
            // 
            // LbErrImage
            // 
            LbErrImage.Anchor = AnchorStyles.None;
            LbErrImage.AutoSize = true;
            LbErrImage.ForeColor = Color.Red;
            LbErrImage.Location = new Point(160, 603);
            LbErrImage.Name = "LbErrImage";
            LbErrImage.Size = new Size(132, 20);
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
            LbErrPeso.Controls.Add(TbNotes);
            LbErrPeso.Controls.Add(label3);
            LbErrPeso.Controls.Add(label1);
            LbErrPeso.Controls.Add(TbPeso);
            LbErrPeso.Controls.Add(label10);
            LbErrPeso.Controls.Add(TbAltura);
            LbErrPeso.Controls.Add(LbErrAltura);
            LbErrPeso.Controls.Add(BtnSaveProgress);
            LbErrPeso.Controls.Add(LbErrTitle);
            LbErrPeso.Controls.Add(label5);
            LbErrPeso.Location = new Point(3, 4);
            LbErrPeso.Margin = new Padding(3, 4, 3, 4);
            LbErrPeso.Name = "LbErrPeso";
            LbErrPeso.Size = new Size(543, 725);
            LbErrPeso.TabIndex = 73;
            // 
            // labelError
            // 
            labelError.Anchor = AnchorStyles.None;
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(177, 663);
            labelError.Name = "labelError";
            labelError.Size = new Size(174, 28);
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
            label6.Location = new Point(162, 423);
            label6.Name = "label6";
            label6.Size = new Size(64, 28);
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
            TbTitle.Location = new Point(162, 172);
            TbTitle.Margin = new Padding(5, 5, 5, 5);
            TbTitle.Multiline = false;
            TbTitle.Name = "TbTitle";
            TbTitle.Padding = new Padding(11, 9, 11, 9);
            TbTitle.PasswordChar = false;
            TbTitle.PlaceholderColor = Color.DarkGray;
            TbTitle.PlaceholderText = "Ingrese un titulo...";
            TbTitle.ReadOnly = false;
            TbTitle.Size = new Size(321, 39);
            TbTitle.TabIndex = 67;
            TbTitle.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(162, 323);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 74;
            label4.Text = "Altura Actual";
            // 
            // TbNotes
            // 
            TbNotes.Anchor = AnchorStyles.None;
            TbNotes.BackColor = Color.FromArgb(69, 34, 99);
            TbNotes.BorderColor = Color.Transparent;
            TbNotes.BorderFocusColor = Color.HotPink;
            TbNotes.BorderRadius = 15;
            TbNotes.BorderSize = 2;
            TbNotes.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TbNotes.ForeColor = Color.FromArgb(230, 237, 243);
            TbNotes.Location = new Point(162, 456);
            TbNotes.Margin = new Padding(5, 5, 5, 5);
            TbNotes.Multiline = true;
            TbNotes.Name = "TbNotes";
            TbNotes.Padding = new Padding(11, 9, 11, 9);
            TbNotes.PasswordChar = false;
            TbNotes.PlaceholderColor = Color.DarkGray;
            TbNotes.PlaceholderText = "Ingrese notas...";
            TbNotes.ReadOnly = false;
            TbNotes.Size = new Size(321, 109);
            TbNotes.TabIndex = 70;
            TbNotes.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(162, 231);
            label3.Name = "label3";
            label3.Size = new Size(112, 28);
            label3.TabIndex = 73;
            label3.Text = "Peso Actual";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(165, 140);
            label1.Name = "label1";
            label1.Size = new Size(62, 28);
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
            TbPeso.Location = new Point(162, 264);
            TbPeso.Margin = new Padding(5, 5, 5, 5);
            TbPeso.Multiline = false;
            TbPeso.Name = "TbPeso";
            TbPeso.Padding = new Padding(11, 9, 11, 9);
            TbPeso.PasswordChar = false;
            TbPeso.PlaceholderColor = Color.DarkGray;
            TbPeso.PlaceholderText = "Ingrese un peso...";
            TbPeso.ReadOnly = false;
            TbPeso.Size = new Size(321, 39);
            TbPeso.TabIndex = 68;
            TbPeso.UnderlinedStyle = false;
            TbPeso.KeyPress += JustNumber_KeyPress;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(229, 64);
            label10.Name = "label10";
            label10.Size = new Size(262, 46);
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
            TbAltura.Location = new Point(162, 356);
            TbAltura.Margin = new Padding(5, 5, 5, 5);
            TbAltura.Multiline = false;
            TbAltura.Name = "TbAltura";
            TbAltura.Padding = new Padding(11, 9, 11, 9);
            TbAltura.PasswordChar = false;
            TbAltura.PlaceholderColor = Color.DarkGray;
            TbAltura.PlaceholderText = "Ingrese altura...";
            TbAltura.ReadOnly = false;
            TbAltura.Size = new Size(321, 39);
            TbAltura.TabIndex = 69;
            TbAltura.UnderlinedStyle = false;
            TbAltura.KeyPress += JustNumber_KeyPress;
            // 
            // LbErrAltura
            // 
            LbErrAltura.Anchor = AnchorStyles.None;
            LbErrAltura.AutoSize = true;
            LbErrAltura.ForeColor = Color.Red;
            LbErrAltura.Location = new Point(363, 331);
            LbErrAltura.Name = "LbErrAltura";
            LbErrAltura.Size = new Size(132, 20);
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
            BtnSaveProgress.Location = new Point(192, 588);
            BtnSaveProgress.Margin = new Padding(3, 4, 3, 4);
            BtnSaveProgress.Name = "BtnSaveProgress";
            BtnSaveProgress.Padding = new Padding(11, 0, 0, 0);
            BtnSaveProgress.Size = new Size(254, 53);
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
            LbErrTitle.Location = new Point(363, 147);
            LbErrTitle.Name = "LbErrTitle";
            LbErrTitle.Size = new Size(132, 20);
            LbErrTitle.TabIndex = 37;
            LbErrTitle.Text = "*Campo requerido";
            LbErrTitle.Visible = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(363, 239);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 40;
            label5.Text = "*Campo requerido";
            label5.Visible = false;
            // 
            // AddProgressClientControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelAddProgress);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddProgressClientControl";
            Size = new Size(1029, 733);
            PanelAddProgress.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxImg).EndInit();
            LbErrPeso.ResumeLayout(false);
            LbErrPeso.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelAddProgress;
        private CustomControls.RJControls.RJTextBox TbNotes;
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
        private PictureBox PictureBoxImg;
        private Label labelError;
    }
}
