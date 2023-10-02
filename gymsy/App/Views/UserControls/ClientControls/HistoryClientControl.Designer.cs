namespace gymsy.App.Views.UserControls.ClientControls
{
    partial class HistoryClientControl
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryClientControl));
            panel1 = new Panel();
            panelGridInfo = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panelImages = new Panel();
            panelGrid = new Panel();
            dataGridTransactions = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            gridDate = new DataGridViewTextBoxColumn();
            Show = new DataGridViewButtonColumn();
            Peso = new DataGridViewTextBoxColumn();
            gridDescription = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ListImageClient = new ImageList(components);
            panel1.SuspendLayout();
            panelGridInfo.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTransactions).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(panelGridInfo);
            panel1.Controls.Add(panelGrid);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 500);
            panel1.TabIndex = 0;
            // 
            // panelGridInfo
            // 
            panelGridInfo.BackColor = Color.FromArgb(16, 8, 23);
            panelGridInfo.Controls.Add(textBox1);
            panelGridInfo.Controls.Add(label2);
            panelGridInfo.Controls.Add(panelImages);
            panelGridInfo.Dock = DockStyle.Right;
            panelGridInfo.Location = new Point(565, 0);
            panelGridInfo.Name = "panelGridInfo";
            panelGridInfo.Size = new Size(335, 500);
            panelGridInfo.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(16, 8, 23);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(0, 95);
            textBox1.Margin = new Padding(10);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(333, 118);
            textBox1.TabIndex = 5;
            textBox1.Text = "Descripcion de cuando se tomo estos datos asfasdfasdfasdfsdsfsfdf";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 32);
            label2.Name = "label2";
            label2.Size = new Size(205, 37);
            label2.TabIndex = 1;
            label2.Text = "Datos 25/07/20";
            // 
            // panelImages
            // 
            panelImages.Anchor = AnchorStyles.None;
            panelImages.BackColor = Color.FromArgb(255, 192, 192);
            panelImages.Location = new Point(0, 211);
            panelImages.Name = "panelImages";
            panelImages.Size = new Size(332, 289);
            panelImages.TabIndex = 0;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dataGridTransactions);
            panelGrid.Location = new Point(0, 95);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(900, 405);
            panelGrid.TabIndex = 1;
            // 
            // dataGridTransactions
            // 
            dataGridTransactions.AllowUserToOrderColumns = true;
            dataGridTransactions.AllowUserToResizeColumns = false;
            dataGridTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTransactions.BackgroundColor = Color.FromArgb(16, 8, 30);
            dataGridTransactions.CausesValidation = false;
            dataGridTransactions.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTransactions.Columns.AddRange(new DataGridViewColumn[] { ID, gridDate, Show, Peso, gridDescription });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridTransactions.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridTransactions.Dock = DockStyle.Fill;
            dataGridTransactions.GridColor = Color.Black;
            dataGridTransactions.Location = new Point(0, 0);
            dataGridTransactions.Margin = new Padding(0);
            dataGridTransactions.MultiSelect = false;
            dataGridTransactions.Name = "dataGridTransactions";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.IndianRed;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.GrayText;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridTransactions.RowHeadersVisible = false;
            dataGridTransactions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridTransactions.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridTransactions.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            dataGridTransactions.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridTransactions.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridTransactions.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridTransactions.RowTemplate.Height = 30;
            dataGridTransactions.ScrollBars = ScrollBars.None;
            dataGridTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTransactions.ShowCellErrors = false;
            dataGridTransactions.ShowCellToolTips = false;
            dataGridTransactions.ShowEditingIcon = false;
            dataGridTransactions.ShowRowErrors = false;
            dataGridTransactions.Size = new Size(900, 405);
            dataGridTransactions.TabIndex = 3;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Resizable = DataGridViewTriState.True;
            ID.Visible = false;
            // 
            // gridDate
            // 
            gridDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            gridDate.DefaultCellStyle = dataGridViewCellStyle3;
            gridDate.HeaderText = "Fecha";
            gridDate.Name = "gridDate";
            // 
            // Show
            // 
            Show.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Cyan;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Cyan;
            Show.DefaultCellStyle = dataGridViewCellStyle4;
            Show.HeaderText = "Ver";
            Show.Name = "Show";
            Show.Width = 50;
            // 
            // Peso
            // 
            Peso.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Peso.HeaderText = "Peso";
            Peso.Name = "Peso";
            // 
            // gridDescription
            // 
            gridDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.BackColor = Color.Transparent;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Transparent;
            gridDescription.DefaultCellStyle = dataGridViewCellStyle5;
            gridDescription.HeaderText = "Descripcion";
            gridDescription.Name = "gridDescription";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 0;
            label1.Text = "Historial ";
            // 
            // ListImageClient
            // 
            ListImageClient.ColorDepth = ColorDepth.Depth8Bit;
            ListImageClient.ImageStream = (ImageListStreamer)resources.GetObject("ListImageClient.ImageStream");
            ListImageClient.TransparentColor = Color.Black;
            ListImageClient.Images.SetKeyName(0, "cris.jpg");
            ListImageClient.Images.SetKeyName(1, "cris2.jpg");
            // 
            // HistoryClientControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "HistoryClientControl";
            Size = new Size(900, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelGridInfo.ResumeLayout(false);
            panelGridInfo.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelGrid;
        private DataGridView dataGridTransactions;
        private ImageList ListImageClient;
        private Panel panelGridInfo;
        private Panel panelImages;
        private Label label2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn gridDate;
        private DataGridViewButtonColumn Show;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn gridDescription;
    }
}
