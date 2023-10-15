using System.Windows.Forms.DataVisualization.Charting;

namespace gymsy.UserControls
{
    partial class DashboardUserControl
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
           
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUserControl));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ShowCliente = new DataGridViewButtonColumn();
            label2 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            label1 = new Label();
            chartInstructor = new Chart();
            ((System.ComponentModel.ISupportInitialize)chartInstructor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // chartInstructor
            // 
            chartInstructor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartInstructor.BackColor = Color.FromArgb(16, 8, 23);
            chartInstructor.BackgroundImageLayout = ImageLayout.None;
            chartInstructor.BorderlineColor = Color.Transparent;
            chartArea2.AxisX.InterlacedColor = Color.Transparent;
            chartArea2.AxisX.LineColor = Color.Transparent;
            chartArea2.AxisX.LineDashStyle = ChartDashStyle.NotSet;
            chartArea2.AxisX.Title = "Fecha";
            chartArea2.AxisX.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea2.AxisX.TitleForeColor = Color.FromArgb(230, 237, 243);
            chartArea2.AxisX2.InterlacedColor = Color.Transparent;
            chartArea2.AxisX2.LineColor = Color.Transparent;
            chartArea2.AxisX2.TitleForeColor = Color.WhiteSmoke;
            chartArea2.AxisY.InterlacedColor = Color.Transparent;
            chartArea2.AxisY.LineColor = Color.FromArgb(230, 237, 243);
            chartArea2.AxisY.LineDashStyle = ChartDashStyle.NotSet;
            chartArea2.AxisY.Title = "Clientes";
            chartArea2.AxisY.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea2.AxisY.TitleForeColor = Color.FromArgb(230, 237, 243);
            chartArea2.AxisY2.InterlacedColor = Color.Transparent;
            chartArea2.AxisY2.LineColor = Color.Transparent;
            chartArea2.BackColor = Color.FromArgb(16, 8, 23);
            chartArea2.BackSecondaryColor = Color.White;
            chartArea2.BorderColor = Color.White;
            chartArea2.Name = "ChartArea1";
            chartInstructor.ChartAreas.Add(chartArea2);
            legend2.BackColor = Color.Transparent;
            legend2.BorderColor = Color.Transparent;
            legend2.BorderDashStyle = ChartDashStyle.NotSet;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.ForeColor = Color.FromArgb(230, 237, 243);
            legend2.InterlacedRowsColor = Color.White;
            legend2.Name = "Legend1";
            legend2.ShadowColor = Color.Silver;
            chartInstructor.Legends.Add(legend2);
            chartInstructor.Location = new Point(0, 0);
            chartInstructor.Name = "chartInstructor";
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
            chartInstructor.Series.Add(series2);
            chartInstructor.Size = new Size(897, 243);
            chartInstructor.TabIndex = 13;
            chartInstructor.Text = "chart2";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-27, -14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(61, 22);
            label3.Name = "label3";
            label3.Size = new Size(147, 37);
            label3.TabIndex = 6;
            label3.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(16, 8, 30);
            panel1.Controls.Add(chartInstructor);
            panel1.Location = new Point(0, 78);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 243);
            panel1.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(16, 8, 23);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(466, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(434, 229);
            panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.DarkOrange;
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.FromArgb(16, 8, 23);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.DarkOrange;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.Honeydew;
            dataGridViewCellStyle8.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle8.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, ShowCliente });
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(0, 61);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 192, 128);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(434, 168);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(20, 13);
            label2.Name = "label2";
            label2.Size = new Size(190, 32);
            label2.TabIndex = 8;
            label2.Text = "Cuotas Vencidas";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(16, 8, 23);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 321);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(900, 229);
            panel4.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(16, 8, 23);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(466, 229);
            panel2.TabIndex = 11;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = Color.DarkOrange;
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.FromArgb(16, 8, 23);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.DarkOrange;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.Honeydew;
            dataGridViewCellStyle11.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle11.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewButtonColumn1 });
            dataGridView2.GridColor = SystemColors.ControlLight;
            dataGridView2.Location = new Point(0, 61);
            dataGridView2.Margin = new Padding(0);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 192, 128);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView2.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(466, 168);
            dataGridView2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "ID";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
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
            dataGridViewButtonColumn1.HeaderText = "Ver";
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Width = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOrange;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(204, 32);
            label1.TabIndex = 8;
            label1.Text = "Proximo a Vencer";
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 8, 23);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Margin = new Padding(0);
            Name = "DashboardUserControl";
            Size = new Size(900, 550);
            ((System.ComponentModel.ISupportInitialize)chartInstructor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewButtonColumn ShowCliente;
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.CodeDom.CodeTypeReference chart1;
        private Chart chartInstructor;
    }
}
