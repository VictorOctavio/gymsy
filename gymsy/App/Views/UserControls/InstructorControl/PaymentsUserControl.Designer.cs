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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            PanelPaymentsWrapper = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            dataGridPayments = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            gridDate = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            gridDescription = new DataGridViewTextBoxColumn();
            PanelPaymentsWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPayments).BeginInit();
            SuspendLayout();
            // 
            // PanelPaymentsWrapper
            // 
            PanelPaymentsWrapper.BackColor = Color.FromArgb(16, 8, 23);
            PanelPaymentsWrapper.Controls.Add(pictureBox1);
            PanelPaymentsWrapper.Controls.Add(label3);
            PanelPaymentsWrapper.Controls.Add(dataGridPayments);
            PanelPaymentsWrapper.Dock = DockStyle.Fill;
            PanelPaymentsWrapper.Location = new Point(0, 0);
            PanelPaymentsWrapper.Name = "PanelPaymentsWrapper";
            PanelPaymentsWrapper.Size = new Size(800, 627);
            PanelPaymentsWrapper.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pagoshans;
            pictureBox1.Location = new Point(-11, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 92);
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
            label3.Location = new Point(93, 42);
            label3.Name = "label3";
            label3.Size = new Size(256, 41);
            label3.TabIndex = 4;
            label3.Text = "Historial de Pagos";
            // 
            // dataGridPayments
            // 
            dataGridPayments.AllowUserToAddRows = false;
            dataGridPayments.AllowUserToDeleteRows = false;
            dataGridPayments.AllowUserToResizeColumns = false;
            dataGridPayments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridPayments.BackgroundColor = Color.FromArgb(16, 8, 30);
            dataGridPayments.CausesValidation = false;
            dataGridPayments.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPayments.Columns.AddRange(new DataGridViewColumn[] { ID, gridDate, Peso, Amount, gridDescription });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridPayments.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridPayments.Dock = DockStyle.Bottom;
            dataGridPayments.GridColor = Color.Black;
            dataGridPayments.Location = new Point(0, 144);
            dataGridPayments.Margin = new Padding(0);
            dataGridPayments.MultiSelect = false;
            dataGridPayments.Name = "dataGridPayments";
            dataGridPayments.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.IndianRed;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.GrayText;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridPayments.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridPayments.RowHeadersVisible = false;
            dataGridPayments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = Color.White;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridPayments.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridPayments.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            dataGridPayments.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridPayments.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridPayments.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridPayments.RowTemplate.Height = 30;
            dataGridPayments.ScrollBars = ScrollBars.None;
            dataGridPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPayments.Size = new Size(800, 483);
            dataGridPayments.TabIndex = 3;
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
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            gridDate.DefaultCellStyle = dataGridViewCellStyle3;
            gridDate.HeaderText = "Fecha";
            gridDate.Name = "gridDate";
            gridDate.ReadOnly = true;
            // 
            // Peso
            // 
            Peso.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Peso.HeaderText = "Tipo";
            Peso.Name = "Peso";
            Peso.ReadOnly = true;
            Peso.Width = 120;
            // 
            // Amount
            // 
            Amount.HeaderText = "Monto";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 150;
            // 
            // gridDescription
            // 
            gridDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.Transparent;
            gridDescription.DefaultCellStyle = dataGridViewCellStyle4;
            gridDescription.HeaderText = "Descripcion";
            gridDescription.Name = "gridDescription";
            gridDescription.ReadOnly = true;
            // 
            // PaymentsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PanelPaymentsWrapper);
            Margin = new Padding(0);
            Name = "PaymentsUserControl";
            Size = new Size(800, 627);
            PanelPaymentsWrapper.ResumeLayout(false);
            PanelPaymentsWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPayments).EndInit();
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
    }
}
