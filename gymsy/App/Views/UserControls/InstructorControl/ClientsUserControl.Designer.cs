namespace gymsy.UserControls
{
    partial class ClientsUserControl
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
            driedUsers = new DataGridView();
            nickname = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            data_fisic = new DataGridViewTextBoxColumn();
            last_expiration = new DataGridViewTextBoxColumn();
            plan = new DataGridViewTextBoxColumn();
            wallet = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            rjButton2 = new ClassCustom.RJButton();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            rjButton4 = new ClassCustom.RJButton();
            rjButton3 = new ClassCustom.RJButton();
            rjButton1 = new ClassCustom.RJButton();
            ((System.ComponentModel.ISupportInitialize)driedUsers).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            driedUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            driedUsers.Columns.AddRange(new DataGridViewColumn[] { nickname, rol, name, data_fisic, last_expiration, plan, wallet });
            driedUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            driedUsers.Location = new Point(3, 120);
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
            driedUsers.Size = new Size(994, 410);
            driedUsers.TabIndex = 1;
            // 
            // nickname
            // 
            nickname.HeaderText = "Apodo";
            nickname.Name = "nickname";
            // 
            // rol
            // 
            rol.HeaderText = "Rol";
            rol.Name = "rol";
            // 
            // name
            // 
            name.HeaderText = "Nombre";
            name.Name = "name";
            // 
            // data_fisic
            // 
            data_fisic.HeaderText = "Datos Fisicos";
            data_fisic.Name = "data_fisic";
            // 
            // last_expiration
            // 
            last_expiration.HeaderText = "Ultimo Vencimiento";
            last_expiration.Name = "last_expiration";
            // 
            // plan
            // 
            plan.HeaderText = "Plan";
            plan.Name = "plan";
            // 
            // wallet
            // 
            wallet.HeaderText = "Billetera";
            wallet.Name = "wallet";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(16, 8, 23);
            panel2.Controls.Add(rjButton2);
            panel2.Controls.Add(rjTextBox1);
            panel2.Controls.Add(rjButton4);
            panel2.Controls.Add(rjButton3);
            panel2.Controls.Add(rjButton1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 114);
            panel2.TabIndex = 4;
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
            rjButton2.Location = new Point(287, 36);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(50, 50);
            rjButton2.TabIndex = 81;
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
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
            rjTextBox1.Location = new Point(57, 46);
            rjTextBox1.Margin = new Padding(4);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DarkGray;
            rjTextBox1.PlaceholderText = "Ingrese un nombre...";
            rjTextBox1.Size = new Size(208, 31);
            rjTextBox1.TabIndex = 80;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
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
            rjButton4.Location = new Point(572, 36);
            rjButton4.Name = "rjButton4";
            rjButton4.Padding = new Padding(10, 0, 0, 0);
            rjButton4.Size = new Size(188, 53);
            rjButton4.TabIndex = 79;
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
            rjButton3.Location = new Point(775, 36);
            rjButton3.Name = "rjButton3";
            rjButton3.Padding = new Padding(10, 0, 0, 0);
            rjButton3.Size = new Size(188, 53);
            rjButton3.TabIndex = 78;
            rjButton3.Text = "Agregar Plan";
            rjButton3.TextAlign = ContentAlignment.MiddleLeft;
            rjButton3.TextColor = Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(41, 147, 45);
            rjButton1.BackgroundColor = Color.FromArgb(41, 147, 45);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            rjButton1.IconColor = Color.FromArgb(230, 237, 243);
            rjButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton1.ImageAlign = ContentAlignment.MiddleRight;
            rjButton1.Location = new Point(368, 36);
            rjButton1.Name = "rjButton1";
            rjButton1.Padding = new Padding(10, 0, 0, 0);
            rjButton1.Size = new Size(188, 53);
            rjButton1.TabIndex = 65;
            rjButton1.Text = "Agregar Cliente";
            rjButton1.TextAlign = ContentAlignment.MiddleLeft;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // ClientsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(driedUsers);
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "ClientsUserControl";
            Size = new Size(1000, 530);
            ((System.ComponentModel.ISupportInitialize)driedUsers).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView driedUsers;
        private Panel panel1;
        private DataGridViewTextBoxColumn nickname;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn data_fisic;
        private DataGridViewTextBoxColumn last_expiration;
        private DataGridViewTextBoxColumn plan;
        private DataGridViewTextBoxColumn wallet;
        private Panel panel2;
        private ClassCustom.RJButton rjButton1;
        private ClassCustom.RJButton rjButton4;
        private ClassCustom.RJButton rjButton3;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private ClassCustom.RJButton rjButton2;
    }
}
