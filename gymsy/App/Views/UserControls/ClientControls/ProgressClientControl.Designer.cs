namespace gymsy.UserControls.ClientControls
{
    partial class ProgressClientControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressClientControl));
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            panel6 = new Panel();
            panelWalletWrapper = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            textBox1 = new TextBox();
            label6 = new Label();
            panelGallery = new Panel();
            PhotoActive = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            panel7 = new Panel();
            btnAddProgress = new ClassCustom.RJButton();
            label4 = new Label();
            dataGridProgress = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            gridDate = new DataGridViewTextBoxColumn();
            ShowData = new DataGridViewButtonColumn();
            Peso = new DataGridViewTextBoxColumn();
            gridDescription = new DataGridViewTextBoxColumn();
            panel6.SuspendLayout();
            panelWalletWrapper.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panelGallery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoActive).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProgress).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.Controls.Add(panelWalletWrapper);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(990, 576);
            panel6.TabIndex = 44;
            // 
            // panelWalletWrapper
            // 
            panelWalletWrapper.Controls.Add(panel2);
            panelWalletWrapper.Controls.Add(panel3);
            panelWalletWrapper.Dock = DockStyle.Fill;
            panelWalletWrapper.Location = new Point(0, 0);
            panelWalletWrapper.Name = "panelWalletWrapper";
            panelWalletWrapper.Size = new Size(990, 576);
            panelWalletWrapper.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panelGallery);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(642, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 576);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label6);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(348, 187);
            panel5.TabIndex = 38;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(16, 8, 30);
            textBox1.Location = new Point(5, 83);
            textBox1.Margin = new Padding(10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(338, 104);
            textBox1.TabIndex = 7;
            textBox1.Text = "Descripcion de cuando se tomo estos datos asfasdfasdfasdfsdsfsfdf, do se tomo estos datos asfasdfasdfasdfsdsfsfdf";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(16, 8, 30);
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(67, 32);
            label6.Name = "label6";
            label6.Size = new Size(235, 37);
            label6.TabIndex = 4;
            label6.Text = "Datos 24/55/2021";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelGallery
            // 
            panelGallery.Controls.Add(PhotoActive);
            panelGallery.Dock = DockStyle.Bottom;
            panelGallery.Location = new Point(0, 193);
            panelGallery.Name = "panelGallery";
            panelGallery.Size = new Size(348, 383);
            panelGallery.TabIndex = 43;
            // 
            // PhotoActive
            // 
            PhotoActive.BackColor = Color.FromArgb(16, 8, 30);
            PhotoActive.Dock = DockStyle.Fill;
            PhotoActive.Image = (Image)resources.GetObject("PhotoActive.Image");
            PhotoActive.Location = new Point(0, 0);
            PhotoActive.Name = "PhotoActive";
            PhotoActive.Size = new Size(348, 383);
            PhotoActive.SizeMode = PictureBoxSizeMode.StretchImage;
            PhotoActive.TabIndex = 46;
            PhotoActive.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 8, 23);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(990, 576);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(70, 20);
            label3.Name = "label3";
            label3.Size = new Size(136, 41);
            label3.TabIndex = 3;
            label3.Text = "Pregreso";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-14, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(16, 8, 23);
            textBox2.Enabled = false;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(10, 83);
            textBox2.Margin = new Padding(10);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(633, 60);
            textBox2.TabIndex = 8;
            textBox2.Text = "Cristiano Ronaldo, 37 años comenzo a enrenarse 23/08/2007 (17 años), cuenta con 14 registros guardados ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(16, 8, 23);
            panel7.Controls.Add(btnAddProgress);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(dataGridProgress);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(0, 126);
            panel7.MinimumSize = new Size(0, 450);
            panel7.Name = "panel7";
            panel7.Size = new Size(990, 450);
            panel7.TabIndex = 2;
            // 
            // btnAddProgress
            // 
            btnAddProgress.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddProgress.BackColor = Color.DarkCyan;
            btnAddProgress.BackgroundColor = Color.DarkCyan;
            btnAddProgress.BorderColor = Color.PaleVioletRed;
            btnAddProgress.BorderRadius = 20;
            btnAddProgress.BorderSize = 0;
            btnAddProgress.Cursor = Cursors.Hand;
            btnAddProgress.FlatAppearance.BorderSize = 0;
            btnAddProgress.FlatStyle = FlatStyle.Flat;
            btnAddProgress.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            btnAddProgress.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddProgress.ForeColor = Color.White;
            btnAddProgress.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnAddProgress.IconColor = Color.White;
            btnAddProgress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddProgress.IconSize = 30;
            btnAddProgress.ImageAlign = ContentAlignment.MiddleRight;
            btnAddProgress.Location = new Point(597, 22);
            btnAddProgress.Margin = new Padding(0);
            btnAddProgress.Name = "btnAddProgress";
            btnAddProgress.Size = new Size(40, 40);
            btnAddProgress.TabIndex = 45;
            btnAddProgress.TextAlign = ContentAlignment.BottomLeft;
            btnAddProgress.TextColor = Color.White;
            btnAddProgress.UseVisualStyleBackColor = false;
            btnAddProgress.Click += btnAddProgress_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 24);
            label4.Name = "label4";
            label4.Size = new Size(155, 37);
            label4.TabIndex = 4;
            label4.Text = "Registrados";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridProgress
            // 
            dataGridProgress.AllowUserToAddRows = false;
            dataGridProgress.AllowUserToDeleteRows = false;
            dataGridProgress.AllowUserToResizeColumns = false;
            dataGridProgress.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = Color.Transparent;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridProgress.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridProgress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridProgress.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridProgress.BackgroundColor = Color.FromArgb(16, 8, 30);
            dataGridProgress.CausesValidation = false;
            dataGridProgress.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.Transparent;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridProgress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridProgress.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProgress.Columns.AddRange(new DataGridViewColumn[] { ID, gridDate, ShowData, Peso, gridDescription });
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.False;
            dataGridProgress.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridProgress.GridColor = Color.Black;
            dataGridProgress.Location = new Point(0, 67);
            dataGridProgress.Margin = new Padding(0);
            dataGridProgress.MultiSelect = false;
            dataGridProgress.Name = "dataGridProgress";
            dataGridProgress.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.IndianRed;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.GrayText;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            dataGridProgress.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridProgress.RowHeadersVisible = false;
            dataGridProgress.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle16.BackColor = Color.White;
            dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle16.SelectionBackColor = Color.White;
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dataGridProgress.RowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridProgress.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            dataGridProgress.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridProgress.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridProgress.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridProgress.RowTemplate.Height = 30;
            dataGridProgress.ScrollBars = ScrollBars.None;
            dataGridProgress.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProgress.Size = new Size(700, 383);
            dataGridProgress.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.True;
            ID.Visible = false;
            // 
            // gridDate
            // 
            gridDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.BackColor = Color.Transparent;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle11.SelectionForeColor = Color.Transparent;
            gridDate.DefaultCellStyle = dataGridViewCellStyle11;
            gridDate.HeaderText = "Fecha";
            gridDate.Name = "gridDate";
            gridDate.ReadOnly = true;
            // 
            // ShowData
            // 
            ShowData.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.Cyan;
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.Cyan;
            dataGridViewCellStyle12.SelectionForeColor = Color.Cyan;
            ShowData.DefaultCellStyle = dataGridViewCellStyle12;
            ShowData.HeaderText = "Ver";
            ShowData.Name = "ShowData";
            ShowData.ReadOnly = true;
            ShowData.Text = ".";
            ShowData.ToolTipText = "Ver Detalles";
            ShowData.Width = 40;
            // 
            // Peso
            // 
            Peso.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Peso.HeaderText = "Peso (KG)";
            Peso.Name = "Peso";
            Peso.ReadOnly = true;
            Peso.Width = 120;
            // 
            // gridDescription
            // 
            gridDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle13.BackColor = Color.Transparent;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = Color.Transparent;
            gridDescription.DefaultCellStyle = dataGridViewCellStyle13;
            gridDescription.HeaderText = "Descripcion";
            gridDescription.Name = "gridDescription";
            gridDescription.ReadOnly = true;
            // 
            // ProgressClientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Name = "ProgressClientControl";
            Size = new Size(990, 576);
            panel6.ResumeLayout(false);
            panelWalletWrapper.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panelGallery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PhotoActive).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridProgress).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel6;
        private Panel panelWalletWrapper;
        private Panel panel2;
        private Panel panel5;
        private Label label6;
        private Panel panelGallery;
        private Panel panel3;
        private Label label3;
        private Panel panel7;
        private Label label4;
        private DataGridView dataGridProgress;
        private TextBox textBox1;
        private PictureBox PhotoActive;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn gridDate;
        private DataGridViewButtonColumn ShowData;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn gridDescription;
        private ClassCustom.RJButton btnAddProgress;
        private PictureBox pictureBox1;
    }
}
