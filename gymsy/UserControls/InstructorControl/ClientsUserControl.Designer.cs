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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            driedUsers = new DataGridView();
            nickname = new DataGridViewTextBoxColumn();
            rol = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            data_fisic = new DataGridViewTextBoxColumn();
            last_expiration = new DataGridViewTextBoxColumn();
            plan = new DataGridViewTextBoxColumn();
            wallet = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            BAddUser = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)driedUsers).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(456, 250);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "ClientuserControl";
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            driedUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            driedUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            driedUsers.Columns.AddRange(new DataGridViewColumn[] { nickname, rol, name, data_fisic, last_expiration, plan, wallet });
            driedUsers.EditMode = DataGridViewEditMode.EditProgrammatically;
            driedUsers.Location = new Point(3, 120);
            driedUsers.Name = "driedUsers";
            driedUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            driedUsers.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            driedUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            driedUsers.RowTemplate.Height = 25;
            driedUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            driedUsers.ShowCellErrors = false;
            driedUsers.Size = new Size(994, 400);
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(40, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 29);
            textBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(BAddUser);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(iconButton1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 114);
            panel2.TabIndex = 4;
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
            // BAddUser
            // 
            BAddUser.BackColor = Color.FromArgb(0, 192, 0);
            BAddUser.FlatStyle = FlatStyle.Flat;
            BAddUser.ForeColor = Color.Transparent;
            BAddUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            BAddUser.IconColor = Color.White;
            BAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BAddUser.IconSize = 60;
            BAddUser.Location = new Point(390, 29);
            BAddUser.Name = "BAddUser";
            BAddUser.Size = new Size(72, 56);
            BAddUser.TabIndex = 4;
            BAddUser.UseVisualStyleBackColor = false;
            // 
            // ClientsUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(driedUsers);
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "ClientsUserControl";
            Size = new Size(1000, 530);
            ((System.ComponentModel.ISupportInitialize)driedUsers).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView driedUsers;
        private TextBox textBox1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DataGridViewTextBoxColumn nickname;
        private DataGridViewTextBoxColumn rol;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn data_fisic;
        private DataGridViewTextBoxColumn last_expiration;
        private DataGridViewTextBoxColumn plan;
        private DataGridViewTextBoxColumn wallet;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton BAddUser;
    }
}
