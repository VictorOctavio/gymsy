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
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            LModoBusqueda = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(343, 258);
            label1.Name = "label1";
            label1.Size = new Size(289, 37);
            label1.TabIndex = 1;
            label1.Text = "DashboardUserControl";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(LModoBusqueda);
            panel2.Location = new Point(48, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 269);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 34);
            panel3.Name = "panel3";
            panel3.Size = new Size(522, 221);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(541, 34);
            panel4.Name = "panel4";
            panel4.Size = new Size(405, 221);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Location = new Point(343, 261);
            panel5.Name = "panel5";
            panel5.Size = new Size(603, 266);
            panel5.TabIndex = 1;
            // 
            // LModoBusqueda
            // 
            LModoBusqueda.AutoSize = true;
            LModoBusqueda.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LModoBusqueda.ForeColor = Color.FromArgb(230, 237, 243);
            LModoBusqueda.Location = new Point(82, 9);
            LModoBusqueda.Name = "LModoBusqueda";
            LModoBusqueda.Size = new Size(102, 25);
            LModoBusqueda.TabIndex = 84;
            LModoBusqueda.Text = "Top Planes";
            LModoBusqueda.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(230, 237, 243);
            label2.Location = new Point(166, 7);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 85;
            label2.Text = "Transacciones";
            label2.Visible = false;
            // 
            // DashboardUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(0);
            Name = "DashboardUserControl";
            Size = new Size(1000, 530);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Label label2;
        private Label LModoBusqueda;
    }
}
