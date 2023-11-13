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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUserControl));
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            ChartArea chartArea3 = new ChartArea();
            Legend legend3 = new Legend();
            Series series3 = new Series();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            chartInstructor = new Chart();
            panel3 = new Panel();
            ChartCuotasClientes = new Chart();
            ChartClientsxPlan = new Chart();
            panel4 = new Panel();
            panel2 = new Panel();
            PanelMsg = new Panel();
            pictureBox2 = new PictureBox();
            PanelListClient = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            label1 = new Label();
            BtnDownload = new ClassCustom.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartInstructor).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ChartCuotasClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChartClientsxPlan).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            PanelMsg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
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
            // chartInstructor
            // 
            chartInstructor.BackColor = Color.FromArgb(16, 8, 30);
            chartInstructor.BackgroundImageLayout = ImageLayout.None;
            chartInstructor.BorderlineColor = Color.Transparent;
            chartArea1.AxisX.InterlacedColor = Color.Transparent;
            chartArea1.AxisX.LineColor = Color.Transparent;
            chartArea1.AxisX.LineDashStyle = ChartDashStyle.NotSet;
            chartArea1.AxisX.Title = "Fecha";
            chartArea1.AxisX.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.AxisX.TitleForeColor = Color.FromArgb(230, 237, 243);
            chartArea1.AxisX2.InterlacedColor = Color.Transparent;
            chartArea1.AxisX2.LineColor = Color.Transparent;
            chartArea1.AxisX2.TitleForeColor = Color.WhiteSmoke;
            chartArea1.AxisY.InterlacedColor = Color.Transparent;
            chartArea1.AxisY.LineColor = Color.FromArgb(230, 237, 243);
            chartArea1.AxisY.LineDashStyle = ChartDashStyle.NotSet;
            chartArea1.AxisY.Title = "Clientes";
            chartArea1.AxisY.TitleFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chartArea1.AxisY.TitleForeColor = Color.FromArgb(230, 237, 243);
            chartArea1.AxisY2.InterlacedColor = Color.Transparent;
            chartArea1.AxisY2.LineColor = Color.Transparent;
            chartArea1.BackColor = Color.FromArgb(16, 8, 23);
            chartArea1.BackSecondaryColor = Color.White;
            chartArea1.BorderColor = Color.White;
            chartArea1.Name = "ChartArea1";
            chartInstructor.ChartAreas.Add(chartArea1);
            chartInstructor.Dock = DockStyle.Fill;
            legend1.BackColor = Color.Transparent;
            legend1.BorderColor = Color.Transparent;
            legend1.BorderDashStyle = ChartDashStyle.NotSet;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.ForeColor = Color.FromArgb(230, 237, 243);
            legend1.InterlacedRowsColor = Color.White;
            legend1.Name = "Legend1";
            legend1.ShadowColor = Color.Silver;
            chartInstructor.Legends.Add(legend1);
            chartInstructor.Location = new Point(0, 0);
            chartInstructor.Margin = new Padding(0);
            chartInstructor.Name = "chartInstructor";
            series1.BackImageTransparentColor = Color.Transparent;
            series1.BorderColor = Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.SplineArea;
            series1.Color = Color.DarkOrange;
            series1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = Color.White;
            series1.Name = "Ganancia";
            series1.YValuesPerPoint = 2;
            chartInstructor.Series.Add(series1);
            chartInstructor.Size = new Size(900, 243);
            chartInstructor.TabIndex = 13;
            chartInstructor.Text = "chart2";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(16, 8, 25);
            panel3.Controls.Add(ChartCuotasClientes);
            panel3.Controls.Add(ChartClientsxPlan);
            panel3.Location = new Point(466, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(434, 229);
            panel3.TabIndex = 10;
            // 
            // ChartCuotasClientes
            // 
            ChartCuotasClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChartCuotasClientes.BackColor = Color.Transparent;
            chartArea2.BackColor = Color.Transparent;
            chartArea2.BorderColor = Color.Transparent;
            chartArea2.Name = "ChartArea1";
            ChartCuotasClientes.ChartAreas.Add(chartArea2);
            legend2.BackColor = Color.Transparent;
            legend2.ForeColor = Color.FromArgb(230, 237, 243);
            legend2.Name = "Legend1";
            ChartCuotasClientes.Legends.Add(legend2);
            ChartCuotasClientes.Location = new Point(0, 3);
            ChartCuotasClientes.Name = "ChartCuotasClientes";
            ChartCuotasClientes.Palette = ChartColorPalette.SeaGreen;
            series2.BorderColor = Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Doughnut;
            series2.Color = Color.Transparent;
            series2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            series2.Legend = "Legend1";
            series2.Name = "ChartCuotasClientes";
            series2.Palette = ChartColorPalette.BrightPastel;
            ChartCuotasClientes.Series.Add(series2);
            ChartCuotasClientes.Size = new Size(431, 226);
            ChartCuotasClientes.TabIndex = 13;
            ChartCuotasClientes.Text = "chart1";
            ChartCuotasClientes.Visible = false;
            // 
            // ChartClientsxPlan
            // 
            ChartClientsxPlan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ChartClientsxPlan.BackColor = Color.Transparent;
            chartArea3.BackColor = Color.Transparent;
            chartArea3.BorderColor = Color.Transparent;
            chartArea3.Name = "ChartArea1";
            ChartClientsxPlan.ChartAreas.Add(chartArea3);
            legend3.BackColor = Color.Transparent;
            legend3.ForeColor = Color.FromArgb(230, 237, 243);
            legend3.Name = "Legend1";
            ChartClientsxPlan.Legends.Add(legend3);
            ChartClientsxPlan.Location = new Point(0, 3);
            ChartClientsxPlan.Name = "ChartClientsxPlan";
            ChartClientsxPlan.Palette = ChartColorPalette.Berry;
            series3.BorderColor = Color.Transparent;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = SeriesChartType.Doughnut;
            series3.Color = Color.Transparent;
            series3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            series3.Legend = "Legend1";
            series3.Name = "SerieTorta";
            series3.Palette = ChartColorPalette.BrightPastel;
            ChartClientsxPlan.Series.Add(series3);
            ChartClientsxPlan.Size = new Size(431, 226);
            ChartClientsxPlan.TabIndex = 10;
            ChartClientsxPlan.Text = "chart1";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(16, 8, 30);
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
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(16, 8, 25);
            panel2.Controls.Add(PanelMsg);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 229);
            panel2.TabIndex = 11;
            // 
            // PanelMsg
            // 
            PanelMsg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelMsg.Controls.Add(pictureBox2);
            PanelMsg.Controls.Add(PanelListClient);
            PanelMsg.Location = new Point(92, 124);
            PanelMsg.Margin = new Padding(2);
            PanelMsg.Name = "PanelMsg";
            PanelMsg.Size = new Size(239, 65);
            PanelMsg.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.output_onlinegiftoolsw;
            pictureBox2.Location = new Point(10, 8);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 47);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // PanelListClient
            // 
            PanelListClient.AutoSize = true;
            PanelListClient.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            PanelListClient.ForeColor = SystemColors.ButtonHighlight;
            PanelListClient.Location = new Point(84, 19);
            PanelListClient.Margin = new Padding(2, 0, 2, 0);
            PanelListClient.Name = "PanelListClient";
            PanelListClient.Size = new Size(134, 25);
            PanelListClient.TabIndex = 0;
            PanelListClient.Text = "Clientes al dia :)";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.DarkOrange;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView2.BackgroundColor = Color.FromArgb(16, 8, 25);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOrange;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewButtonColumn1 });
            dataGridView2.GridColor = SystemColors.ActiveCaption;
            dataGridView2.Location = new Point(0, 61);
            dataGridView2.Margin = new Padding(0);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 192, 128);
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView2.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(463, 168);
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
            label1.Size = new Size(190, 32);
            label1.TabIndex = 8;
            label1.Text = "Cuotas Vencidas";
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
            BtnDownload.Location = new Point(723, 22);
            BtnDownload.Margin = new Padding(0);
            BtnDownload.Name = "BtnDownload";
            BtnDownload.Padding = new Padding(10, 0, 10, 0);
            BtnDownload.Size = new Size(150, 35);
            BtnDownload.TabIndex = 45;
            BtnDownload.Text = "Descargar";
            BtnDownload.TextAlign = ContentAlignment.MiddleLeft;
            BtnDownload.TextColor = Color.White;
            BtnDownload.UseVisualStyleBackColor = false;
            BtnDownload.Click += BtnDownload_Click;
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 8, 30);
            Controls.Add(BtnDownload);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Margin = new Padding(0);
            Name = "DashboardUserControl";
            Size = new Size(900, 550);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartInstructor).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ChartCuotasClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChartClientsxPlan).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PanelMsg.ResumeLayout(false);
            PanelMsg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Panel panel2;
        private Label label1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.CodeDom.CodeTypeReference chart1;
        private Chart chartInstructor;
        private Chart ChartClientsxPlan;
        private Panel PanelMsg;
        private PictureBox pictureBox2;
        private Label PanelListClient;
        private ClassCustom.RJButton BtnDownload;
        private Chart ChartCuotasClientes;
    }
}
