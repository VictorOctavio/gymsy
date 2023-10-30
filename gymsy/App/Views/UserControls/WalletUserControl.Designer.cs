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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            panelWalletWrapper.Margin = new Padding(4, 5, 4, 5);
            panelWalletWrapper.Name = "panelWalletWrapper";
            panelWalletWrapper.Size = new Size(1550, 1053);
            panelWalletWrapper.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1053, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 1053);
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
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(497, 610);
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
            labelTransactionError.Location = new Point(81, 408);
            labelTransactionError.Margin = new Padding(0);
            labelTransactionError.Name = "labelTransactionError";
            labelTransactionError.Size = new Size(387, 43);
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
            comboBoxInstructors.Location = new Point(81, 348);
            comboBoxInstructors.Margin = new Padding(4, 5, 4, 5);
            comboBoxInstructors.Name = "comboBoxInstructors";
            comboBoxInstructors.Size = new Size(385, 40);
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
            btnNewTransaction.Location = new Point(157, 460);
            btnNewTransaction.Margin = new Padding(0);
            btnNewTransaction.Name = "btnNewTransaction";
            btnNewTransaction.Padding = new Padding(14, 0, 14, 0);
            btnNewTransaction.Size = new Size(227, 82);
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
            rjButton2.Location = new Point(14, 335);
            rjButton2.Margin = new Padding(0);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(71, 78);
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
            rjButton1.Location = new Point(7, 212);
            rjButton1.Margin = new Padding(0);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(71, 78);
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
            label6.Location = new Point(79, 70);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(379, 54);
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
            label11.Location = new Point(76, 302);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(109, 36);
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
            textBoxAmount.Location = new Point(79, 218);
            textBoxAmount.Margin = new Padding(7, 8, 7, 8);
            textBoxAmount.Multiline = true;
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(386, 59);
            textBoxAmount.TabIndex = 11;
            textBoxAmount.KeyPress += TextBoxAmount_KeyPress;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(76, 173);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(98, 36);
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
            panel6.Location = new Point(0, 605);
            panel6.Margin = new Padding(4, 5, 4, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(497, 448);
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
            labelErrorWithdraw.Location = new Point(79, 282);
            labelErrorWithdraw.Margin = new Padding(0);
            labelErrorWithdraw.Name = "labelErrorWithdraw";
            labelErrorWithdraw.Padding = new Padding(7, 0, 0, 0);
            labelErrorWithdraw.Size = new Size(387, 43);
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
            btnNewWithdraw.Location = new Point(157, 332);
            btnNewWithdraw.Margin = new Padding(0);
            btnNewWithdraw.Name = "btnNewWithdraw";
            btnNewWithdraw.Padding = new Padding(14, 0, 29, 0);
            btnNewWithdraw.Size = new Size(227, 82);
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
            label8.Location = new Point(79, 163);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(98, 36);
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
            textBoxWithdraw.Location = new Point(79, 210);
            textBoxWithdraw.Margin = new Padding(7, 8, 7, 8);
            textBoxWithdraw.Multiline = true;
            textBoxWithdraw.Name = "textBoxWithdraw";
            textBoxWithdraw.Size = new Size(386, 59);
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
            rjButton3.Location = new Point(10, 205);
            rjButton3.Margin = new Padding(0);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(71, 78);
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
            label7.Location = new Point(124, 78);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(255, 54);
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
            panel1.Size = new Size(1550, 1053);
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
            PanelInvoiceWallet.Location = new Point(251, 155);
            PanelInvoiceWallet.Margin = new Padding(0);
            PanelInvoiceWallet.MaximumSize = new Size(503, 280);
            PanelInvoiceWallet.Name = "PanelInvoiceWallet";
            PanelInvoiceWallet.Size = new Size(503, 280);
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
            BtnCloseInvoice.Location = new Point(451, 7);
            BtnCloseInvoice.Margin = new Padding(0);
            BtnCloseInvoice.Name = "BtnCloseInvoice";
            BtnCloseInvoice.Size = new Size(44, 42);
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
            label12.Location = new Point(110, 130);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(310, 32);
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
            rjButton4.Location = new Point(77, 182);
            rjButton4.Margin = new Padding(0);
            rjButton4.Name = "rjButton4";
            rjButton4.Padding = new Padding(14, 0, 14, 0);
            rjButton4.Size = new Size(363, 70);
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
            label10.Location = new Point(99, 52);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(339, 54);
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
            panel4.Location = new Point(3, 190);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(454, 287);
            panel4.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkCyan;
            label5.Location = new Point(46, 30);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(160, 41);
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
            label2.Location = new Point(46, 197);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 41);
            label2.TabIndex = 1;
            label2.Text = "ahora";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(368, 91);
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
            label3.Location = new Point(4, 38);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(333, 81);
            label3.TabIndex = 3;
            label3.Text = "Mi Billetera";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 8, 35);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dataGridTransactions);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 520);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.MinimumSize = new Size(0, 533);
            panel3.Name = "panel3";
            panel3.Size = new Size(1550, 533);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(4, 28);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(408, 54);
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
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridTransactions.BackgroundColor = Color.FromArgb(16, 8, 30);
            dataGridTransactions.CausesValidation = false;
            dataGridTransactions.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Transparent;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTransactions.Columns.AddRange(new DataGridViewColumn[] { ID, gridDate, gridType, gridAmount, gridDescription });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridTransactions.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridTransactions.GridColor = Color.Black;
            dataGridTransactions.Location = new Point(0, 112);
            dataGridTransactions.Margin = new Padding(0);
            dataGridTransactions.MultiSelect = false;
            dataGridTransactions.Name = "dataGridTransactions";
            dataGridTransactions.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.IndianRed;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GrayText;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridTransactions.RowHeadersVisible = false;
            dataGridTransactions.RowHeadersWidth = 62;
            dataGridTransactions.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.Padding = new Padding(0, 10, 0, 10);
            dataGridViewCellStyle9.SelectionBackColor = Color.White;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridTransactions.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridTransactions.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(16, 8, 30);
            dataGridTransactions.RowTemplate.DefaultCellStyle.ForeColor = Color.White;
            dataGridTransactions.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            dataGridTransactions.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridTransactions.RowTemplate.Height = 30;
            dataGridTransactions.ScrollBars = ScrollBars.None;
            dataGridTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridTransactions.Size = new Size(1550, 422);
            dataGridTransactions.TabIndex = 2;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.True;
            ID.Visible = false;
            ID.Width = 150;
            // 
            // gridDate
            // 
            gridDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = Color.Transparent;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = Color.Transparent;
            gridDate.DefaultCellStyle = dataGridViewCellStyle3;
            gridDate.HeaderText = "Fecha";
            gridDate.MinimumWidth = 8;
            gridDate.Name = "gridDate";
            gridDate.ReadOnly = true;
            gridDate.Width = 150;
            // 
            // gridType
            // 
            dataGridViewCellStyle4.BackColor = Color.Transparent;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            gridType.DefaultCellStyle = dataGridViewCellStyle4;
            gridType.HeaderText = "Tipo";
            gridType.MinimumWidth = 8;
            gridType.Name = "gridType";
            gridType.ReadOnly = true;
            gridType.Width = 150;
            // 
            // gridAmount
            // 
            dataGridViewCellStyle5.BackColor = Color.Transparent;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = Color.Transparent;
            gridAmount.DefaultCellStyle = dataGridViewCellStyle5;
            gridAmount.HeaderText = "Monto";
            gridAmount.MinimumWidth = 8;
            gridAmount.Name = "gridAmount";
            gridAmount.ReadOnly = true;
            gridAmount.Width = 150;
            // 
            // gridDescription
            // 
            gridDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.BackColor = Color.Transparent;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = Color.Transparent;
            gridDescription.DefaultCellStyle = dataGridViewCellStyle6;
            gridDescription.HeaderText = "Descripcion";
            gridDescription.MinimumWidth = 8;
            gridDescription.Name = "gridDescription";
            gridDescription.ReadOnly = true;
            // 
            // WalletUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelWalletWrapper);
            Margin = new Padding(4, 5, 4, 5);
            Name = "WalletUserControl";
            Size = new Size(1550, 1053);
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
