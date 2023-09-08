namespace gymsy.UserControls
{
    partial class AddPlanUserControl
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
            AddPlanUserConrol = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            BAddPlan = new FontAwesome.Sharp.IconButton();
            textBox1 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            driedUsers = new DataGridView();
            id_plan = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)driedUsers).BeginInit();
            SuspendLayout();
            // 
            // AddPlanUserConrol
            // 
            AddPlanUserConrol.Anchor = AnchorStyles.None;
            AddPlanUserConrol.AutoSize = true;
            AddPlanUserConrol.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            AddPlanUserConrol.Location = new Point(365, 232);
            AddPlanUserConrol.Name = "AddPlanUserConrol";
            AddPlanUserConrol.Size = new Size(286, 42);
            AddPlanUserConrol.TabIndex = 0;
            AddPlanUserConrol.Text = "AddPlanUserConrol";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(driedUsers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(BAddPlan);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(iconButton1);
            panel2.Location = new Point(0, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 114);
            panel2.TabIndex = 6;
            // 
            // BAddPlan
            // 
            BAddPlan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BAddPlan.BackColor = Color.FromArgb(0, 192, 0);
            BAddPlan.BackgroundImageLayout = ImageLayout.Zoom;
            BAddPlan.FlatStyle = FlatStyle.Flat;
            BAddPlan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BAddPlan.ForeColor = Color.Transparent;
            BAddPlan.IconChar = FontAwesome.Sharp.IconChar.Add;
            BAddPlan.IconColor = Color.White;
            BAddPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAddPlan.IconSize = 60;
            BAddPlan.ImageAlign = ContentAlignment.MiddleRight;
            BAddPlan.Location = new Point(355, 34);
            BAddPlan.Name = "BAddPlan";
            BAddPlan.Size = new Size(173, 51);
            BAddPlan.TabIndex = 4;
            BAddPlan.Text = "Agregar Plan";
            BAddPlan.TextAlign = ContentAlignment.MiddleLeft;
            BAddPlan.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(40, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 29);
            textBox1.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.DarkOrange;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.Transparent;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(258, 34);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(77, 47);
            iconButton1.TabIndex = 3;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // driedUsers
            // 
            driedUsers.AllowUserToAddRows = false;
            driedUsers.AllowUserToDeleteRows = false;
            driedUsers.AllowUserToResizeColumns = false;
            driedUsers.AllowUserToResizeRows = false;
            driedUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            driedUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            driedUsers.BackgroundColor = Color.FromArgb(224, 224, 224);
            driedUsers.BorderStyle = BorderStyle.None;
            driedUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            driedUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            driedUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            driedUsers.Columns.AddRange(new DataGridViewColumn[] { id_plan, precio, descripcion });
            driedUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            driedUsers.Location = new Point(3, 125);
            driedUsers.Name = "driedUsers";
            driedUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            driedUsers.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            driedUsers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            driedUsers.RowTemplate.Height = 25;
            driedUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            driedUsers.ShowCellErrors = false;
            driedUsers.Size = new Size(994, 400);
            driedUsers.TabIndex = 5;
            // 
            // id_plan
            // 
            id_plan.HeaderText = "Identificador";
            id_plan.Name = "id_plan";
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.Name = "descripcion";
            // 
            // AddPlanUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(AddPlanUserConrol);
            Margin = new Padding(0);
            Name = "AddPlanUserControl";
            Size = new Size(1000, 530);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)driedUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddPlanUserConrol;
        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton BAddPlan;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridView driedUsers;
        private DataGridViewTextBoxColumn id_plan;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn descripcion;
    }
}
