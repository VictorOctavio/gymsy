namespace gymsy.UserControls.AdminControls
{
    partial class InstructorsAdminControl
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorsAdminControl));
            dataGridInstructors = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Clientes = new DataGridViewTextBoxColumn();
            last_expiration = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridInstructors
            // 
            dataGridInstructors.AllowUserToAddRows = false;
            dataGridInstructors.AllowUserToDeleteRows = false;
            dataGridInstructors.AllowUserToResizeColumns = false;
            dataGridInstructors.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(16, 8, 23);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(230, 237, 243);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(69, 34, 99);
            dataGridInstructors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridInstructors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridInstructors.BackgroundColor = Color.FromArgb(16, 8, 23);
            dataGridInstructors.BorderStyle = BorderStyle.None;
            dataGridInstructors.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridInstructors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridInstructors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridInstructors.Columns.AddRange(new DataGridViewColumn[] { name, Telefono, Clientes, last_expiration, Eliminar });
            dataGridInstructors.Dock = DockStyle.Bottom;
            dataGridInstructors.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridInstructors.Location = new Point(0, 104);
            dataGridInstructors.Name = "dataGridInstructors";
            dataGridInstructors.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridInstructors.RowHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridInstructors.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridInstructors.RowTemplate.Height = 25;
            dataGridInstructors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridInstructors.ShowCellErrors = false;
            dataGridInstructors.Size = new Size(700, 401);
            dataGridInstructors.TabIndex = 2;
            // 
            // name
            // 
            name.HeaderText = "Nombre";
            name.Name = "name";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Clientes
            // 
            Clientes.HeaderText = "Cantidad Clientes";
            Clientes.Name = "Clientes";
            // 
            // last_expiration
            // 
            last_expiration.HeaderText = "Ingreso como Instructor";
            last_expiration.Name = "last_expiration";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Action";
            Eliminar.Name = "Eliminar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(71, 33);
            label3.Name = "label3";
            label3.Size = new Size(174, 41);
            label3.TabIndex = 10;
            label3.Text = "Instructores";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-19, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // InstructorsAdminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 8, 23);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridInstructors);
            Name = "InstructorsAdminControl";
            Size = new Size(700, 505);
            ((System.ComponentModel.ISupportInitialize)dataGridInstructors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridInstructors;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Clientes;
        private DataGridViewTextBoxColumn last_expiration;
        private DataGridViewButtonColumn Eliminar;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
