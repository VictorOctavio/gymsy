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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            rjButton4 = new ClassCustom.RJButton();
            rjButton3 = new ClassCustom.RJButton();
            label1 = new Label();
            rjTextBox6 = new CustomControls.RJControls.RJTextBox();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            label19 = new Label();
            label18 = new Label();
            label16 = new Label();
            driedUsers = new DataGridView();
            id_plan = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            nav = new Panel();
            rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            rjButton2 = new ClassCustom.RJButton();
            rjButton1 = new ClassCustom.RJButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)driedUsers).BeginInit();
            nav.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(rjButton4);
            panel1.Controls.Add(rjButton3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rjTextBox6);
            panel1.Controls.Add(rjTextBox1);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(driedUsers);
            panel1.Controls.Add(nav);
            panel1.Controls.Add(rjButton1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 1;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(0, 0, 192);
            rjButton4.BackgroundColor = Color.FromArgb(0, 0, 192);
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 15;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton4.ForeColor = Color.White;
            rjButton4.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            rjButton4.IconColor = Color.White;
            rjButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton4.IconSize = 45;
            rjButton4.ImageAlign = ContentAlignment.MiddleRight;
            rjButton4.Location = new Point(743, 162);
            rjButton4.Name = "rjButton4";
            rjButton4.Padding = new Padding(10, 0, 0, 0);
            rjButton4.Size = new Size(172, 49);
            rjButton4.TabIndex = 77;
            rjButton4.Text = "Agregar Plan";
            rjButton4.TextAlign = ContentAlignment.MiddleLeft;
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(192, 0, 0);
            rjButton3.BackgroundColor = Color.FromArgb(192, 0, 0);
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 15;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton3.ForeColor = Color.White;
            rjButton3.IconChar = FontAwesome.Sharp.IconChar.Trash;
            rjButton3.IconColor = Color.White;
            rjButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton3.IconSize = 45;
            rjButton3.ImageAlign = ContentAlignment.MiddleRight;
            rjButton3.Location = new Point(743, 217);
            rjButton3.Name = "rjButton3";
            rjButton3.Padding = new Padding(10, 0, 0, 0);
            rjButton3.Size = new Size(172, 49);
            rjButton3.TabIndex = 76;
            rjButton3.Text = "Agregar Plan";
            rjButton3.TextAlign = ContentAlignment.MiddleLeft;
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(743, 424);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 75;
            label1.Text = "*Campo requerido";
            label1.Visible = false;
            // 
            // rjTextBox6
            // 
            rjTextBox6.BackColor = Color.FromArgb(69, 34, 99);
            rjTextBox6.BorderColor = Color.Transparent;
            rjTextBox6.BorderFocusColor = Color.HotPink;
            rjTextBox6.BorderRadius = 15;
            rjTextBox6.BorderSize = 2;
            rjTextBox6.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox6.ForeColor = Color.FromArgb(230, 237, 243);
            rjTextBox6.Location = new Point(743, 389);
            rjTextBox6.Margin = new Padding(4);
            rjTextBox6.Multiline = false;
            rjTextBox6.Name = "rjTextBox6";
            rjTextBox6.Padding = new Padding(10, 7, 10, 7);
            rjTextBox6.PasswordChar = false;
            rjTextBox6.PlaceholderColor = Color.DarkGray;
            rjTextBox6.PlaceholderText = "Ingrese un nombre...";
            rjTextBox6.Size = new Size(204, 31);
            rjTextBox6.TabIndex = 74;
            rjTextBox6.Texts = "";
            rjTextBox6.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.FromArgb(69, 34, 99);
            rjTextBox1.BorderColor = Color.Transparent;
            rjTextBox1.BorderFocusColor = Color.HotPink;
            rjTextBox1.BorderRadius = 15;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox1.ForeColor = Color.FromArgb(230, 237, 243);
            rjTextBox1.Location = new Point(743, 306);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "Ingrese un nombre...";
            rjTextBox1.Size = new Size(204, 31);
            rjTextBox1.TabIndex = 73;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.ForeColor = Color.Red;
            label19.Location = new Point(743, 341);
            label19.Name = "label19";
            label19.Size = new Size(105, 15);
            label19.TabIndex = 72;
            label19.Text = "*Campo requerido";
            label19.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.FromArgb(230, 237, 243);
            label18.Location = new Point(743, 366);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 71;
            label18.Text = "Descripcion";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(230, 237, 243);
            label16.Location = new Point(743, 287);
            label16.Name = "label16";
            label16.Size = new Size(40, 15);
            label16.TabIndex = 70;
            label16.Text = "Precio";
            // 
            // driedUsers
            // 
            driedUsers.AllowUserToAddRows = false;
            driedUsers.AllowUserToDeleteRows = false;
            driedUsers.AllowUserToResizeColumns = false;
            driedUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(69, 34, 99);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(230, 237, 243);
            driedUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            driedUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            driedUsers.BackgroundColor = Color.FromArgb(16, 8, 23);
            driedUsers.BorderStyle = BorderStyle.None;
            driedUsers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            driedUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            driedUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            driedUsers.Columns.AddRange(new DataGridViewColumn[] { id_plan, precio, descripcion });
            driedUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            driedUsers.Location = new Point(0, 130);
            driedUsers.Name = "driedUsers";
            driedUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            driedUsers.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            driedUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            driedUsers.RowTemplate.Height = 25;
            driedUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            driedUsers.ShowCellErrors = false;
            driedUsers.Size = new Size(699, 400);
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
            // nav
            // 
            nav.BackColor = Color.FromArgb(16, 8, 23);
            nav.Controls.Add(rjTextBox5);
            nav.Controls.Add(rjButton2);
            nav.Dock = DockStyle.Top;
            nav.ForeColor = Color.FromArgb(16, 8, 23);
            nav.Location = new Point(0, 0);
            nav.Name = "nav";
            nav.Size = new Size(1000, 124);
            nav.TabIndex = 6;
            // 
            // rjTextBox5
            // 
            rjTextBox5.BackColor = Color.FromArgb(69, 34, 99);
            rjTextBox5.BorderColor = Color.Transparent;
            rjTextBox5.BorderFocusColor = Color.HotPink;
            rjTextBox5.BorderRadius = 15;
            rjTextBox5.BorderSize = 2;
            rjTextBox5.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            rjTextBox5.ForeColor = Color.FromArgb(230, 237, 243);
            rjTextBox5.Location = new Point(26, 71);
            rjTextBox5.Margin = new Padding(4);
            rjTextBox5.Multiline = false;
            rjTextBox5.Name = "rjTextBox5";
            rjTextBox5.Padding = new Padding(10, 7, 10, 7);
            rjTextBox5.PasswordChar = false;
            rjTextBox5.PlaceholderColor = Color.DarkGray;
            rjTextBox5.PlaceholderText = "Ingrese una busqueda...";
            rjTextBox5.Size = new Size(582, 31);
            rjTextBox5.TabIndex = 69;
            rjTextBox5.Texts = "";
            rjTextBox5.UnderlinedStyle = false;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.DarkOrange;
            rjButton2.BackgroundColor = Color.DarkOrange;
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 25;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.ForeColor = Color.White;
            rjButton2.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            rjButton2.IconColor = Color.White;
            rjButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton2.IconSize = 30;
            rjButton2.Location = new Point(615, 61);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(50, 50);
            rjButton2.TabIndex = 6;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(0, 192, 0);
            rjButton1.BackgroundColor = Color.FromArgb(0, 192, 0);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            rjButton1.IconColor = Color.White;
            rjButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton1.ImageAlign = ContentAlignment.MiddleRight;
            rjButton1.Location = new Point(743, 442);
            rjButton1.Name = "rjButton1";
            rjButton1.Padding = new Padding(10, 0, 0, 0);
            rjButton1.Size = new Size(172, 49);
            rjButton1.TabIndex = 5;
            rjButton1.Text = "Agregar Plan";
            rjButton1.TextAlign = ContentAlignment.MiddleLeft;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // AddPlanUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "AddPlanUserControl";
            Size = new Size(1000, 530);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)driedUsers).EndInit();
            nav.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel nav;
        private DataGridView driedUsers;
        private DataGridViewTextBoxColumn id_plan;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn descripcion;
        private ClassCustom.RJButton rjButton1;
        private ClassCustom.RJButton rjButton2;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
        private Label label1;
        private CustomControls.RJControls.RJTextBox rjTextBox6;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private Label label19;
        private Label label18;
        private Label label16;
        private ClassCustom.RJButton rjButton3;
        private ClassCustom.RJButton rjButton4;
    }
}
