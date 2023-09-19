namespace gymsy
{
    partial class AuthView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthView));
            textBoxPasswordUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxEmailUser = new TextBox();
            buttonSignIn = new Button();
            pictureBox1 = new PictureBox();
            labelErrorPass = new Label();
            button1 = new Button();
            button2 = new Button();
            labelErrorNickname = new Label();
            Spinner = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Spinner).BeginInit();
            SuspendLayout();
            // 
            // textBoxPasswordUser
            // 
            textBoxPasswordUser.Anchor = AnchorStyles.None;
            textBoxPasswordUser.BackColor = SystemColors.WindowFrame;
            textBoxPasswordUser.BorderStyle = BorderStyle.None;
            textBoxPasswordUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordUser.ForeColor = SystemColors.WindowText;
            textBoxPasswordUser.Location = new Point(19, 243);
            textBoxPasswordUser.MaxLength = 50;
            textBoxPasswordUser.Multiline = true;
            textBoxPasswordUser.Name = "textBoxPasswordUser";
            textBoxPasswordUser.PasswordChar = '*';
            textBoxPasswordUser.Size = new Size(263, 36);
            textBoxPasswordUser.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 65);
            label1.Name = "label1";
            label1.Size = new Size(140, 30);
            label1.TabIndex = 0;
            label1.Text = "Inicia Sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(17, 141);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(255, 15);
            label2.TabIndex = 1;
            label2.Text = "INICIA SESIÓN CON TU NOMBRE DE CUENTA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 222);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // textBoxEmailUser
            // 
            textBoxEmailUser.BackColor = SystemColors.WindowFrame;
            textBoxEmailUser.BorderStyle = BorderStyle.None;
            textBoxEmailUser.Cursor = Cursors.IBeam;
            textBoxEmailUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailUser.Location = new Point(18, 159);
            textBoxEmailUser.MaxLength = 7;
            textBoxEmailUser.Multiline = true;
            textBoxEmailUser.Name = "textBoxEmailUser";
            textBoxEmailUser.Size = new Size(264, 35);
            textBoxEmailUser.TabIndex = 3;
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.DarkCyan;
            buttonSignIn.BackgroundImageLayout = ImageLayout.None;
            buttonSignIn.Cursor = Cursors.Hand;
            buttonSignIn.FlatAppearance.BorderSize = 0;
            buttonSignIn.FlatStyle = FlatStyle.Flat;
            buttonSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignIn.ForeColor = Color.White;
            buttonSignIn.Location = new Point(62, 322);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(185, 38);
            buttonSignIn.TabIndex = 5;
            buttonSignIn.Text = "Iniciar sesión";
            buttonSignIn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(302, 49);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 352);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // labelErrorPass
            // 
            labelErrorPass.AutoSize = true;
            labelErrorPass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorPass.ForeColor = Color.Crimson;
            labelErrorPass.ImageAlign = ContentAlignment.MiddleLeft;
            labelErrorPass.Location = new Point(19, 282);
            labelErrorPass.Name = "labelErrorPass";
            labelErrorPass.Size = new Size(78, 19);
            labelErrorPass.TabIndex = 9;
            labelErrorPass.Text = "Obligatorio";
            labelErrorPass.TextAlign = ContentAlignment.MiddleRight;
            labelErrorPass.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(493, 59);
            button1.Name = "button1";
            button1.Size = new Size(81, 36);
            button1.TabIndex = 10;
            button1.Text = "DEMO";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkCyan;
            button2.Location = new Point(563, 2);
            button2.Name = "button2";
            button2.Size = new Size(28, 42);
            button2.TabIndex = 11;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            // 
            // labelErrorNickname
            // 
            labelErrorNickname.AutoSize = true;
            labelErrorNickname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorNickname.ForeColor = Color.Crimson;
            labelErrorNickname.ImageAlign = ContentAlignment.MiddleLeft;
            labelErrorNickname.Location = new Point(19, 197);
            labelErrorNickname.Name = "labelErrorNickname";
            labelErrorNickname.Size = new Size(78, 19);
            labelErrorNickname.TabIndex = 12;
            labelErrorNickname.Text = "Obligatorio";
            labelErrorNickname.TextAlign = ContentAlignment.MiddleRight;
            labelErrorNickname.Visible = false;
            // 
            // Spinner
            // 
            Spinner.Anchor = AnchorStyles.Top;
            Spinner.Image = (Image)resources.GetObject("Spinner.Image");
            Spinner.Location = new Point(126, 363);
            Spinner.Margin = new Padding(0);
            Spinner.Name = "Spinner";
            Spinner.Size = new Size(41, 38);
            Spinner.SizeMode = PictureBoxSizeMode.Zoom;
            Spinner.TabIndex = 46;
            Spinner.TabStop = false;
            Spinner.Visible = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // AuthView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 0, 15);
            ClientSize = new Size(600, 420);
            Controls.Add(Spinner);
            Controls.Add(labelErrorNickname);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelErrorPass);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSignIn);
            Controls.Add(textBoxPasswordUser);
            Controls.Add(textBoxEmailUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(600, 420);
            Name = "AuthView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginDesing";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Spinner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmailUser;
        private Button buttonSignIn;
        private PictureBox pictureBox1;
        private TextBox textBoxPasswordUser;
        private Label labelErrorPass;
        private Button button1;
        private Button button2;
        private Label labelErrorNickname;
        private PictureBox Spinner;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}