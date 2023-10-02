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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            panelWalletWrapper = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            labelTransactionError = new ClassCustom.RJButton();
            comboBoxInstructors = new ComboBox();
            btnNewTransaction = new ClassCustom.RJButton();
            rjButton2 = new ClassCustom.RJButton();
            rjButton1 = new ClassCustom.RJButton();
            label6 = new Label();
            label11 = new Label();
            textBoxAmount = new TextBox();
            label9 = new Label();
            panel6 = new Panel();
            labelErrorWithdraw = new ClassCustom.RJButton();
            btnNewWithdraw = new ClassCustom.RJButton();
            label8 = new Label();
            textBoxWithdraw = new TextBox();
            rjButton3 = new ClassCustom.RJButton();
            label7 = new Label();
            panel1 = new Panel();
            PanelInvoiceWallet = new Panel();
            BtnCloseInvoice = new ClassCustom.RJButton();
            label12 = new Label();
            rjButton4 = new ClassCustom.RJButton();
            label10 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            dataGridTransactions = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            gridDate = new DataGridViewTextBoxColumn();
            gridType = new DataGridViewTextBoxColumn();
            gridAmount = new DataGridViewTextBoxColumn();
            gridDescription = new DataGridViewTextBoxColumn();
            panelWalletWrapper.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            PanelInvoiceWallet.SuspendLayout();
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
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(737, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 632);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(labelTransactionError);
            panel5.Controls.Add(comboBoxInstructors);
            panel5.Controls.Add(btnNewTransaction);
            panel5.Controls.Add(rjButton2);
            panel5.Controls.Add(rjButton1);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(textBoxAmount);
            panel5.Controls.Add(label9);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(348, 366);
            panel5.TabIndex = 38;
            // 
            // labelTransactionError
            // 
            labelTransactionError.BackColor = Color.White;
            labelTransactionError.BackgroundColor = Color.White;
            labelTransactionError.BorderColor = Color.Crimson;
            labelTransactionError.BorderRadius = 12;
            labelTransactionError.BorderSize = 1;
            labelTransactionError.FlatAppearance.BorderSize = 0;
            labelTransactionError.FlatStyle = FlatStyle.Flat;
            labelTransactionError.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            labelTransactionError.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelTransactionError.ForeColor = Color.Red;
            labelTransactionError.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            labelTransactionError.IconColor = Color.Red;
            labelTransactionError.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelTransactionError.IconSize = 1;
            labelTransactionError.ImageAlign = ContentAlignment.MiddleLeft;
            labelTransactionError.Location = new Point(57, 245);
            labelTransactionError.Margin = new Padding(0);
            labelTransactionError.Name = "labelTransactionError";
            labelTransactionError.Size = new Size(271, 26);
            labelTransactionError.TabIndex = 46;
            labelTransactionError.Text = "Retirar";
            labelTransactionError.TextColor = Color.Red;
            labelTransactionError.UseVisualStyleBackColor = false;
            labelTransactionError.Visible = false;
            // 
            // comboBoxInstructors
            // 
            comboBoxInstructors.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxInstructors.FormattingEnabled = true;
            comboBoxInstructors.IntegralHeight = false;
            comboBoxInstructors.Items.AddRange(new object[] { "Instructor1,", "Instructor2,", "Instructor3" });
            comboBoxInstructors.Location = new Point(57, 209);
            comboBoxInstructors.Name = "comboBoxInstructors";
            comboBoxInstructors.Size = new Size(271, 29);
            comboBoxInstructors.TabIndex = 32;
            // 
            // btnNewTransaction
            // 
            btnNewTransaction.BackColor = Color.Green;
            btnNewTransaction.BackgroundColor = Color.Green;
            btnNewTransaction.BorderColor = Color.PaleVioletRed;
            btnNewTransaction.BorderRadius = 12;
            btnNewTransaction.BorderSize = 0;
            btnNewTransaction.Cursor = Cursors.Hand;
            btnNewTransaction.FlatAppearance.BorderSize = 0;
            btnNewTransaction.FlatStyle = FlatStyle.Flat;
            btnNewTransaction.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            btnNewTransaction.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewTransaction.ForeColor = Color.White;
            btnNewTransaction.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            btnNewTransaction.IconColor = Color.White;
            btnNewTransaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewTransaction.IconSize = 30;
            btnNewTransaction.ImageAlign = ContentAlignment.MiddleRight;
            btnNewTransaction.Location = new Point(110, 276);
            btnNewTransaction.Margin = new Padding(0);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Padding = new Padding(10, 0, 10, 0);
            btnNewTransaction.Size = new Size(159, 49);
            btnNewTransaction.TabIndex = 44;
            btnNewTransaction.Text = "Transferir";
            btnNewTransaction.TextAlign = ContentAlignment.MiddleLeft;
            btnNewTransaction.TextColor = Color.White;
            btnNewTransaction.UseVisualStyleBackColor = false;
            btnNewTransaction.Click += BtnNewTransaction_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.Transparent;
            rjButton2.BackgroundColor = Color.Transparent;
            rjButton2.BorderColor = Color.Transparent;
            rjButton2.BorderRadius = 30;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton2.ForeColor = Color.DimGray;
            rjButton2.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            rjButton2.IconColor = Color.Green;
            rjButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton2.IconSize = 40;
            rjButton2.Location = new Point(10, 201);
            rjButton2.Margin = new Padding(0);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(50, 47);
            rjButton2.TabIndex = 43;
            rjButton2.TextColor = Color.DimGray;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.Transparent;
            rjButton1.BackgroundColor = Color.Transparent;
            rjButton1.BorderColor = Color.Transparent;
            rjButton1.BorderRadius = 30;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.DimGray;
            rjButton1.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            rjButton1.IconColor = Color.Green;
            rjButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton1.IconSize = 35;
            rjButton1.Location = new Point(5, 127);
            rjButton1.Margin = new Padding(0);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(50, 47);
            rjButton1.TabIndex = 42;
            rjButton1.TextColor = Color.DimGray;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(55, 42);
            label6.Name = "label6";
            label6.Size = new Size(254, 37);
            label6.TabIndex = 4;
            label6.Text = "Nueva Transferencia";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(53, 181);
            label11.Name = "label11";
            label11.Size = new Size(77, 25);
            label11.TabIndex = 39;
            label11.Text = "Destino:";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Anchor = AnchorStyles.None;
            textBoxAmount.BorderStyle = BorderStyle.FixedSingle;
            textBoxAmount.Cursor = Cursors.Hand;
            textBoxAmount.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAmount.ForeColor = Color.FromArgb(9, 0, 20);
            textBoxAmount.Location = new Point(55, 131);
            textBoxAmount.Margin = new Padding(5);
            textBoxAmount.Multiline = true;
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(271, 36);
            textBoxAmount.TabIndex = 11;
            textBoxAmount.KeyPress += TextBoxAmount_KeyPress;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(53, 104);
            label9.Name = "label9";
            label9.Size = new Size(69, 25);
            label9.TabIndex = 1;
            label9.Text = "Monto";
            // 
            // panel6
            // 
            panel6.Controls.Add(labelErrorWithdraw);
            panel6.Controls.Add(btnNewWithdraw);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(textBoxWithdraw);
            panel6.Controls.Add(rjButton3);
            panel6.Controls.Add(label7);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 363);
            panel6.Name = "panel6";
            panel6.Size = new Size(348, 269);
            panel6.TabIndex = 43;
            // 
            // labelErrorWithdraw
            // 
            labelErrorWithdraw.BackColor = Color.White;
            labelErrorWithdraw.BackgroundColor = Color.White;
            labelErrorWithdraw.BorderColor = Color.Crimson;
            labelErrorWithdraw.BorderRadius = 12;
            labelErrorWithdraw.BorderSize = 1;
            labelErrorWithdraw.FlatAppearance.BorderSize = 0;
            labelErrorWithdraw.FlatStyle = FlatStyle.Flat;
            labelErrorWithdraw.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            labelErrorWithdraw.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorWithdraw.ForeColor = Color.Red;
            labelErrorWithdraw.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            labelErrorWithdraw.IconColor = Color.Red;
            labelErrorWithdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            labelErrorWithdraw.IconSize = 1;
            labelErrorWithdraw.ImageAlign = ContentAlignment.MiddleLeft;
            labelErrorWithdraw.Location = new Point(55, 169);
            labelErrorWithdraw.Margin = new Padding(0);
            labelErrorWithdraw.Name = "labelErrorWithdraw";
            labelErrorWithdraw.Padding = new Padding(5, 0, 0, 0);
            labelErrorWithdraw.Size = new Size(271, 26);
            labelErrorWithdraw.TabIndex = 47;
            labelErrorWithdraw.Text = "Retirar";
            labelErrorWithdraw.TextColor = Color.Red;
            labelErrorWithdraw.UseVisualStyleBackColor = false;
            labelErrorWithdraw.Visible = false;
            // 
            // btnNewWithdraw
            // 
            btnNewWithdraw.BackColor = Color.Green;
            btnNewWithdraw.BackgroundColor = Color.Green;
            btnNewWithdraw.BorderColor = Color.PaleVioletRed;
            btnNewWithdraw.BorderRadius = 12;
            btnNewWithdraw.BorderSize = 0;
            btnNewWithdraw.Cursor = Cursors.Hand;
            btnNewWithdraw.FlatAppearance.BorderSize = 0;
            btnNewWithdraw.FlatStyle = FlatStyle.Flat;
            btnNewWithdraw.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            btnNewWithdraw.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewWithdraw.ForeColor = Color.White;
            btnNewWithdraw.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            btnNewWithdraw.IconColor = Color.White;
            btnNewWithdraw.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNewWithdraw.IconSize = 30;
            btnNewWithdraw.ImageAlign = ContentAlignment.MiddleLeft;
            btnNewWithdraw.Location = new Point(110, 199);
            btnNewWithdraw.Margin = new Padding(0);
            btnNewWithdraw.Name = "btnNewWithdraw";
            btnNewWithdraw.Padding = new Padding(10, 0, 20, 0);
            btnNewWithdraw.Size = new Size(159, 49);
            btnNewWithdraw.TabIndex = 45;
            btnNewWithdraw.Text = "Retirar";
            btnNewWithdraw.TextAlign = ContentAlignment.MiddleRight;
            btnNewWithdraw.TextColor = Color.White;
            btnNewWithdraw.UseVisualStyleBackColor = false;
            btnNewWithdraw.Click += BtnNewWithdraw_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(55, 98);
            label8.Name = "label8";
            label8.Size = new Size(69, 25);
            label8.TabIndex = 44;
            label8.Text = "Monto";
            // 
            // textBoxWithdraw
            // 
            textBoxWithdraw.Anchor = AnchorStyles.None;
            textBoxWithdraw.BorderStyle = BorderStyle.FixedSingle;
            textBoxWithdraw.Cursor = Cursors.Hand;
            textBoxWithdraw.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWithdraw.ForeColor = Color.FromArgb(9, 0, 20);
            textBoxWithdraw.Location = new Point(55, 126);
            textBoxWithdraw.Margin = new Padding(5);
            textBoxWithdraw.Multiline = true;
            textBoxWithdraw.Name = "textBoxWithdraw";
            textBoxWithdraw.Size = new Size(271, 36);
            textBoxWithdraw.TabIndex = 44;
            textBoxWithdraw.KeyPress += TextBoxAmount_KeyPress;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.Transparent;
            rjButton3.BackgroundColor = Color.Transparent;
            rjButton3.BorderColor = Color.Transparent;
            rjButton3.BorderRadius = 30;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton3.ForeColor = Color.DimGray;
            rjButton3.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            rjButton3.IconColor = Color.Green;
            rjButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton3.IconSize = 35;
            rjButton3.Location = new Point(7, 123);
            rjButton3.Margin = new Padding(0);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(50, 47);
            rjButton3.TabIndex = 43;
            rjButton3.TextColor = Color.DimGray;
            rjButton3.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(87, 47);
            label7.Name = "label7";
            label7.Size = new Size(172, 37);
            label7.TabIndex = 5;
            label7.Text = "Nuevo Retiro";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(PanelInvoiceWallet);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1085, 632);
            panel1.TabIndex = 0;
            // 
            // PanelInvoiceWallet
            // 
            PanelInvoiceWallet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelInvoiceWallet.AutoSize = true;
            PanelInvoiceWallet.BackColor = Color.White;
            PanelInvoiceWallet.BorderStyle = BorderStyle.FixedSingle;
            PanelInvoiceWallet.Controls.Add(BtnCloseInvoice);
            PanelInvoiceWallet.Controls.Add(label12);
            PanelInvoiceWallet.Controls.Add(rjButton4);
            PanelInvoiceWallet.Controls.Add(label10);
            PanelInvoiceWallet.Location = new Point(176, 93);
            PanelInvoiceWallet.Margin = new Padding(0);
            PanelInvoiceWallet.MaximumSize = new Size(353, 169);
            PanelInvoiceWallet.Name = "PanelInvoiceWallet";
            PanelInvoiceWallet.Size = new Size(353, 169);
            PanelInvoiceWallet.TabIndex = 5;
            PanelInvoiceWallet.Visible = false;
            // 
            // BtnCloseInvoice
            // 
            BtnCloseInvoice.Anchor = AnchorStyles.None;
            BtnCloseInvoice.BackColor = Color.Crimson;
            BtnCloseInvoice.BackgroundColor = Color.Crimson;
            BtnCloseInvoice.BorderColor = Color.PaleVioletRed;
            BtnCloseInvoice.BorderRadius = 3;
            BtnCloseInvoice.BorderSize = 0;
            BtnCloseInvoice.Cursor = Cursors.Hand;
            BtnCloseInvoice.FlatAppearance.BorderSize = 0;
            BtnCloseInvoice.FlatStyle = FlatStyle.Flat;
            BtnCloseInvoice.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            BtnCloseInvoice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCloseInvoice.ForeColor = Color.White;
            BtnCloseInvoice.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            BtnCloseInvoice.IconColor = Color.White;
            BtnCloseInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCloseInvoice.IconSize = 20;
            BtnCloseInvoice.Location = new Point(316, 4);
            BtnCloseInvoice.Margin = new Padding(0);
            BtnCloseInvoice.Name = "BtnCloseInvoice";
            BtnCloseInvoice.Size = new Size(31, 25);
            BtnCloseInvoice.TabIndex = 49;
            BtnCloseInvoice.TextAlign = ContentAlignment.MiddleLeft;
            BtnCloseInvoice.TextColor = Color.White;
            BtnCloseInvoice.UseVisualStyleBackColor = false;
            BtnCloseInvoice.Click += BtnCloseInvoice_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkOrange;
            label12.Location = new Point(77, 78);
            label12.Name = "label12";
            label12.Size = new Size(201, 21);
            label12.TabIndex = 48;
            label12.Text = "Descripcion de la operacion";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rjButton4
            // 
            rjButton4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rjButton4.BackColor = Color.DarkOrange;
            rjButton4.BackgroundColor = Color.DarkOrange;
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 12;
            rjButton4.BorderSize = 0;
            rjButton4.Cursor = Cursors.Hand;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            rjButton4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton4.ForeColor = Color.White;
            rjButton4.IconChar = FontAwesome.Sharp.IconChar.Download;
            rjButton4.IconColor = Color.White;
            rjButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton4.IconSize = 30;
            rjButton4.ImageAlign = ContentAlignment.MiddleRight;
            rjButton4.Location = new Point(54, 109);
            rjButton4.Margin = new Padding(0);
            rjButton4.Name = "rjButton4";
            rjButton4.Padding = new Padding(10, 0, 10, 0);
            rjButton4.Size = new Size(254, 42);
            rjButton4.TabIndex = 47;
            rjButton4.Text = "Descargar Comprobante";
            rjButton4.TextAlign = ContentAlignment.MiddleLeft;
            rjButton4.TextColor = Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.ImageAlign = ContentAlignment.MiddleLeft;
            label10.Location = new Point(69, 31);
            label10.Name = "label10";
            label10.Size = new Size(230, 37);
            label10.TabIndex = 47;
            label10.Text = "Operacion Exitosa";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Left;
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(2, 114);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 174);
            panel4.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(32, 18);
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
            label2.Location = new Point(32, 118);
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
            label1.Font = new Font("DejaVu Sans Condensed", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 55);
            label1.Name = "label1";
            label1.Size = new Size(252, 61);
            label1.TabIndex = 0;
            label1.Text = "$ 128984";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(3, 23);
            label3.Name = "label3";
            label3.Size = new Size(223, 54);
            label3.TabIndex = 3;
            label3.Text = "Mi Billetera";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 8, 30);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dataGridTransactions);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 312);
            panel3.MinimumSize = new Size(0, 320);
            panel3.Name = "panel3";
            panel3.Size = new Size(1085, 320);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(276, 37);
            label4.TabIndex = 4;
            label4.Text = "Ultimas Transacciones";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridTransactions
            // 
            dataGridTransactions.AllowUserToAddRows = false;
            dataGridTransactions.AllowUserToDeleteRows = false;
            dataGridTransactions.AllowUserToResizeColumns = false;
            dataGridTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = Color.Transparent;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTransactions.BackgroundColor = Color.FromArgb(16, 8, 30);
            dataGridTransactions.CausesValidation = false;
            dataGridTransactions.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.Transparent;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = Color.White;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTransactions.Columns.AddRange(new DataGridViewColumn[] { ID, gridDate, gridType, gridAmount, gridDescription });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle16.SelectionForeColor = Color.White;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            dataGridTransactions.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridTransactions.GridColor = Color.Black;
            dataGridTransactions.Location = new Point(0, 67);
            dataGridTransactions.Margin = new Padding(0);
            dataGridTransactions.MultiSelect = false;
            dataGridTransactions.Name = "dataGridTransactions";
            dataGridTransactions.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.IndianRed;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = SystemColors.GrayText;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            dataGridTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridTransactions.RowHeadersVisible = false;
            dataGridTransactions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle18.SelectionBackColor = Color.White;
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dataGridTransactions.RowsDefaultCellStyle = dataGridViewCellStyle18;
            dataGridTransactions.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            dataGridTransactions.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridTransactions.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridTransactions.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridTransactions.RowTemplate.Height = 30;
            dataGridTransactions.ScrollBars = ScrollBars.None;
            dataGridTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTransactions.Size = new Size(1085, 253);
            dataGridTransactions.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.True;
            ID.Visible = false;
            // 
            // gridDate
            // 
            gridDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.BackColor = Color.Transparent;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle12.SelectionForeColor = Color.Transparent;
            gridDate.DefaultCellStyle = dataGridViewCellStyle12;
            gridDate.HeaderText = "Fecha";
            gridDate.Name = "gridDate";
            gridDate.ReadOnly = true;
            // 
            // gridType
            // 
            dataGridViewCellStyle13.BackColor = Color.Transparent;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = Color.White;
            gridType.DefaultCellStyle = dataGridViewCellStyle13;
            gridType.HeaderText = "Tipo";
            gridType.Name = "gridType";
            gridType.ReadOnly = true;
            // 
            // gridAmount
            // 
            dataGridViewCellStyle14.BackColor = Color.Transparent;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = Color.Transparent;
            gridAmount.DefaultCellStyle = dataGridViewCellStyle14;
            gridAmount.HeaderText = "Monto";
            gridAmount.Name = "gridAmount";
            gridAmount.ReadOnly = true;
            // 
            // gridDescription
            // 
            gridDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.BackColor = Color.Transparent;
            dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = Color.Transparent;
            gridDescription.DefaultCellStyle = dataGridViewCellStyle15;
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
            PanelInvoiceWallet.ResumeLayout(false);
            PanelInvoiceWallet.PerformLayout();
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
        private Label label3;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Panel panel5;
        private Label label8;
        private TextBox textBoxAmount;
        private Label label9;
        private Label label11;
        private ComboBox comboBoxInstructors;
        private Panel panel6;
        private ClassCustom.RJButton rjButton1;
        private ClassCustom.RJButton rjButton2;
        private TextBox textBoxWithdraw;
        private ClassCustom.RJButton rjButton3;
        private ClassCustom.RJButton btnNewWithdraw;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn gridDate;
        private DataGridViewTextBoxColumn gridType;
        private DataGridViewTextBoxColumn gridAmount;
        private DataGridViewTextBoxColumn gridDescription;
        private ClassCustom.RJButton labelTransactionError;
        private ClassCustom.RJButton labelErrorWithdraw;
        private Panel PanelInvoiceWallet;
        private Label label10;
        private Label label12;
        private ClassCustom.RJButton rjButton4;
        private ClassCustom.RJButton btnNewTransaction;
        private ClassCustom.RJButton BtnCloseInvoice;
    }
}
