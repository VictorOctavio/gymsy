using System.Windows.Forms.DataVisualization.Charting;

namespace gymsy.UserControls.AdminControls
{
    partial class DashboardAdminControl
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel7 = new Panel();
            chartInstructorXClientes = new Chart();
            panel5 = new Panel();
            DataGridPays = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ShowCliente = new DataGridViewButtonColumn();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ChartAdmin = new Chart();
            BtnDownload = new ClassCustom.RJButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartInstructorXClientes).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridPays).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartAdmin).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 168);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "DashboardAdminControl";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 8, 23);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 301);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 229);
            panel2.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(16, 8, 23);
            panel7.Controls.Add(chartInstructorXClientes);
            panel7.Location = new Point(561, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(439, 229);
            panel7.TabIndex = 12;
            // 
            // chartInstructorXClientes
            // 
            chartInstructorXClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartInstructorXClientes.BackColor = Color.Transparent;
            chartArea1.BackColor = Color.Transparent;
            chartArea1.BorderColor = Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartInstructorXClientes.ChartAreas.Add(chartArea1);
            legend1.BackColor = Color.Transparent;
            legend1.ForeColor = Color.FromArgb(230, 237, 243);
            legend1.Name = "Legend1";
            chartInstructorXClientes.Legends.Add(legend1);
            chartInstructorXClientes.Location = new Point(0, 3);
            chartInstructorXClientes.Name = "chartInstructorXClientes";
            series1.BorderColor = Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Doughnut;
            series1.Color = Color.Transparent;
            series1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = ChartColorPalette.BrightPastel;
            chartInstructorXClientes.Series.Add(series1);
            chartInstructorXClientes.Size = new Size(439, 226);
            chartInstructorXClientes.TabIndex = 9;
            chartInstructorXClientes.Text = "chart1";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(16, 8, 23);
            panel5.Controls.Add(DataGridPays);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(0, 3);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(558, 226);
            panel5.TabIndex = 11;
            // 
            // DataGridPays
            // 
            DataGridPays.AllowUserToAddRows = false;
            DataGridPays.AllowUserToDeleteRows = false;
            DataGridPays.AllowUserToResizeColumns = false;
            DataGridPays.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.DarkOrange;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            DataGridPays.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridPays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridPays.BackgroundColor = Color.FromArgb(16, 8, 23);
            DataGridPays.BorderStyle = BorderStyle.None;
            DataGridPays.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DataGridPays.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOrange;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridPays.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridPays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridPays.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn6, dataGridViewButtonColumn1, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridPays.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridPays.GridColor = SystemColors.ControlLight;
            DataGridPays.Location = new Point(0, 61);
            DataGridPays.Margin = new Padding(0);
            DataGridPays.MultiSelect = false;
            DataGridPays.Name = "DataGridPays";
            DataGridPays.ReadOnly = true;
            DataGridPays.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 192, 128);
            DataGridPays.RowsDefaultCellStyle = dataGridViewCellStyle4;
            DataGridPays.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            DataGridPays.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            DataGridPays.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            DataGridPays.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            DataGridPays.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            DataGridPays.RowTemplate.Height = 25;
            DataGridPays.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridPays.Size = new Size(558, 165);
            DataGridPays.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "ID";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Fecha";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewButtonColumn1.HeaderText = "Monto";
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.True;
            dataGridViewButtonColumn1.SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewButtonColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkOrange;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(277, 32);
            label2.TabIndex = 8;
            label2.Text = "Ultimos Pagos Recibidos";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel6.BackColor = Color.FromArgb(16, 8, 23);
            panel6.Controls.Add(dataGridView1);
            panel6.Controls.Add(label3);
            panel6.Location = new Point(1671, 0);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(434, 358);
            panel6.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = Color.DarkOrange;
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(16, 8, 23);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.DarkOrange;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Honeydew;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle6.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, ShowCliente });
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(0, 61);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 192, 128);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(668, 426);
            dataGridView1.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // ShowCliente
            // 
            ShowCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ShowCliente.HeaderText = "Ver";
            ShowCliente.Name = "ShowCliente";
            ShowCliente.ReadOnly = true;
            ShowCliente.Width = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(20, 13);
            label3.Name = "label3";
            label3.Size = new Size(190, 32);
            label3.TabIndex = 8;
            label3.Text = "Cuotas Vencidas";
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(ChartAdmin);
            panel3.Controls.Add(BtnDownload);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 530);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(84, 16);
            label4.Name = "label4";
            label4.Size = new Size(147, 37);
            label4.TabIndex = 47;
            label4.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.admindash;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // ChartAdmin
            // 
            ChartAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChartAdmin.BackColor = Color.FromArgb(16, 8, 30);
            ChartAdmin.BackgroundImageLayout = ImageLayout.None;
            ChartAdmin.BorderlineColor = Color.Transparent;
            chartArea2.AxisX.InterlacedColor = Color.Transparent;
            chartArea2.AxisX.LineColor = Color.Transparent;
            chartArea2.AxisX.LineDashStyle = ChartDashStyle.NotSet;
            chartArea2.AxisX.Title = "Meses";
            chartArea2.AxisX.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea2.AxisX.TitleForeColor = Color.FromArgb(230, 237, 243);
            chartArea2.AxisX2.InterlacedColor = Color.Transparent;
            chartArea2.AxisX2.LineColor = Color.Transparent;
            chartArea2.AxisX2.TitleForeColor = Color.WhiteSmoke;
            chartArea2.AxisY.InterlacedColor = Color.Transparent;
            chartArea2.AxisY.LineColor = Color.FromArgb(230, 237, 243);
            chartArea2.AxisY.LineDashStyle = ChartDashStyle.NotSet;
            chartArea2.AxisY.Title = "Monto";
            chartArea2.AxisY.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea2.AxisY.TitleForeColor = Color.FromArgb(230, 237, 243);
            chartArea2.AxisY2.InterlacedColor = Color.Transparent;
            chartArea2.AxisY2.LineColor = Color.Transparent;
            chartArea2.BackColor = Color.FromArgb(16, 8, 23);
            chartArea2.BackSecondaryColor = Color.White;
            chartArea2.BorderColor = Color.White;
            chartArea2.Name = "ChartArea1";
            ChartAdmin.ChartAreas.Add(chartArea2);
            legend2.BackColor = Color.Transparent;
            legend2.BorderColor = Color.Transparent;
            legend2.BorderDashStyle = ChartDashStyle.NotSet;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.ForeColor = Color.FromArgb(230, 237, 243);
            legend2.InterlacedRowsColor = Color.White;
            legend2.Name = "Legend1";
            legend2.ShadowColor = Color.Silver;
            ChartAdmin.Legends.Add(legend2);
            ChartAdmin.Location = new Point(0, 76);
            ChartAdmin.Margin = new Padding(0);
            ChartAdmin.Name = "ChartAdmin";
            series2.BackImageTransparentColor = Color.Transparent;
            series2.BorderColor = Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.SplineArea;
            series2.Color = Color.DarkOrange;
            series2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            series2.IsXValueIndexed = true;
            series2.LabelBackColor = Color.White;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = Color.White;
            series2.Name = "Ganancia";
            series2.YValuesPerPoint = 2;
            ChartAdmin.Series.Add(series2);
            ChartAdmin.Size = new Size(1000, 225);
            ChartAdmin.TabIndex = 14;
            ChartAdmin.Text = "chart2";
            // 
            // BtnDownload
            // 
            BtnDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDownload.BackColor = Color.Crimson;
            BtnDownload.BackgroundColor = Color.Crimson;
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
            BtnDownload.Location = new Point(838, 22);
            BtnDownload.Margin = new Padding(0);
            BtnDownload.Name = "BtnDownload";
            BtnDownload.Padding = new Padding(10, 0, 10, 0);
            BtnDownload.Size = new Size(150, 35);
            BtnDownload.TabIndex = 46;
            BtnDownload.Text = "Descargar";
            BtnDownload.TextAlign = ContentAlignment.MiddleLeft;
            BtnDownload.TextColor = Color.White;
            BtnDownload.UseVisualStyleBackColor = false;
            BtnDownload.Click += BtnDownload_Click;
            // 
            // DashboardAdminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "DashboardAdminControl";
            Size = new Size(1000, 530);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartInstructorXClientes).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridPays).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel7;
        private Panel panel5;
        private DataGridView DataGridPays;
        private Label label2;
        private Panel panel6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn ShowCliente;
        private Label label3;
        private Chart chartInstructorXClientes;
        private Chart ChartAdmin;
        private ClassCustom.RJButton BtnDownload;
        private Label label4;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewButtonColumn1;
    }
}
