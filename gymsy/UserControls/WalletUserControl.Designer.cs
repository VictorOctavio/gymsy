namespace gymsy.UserControls
{
    partial class WalletUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelWalletWrapper = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            label13 = new Label();
            label6 = new Label();
            label12 = new Label();
            label11 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label8 = new Label();
            textBox6 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            panel6 = new Panel();
            button2 = new Button();
            label7 = new Label();
            label14 = new Label();
            label16 = new Label();
            textBox1 = new TextBox();
            label15 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            dataGridTransactions = new DataGridView();
            gridDate = new DataGridViewTextBoxColumn();
            gridType = new DataGridViewTextBoxColumn();
            gridAmount = new DataGridViewTextBoxColumn();
            gridDescription = new DataGridViewTextBoxColumn();
            panelWalletWrapper.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTransactions).BeginInit();
            SuspendLayout();
            // 
            // panelWalletWrapper
            // 
            panelWalletWrapper.Controls.Add(panel2);
            panelWalletWrapper.Controls.Add(panel1);
            panelWalletWrapper.Dock = DockStyle.Fill;
            panelWalletWrapper.Location = new Point(0, 0);
            panelWalletWrapper.Name = "panelWalletWrapper";
            panelWalletWrapper.Size = new Size(1085, 632);
            panelWalletWrapper.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(760, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 632);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(comboBox1);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(textBox6);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(325, 344);
            panel5.TabIndex = 38;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.FlatStyle = FlatStyle.Flat;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(47, 249);
            label13.Name = "label13";
            label13.Size = new Size(85, 21);
            label13.TabIndex = 41;
            label13.Text = "*requerido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(43, 36);
            label6.Name = "label6";
            label6.Size = new Size(254, 37);
            label6.TabIndex = 4;
            label6.Text = "Nueva Transferencia";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.Control;
            label12.Image = Properties.Resources.people_item;
            label12.Location = new Point(11, 212);
            label12.Name = "label12";
            label12.Size = new Size(31, 37);
            label12.TabIndex = 40;
            label12.Text = "  ";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(45, 189);
            label11.Name = "label11";
            label11.Size = new Size(77, 25);
            label11.TabIndex = 39;
            label11.Text = "Destino:";
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "Instructor1,", "Instructor2,", "Instructor3" });
            comboBox1.Location = new Point(48, 217);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(266, 29);
            comboBox1.TabIndex = 32;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.DarkOrange;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(75, 285);
            button1.Name = "button1";
            button1.Size = new Size(211, 34);
            button1.TabIndex = 31;
            button1.Text = "Transferir";
            button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(11, 126);
            label8.Name = "label8";
            label8.Size = new Size(32, 37);
            label8.TabIndex = 30;
            label8.Text = "$";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.None;
            textBox6.Cursor = Cursors.Hand;
            textBox6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.FromArgb(9, 0, 20);
            textBox6.Location = new Point(43, 127);
            textBox6.Margin = new Padding(5);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(271, 36);
            textBox6.TabIndex = 11;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(41, 100);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 1;
            label9.Text = "Monto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(43, 164);
            label10.Name = "label10";
            label10.Size = new Size(85, 21);
            label10.TabIndex = 29;
            label10.Text = "*requerido";
            // 
            // panel6
            // 
            panel6.Controls.Add(button2);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label14);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(textBox1);
            panel6.Controls.Add(label15);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 379);
            panel6.Name = "panel6";
            panel6.Size = new Size(325, 253);
            panel6.TabIndex = 43;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.DarkOrange;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(75, 168);
            button2.Name = "button2";
            button2.Size = new Size(211, 34);
            button2.TabIndex = 42;
            button2.Text = "Retirar";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(86, 16);
            label7.Name = "label7";
            label7.Size = new Size(172, 37);
            label7.TabIndex = 5;
            label7.Text = "Nuevo Retiro";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.Control;
            label14.Location = new Point(14, 103);
            label14.Name = "label14";
            label14.Size = new Size(32, 37);
            label14.TabIndex = 42;
            label14.Text = "$";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.Transparent;
            label16.FlatStyle = FlatStyle.Flat;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(51, 142);
            label16.Name = "label16";
            label16.Size = new Size(85, 21);
            label16.TabIndex = 41;
            label16.Text = "*requerido";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Cursor = Cursors.Hand;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(9, 0, 20);
            textBox1.Location = new Point(48, 103);
            textBox1.Margin = new Padding(5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 36);
            textBox1.TabIndex = 40;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.Control;
            label15.Location = new Point(48, 73);
            label15.Name = "label15";
            label15.Size = new Size(66, 25);
            label15.TabIndex = 39;
            label15.Text = "Monto";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 632);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left;
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(3, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 177);
            panel4.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(47, 12);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 2;
            label5.Text = "Disponible";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(47, 128);
            label2.Name = "label2";
            label2.Size = new Size(66, 28);
            label2.TabIndex = 1;
            label2.Text = "ahora";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 63);
            label1.Name = "label1";
            label1.Size = new Size(248, 72);
            label1.TabIndex = 0;
            label1.Text = "$ 128984";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(223, 54);
            label3.TabIndex = 3;
            label3.Text = "Mi Billetera";
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dataGridTransactions);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 282);
            panel3.MinimumSize = new Size(0, 350);
            panel3.Name = "panel3";
            panel3.Size = new Size(1085, 350);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 25);
            label4.Name = "label4";
            label4.Size = new Size(276, 37);
            label4.TabIndex = 4;
            label4.Text = "Ultimas Transacciones";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridTransactions
            // 
            dataGridTransactions.AllowUserToAddRows = false;
            dataGridTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTransactions.BackgroundColor = Color.GhostWhite;
            dataGridTransactions.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTransactions.Columns.AddRange(new DataGridViewColumn[] { gridDate, gridType, gridAmount, gridDescription });
            dataGridTransactions.GridColor = SystemColors.Control;
            dataGridTransactions.Location = new Point(0, 83);
            dataGridTransactions.Margin = new Padding(0);
            dataGridTransactions.Name = "dataGridTransactions";
            dataGridTransactions.ReadOnly = true;
            dataGridTransactions.RowTemplate.Height = 25;
            dataGridTransactions.Size = new Size(1085, 267);
            dataGridTransactions.TabIndex = 2;
            // 
            // gridDate
            // 
            gridDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridDate.HeaderText = "Fecha";
            gridDate.Name = "gridDate";
            gridDate.ReadOnly = true;
            // 
            // gridType
            // 
            gridType.HeaderText = "Tipo";
            gridType.Name = "gridType";
            gridType.ReadOnly = true;
            // 
            // gridAmount
            // 
            gridAmount.HeaderText = "Monton";
            gridAmount.Name = "gridAmount";
            gridAmount.ReadOnly = true;
            // 
            // gridDescription
            // 
            gridDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridDescription.HeaderText = "Descripcion";
            gridDescription.Name = "gridDescription";
            gridDescription.ReadOnly = true;
            // 
            // WalletUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelWalletWrapper);
            Name = "WalletUserControl";
            Size = new Size(1085, 632);
            panelWalletWrapper.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTransactions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelWalletWrapper;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridTransactions;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private DataGridViewTextBoxColumn gridDate;
        private DataGridViewTextBoxColumn gridType;
        private DataGridViewTextBoxColumn gridAmount;
        private DataGridViewTextBoxColumn gridDescription;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Panel panel5;
        private Label label8;
        private TextBox textBox6;
        private Label label9;
        private Label label10;
        private Button button1;
        private Label label11;
        private ComboBox comboBox1;
        private Label label12;
        private Label label13;
        private Button button2;
        private Label label14;
        private TextBox textBox1;
        private Label label15;
        private Label label16;
        private Panel panel6;
    }
}
