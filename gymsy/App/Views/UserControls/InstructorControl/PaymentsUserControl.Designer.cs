namespace gymsy.UserControls
{
    partial class PaymentsUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            PanelPaymentsWrapper = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            dataGridPayments = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            gridDate = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            gridDescription = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            PanelPaymentsWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPayments).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelPaymentsWrapper
            // 
            PanelPaymentsWrapper.BackColor = Color.FromArgb(16, 8, 23);
            PanelPaymentsWrapper.Controls.Add(dataGridPayments);
            PanelPaymentsWrapper.Controls.Add(panel1);
            PanelPaymentsWrapper.Dock = DockStyle.Fill;
            PanelPaymentsWrapper.Location = new Point(0, 0);
            PanelPaymentsWrapper.Margin = new Padding(4, 5, 4, 5);
            PanelPaymentsWrapper.Name = "PanelPaymentsWrapper";
            PanelPaymentsWrapper.Size = new Size(1143, 1045);
            PanelPaymentsWrapper.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pagoshans;
            pictureBox1.Location = new Point(-10, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(140, 54);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(375, 60);
            label3.TabIndex = 4;
            label3.Text = "Historial de Pagos";
            // 
            // dataGridPayments
            // 
            dataGridPayments.AllowUserToAddRows = false;
            dataGridPayments.AllowUserToDeleteRows = false;
            dataGridPayments.AllowUserToResizeColumns = false;
            dataGridPayments.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = Color.Transparent;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridPayments.BackgroundColor = Color.FromArgb(16, 8, 30);
            dataGridPayments.CausesValidation = false;
            dataGridPayments.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Transparent;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPayments.Columns.AddRange(new DataGridViewColumn[] { ID, gridDate, Peso, Amount, gridDescription });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dataGridPayments.DefaultCellStyle = dataGridViewCellStyle12;
            dataGridPayments.Dock = DockStyle.Bottom;
            dataGridPayments.GridColor = Color.Black;
            dataGridPayments.Location = new Point(0, 240);
            dataGridPayments.Margin = new Padding(0);
            dataGridPayments.MultiSelect = false;
            dataGridPayments.Name = "dataGridPayments";
            dataGridPayments.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.IndianRed;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.GrayText;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            dataGridPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            dataGridPayments.RowHeadersVisible = false;
            dataGridPayments.RowHeadersWidth = 62;
            dataGridPayments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle14.BackColor = Color.White;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle14.SelectionBackColor = Color.White;
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridPayments.RowsDefaultCellStyle = dataGridViewCellStyle14;
            dataGridPayments.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            dataGridPayments.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridPayments.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridPayments.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridPayments.RowTemplate.Height = 30;
            dataGridPayments.ScrollBars = ScrollBars.None;
            dataGridPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPayments.Size = new Size(1143, 805);
            dataGridPayments.TabIndex = 3;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.True;
            ID.Visible = false;
            ID.Width = 150;
            // 
            // gridDate
            // 
            gridDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.BackColor = Color.Transparent;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = Color.Transparent;
            gridDate.DefaultCellStyle = dataGridViewCellStyle10;
            gridDate.HeaderText = "Fecha";
            gridDate.MinimumWidth = 8;
            gridDate.Name = "gridDate";
            gridDate.ReadOnly = true;
            gridDate.Width = 150;
            // 
            // Peso
            // 
            Peso.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Peso.HeaderText = "Tipo";
            Peso.MinimumWidth = 8;
            Peso.Name = "Peso";
            Peso.ReadOnly = true;
            Peso.Width = 120;
            // 
            // Amount
            // 
            Amount.HeaderText = "Monto";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 150;
            // 
            // gridDescription
            // 
            gridDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.BackColor = Color.Transparent;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = Color.Transparent;
            gridDescription.DefaultCellStyle = dataGridViewCellStyle11;
            gridDescription.HeaderText = "Descripcion";
            gridDescription.MinimumWidth = 8;
            gridDescription.Name = "gridDescription";
            gridDescription.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 150);
            panel1.TabIndex = 6;
            // 
            // PaymentsUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelPaymentsWrapper);
            Margin = new Padding(0);
            Name = "PaymentsUserControl";
            Size = new Size(1143, 1045);
            PanelPaymentsWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPayments).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelPaymentsWrapper;
        private DataGridView dataGridPayments;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn gridDate;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn gridDescription;
        private Label label3;
        private Panel panel1;
    }
}
