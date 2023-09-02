namespace gymsy
{
    partial class LoginDesing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginDesing));
            textBoxPasswordUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxEmailUser = new TextBox();
            buttonSignIn = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            labelErrorEmail = new Label();
            labelErrorPassWord = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPasswordUser
            // 
            textBoxPasswordUser.BackColor = SystemColors.WindowFrame;
            textBoxPasswordUser.BorderStyle = BorderStyle.None;
            textBoxPasswordUser.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordUser.ForeColor = SystemColors.WindowText;
            textBoxPasswordUser.Location = new Point(19, 243);
            textBoxPasswordUser.Multiline = true;
            textBoxPasswordUser.Name = "textBoxPasswordUser";
            textBoxPasswordUser.Size = new Size(263, 36);
            textBoxPasswordUser.TabIndex = 4;
            textBoxPasswordUser.TextChanged += textBoxPasswordUser_TextChanged;
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
            label1.Click += label1_Click;
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
            textBoxEmailUser.Cursor = Cursors.Hand;
            textBoxEmailUser.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailUser.Location = new Point(18, 159);
            textBoxEmailUser.MaxLength = 6;
            textBoxEmailUser.Multiline = true;
            textBoxEmailUser.Name = "textBoxEmailUser";
            textBoxEmailUser.Size = new Size(264, 35);
            textBoxEmailUser.TabIndex = 3;
            textBoxEmailUser.TextChanged += textBoxEmailUser_TextChanged;
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
            buttonSignIn.Location = new Point(62, 316);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(185, 38);
            buttonSignIn.TabIndex = 5;
            buttonSignIn.Text = "Iniciar sesión";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(76, 369);
            label4.Name = "label4";
            label4.Size = new Size(150, 19);
            label4.TabIndex = 6;
            label4.Text = "¿Olvido su contraseña?";
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
            // labelErrorEmail
            // 
            labelErrorEmail.AutoSize = true;
            labelErrorEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorEmail.ForeColor = Color.Crimson;
            labelErrorEmail.Location = new Point(19, 196);
            labelErrorEmail.Name = "labelErrorEmail";
            labelErrorEmail.Size = new Size(55, 19);
            labelErrorEmail.TabIndex = 8;
            labelErrorEmail.Text = "Moficar";
            labelErrorEmail.Visible = false;
            // 
            // labelErrorPassWord
            // 
            labelErrorPassWord.AutoSize = true;
            labelErrorPassWord.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorPassWord.ForeColor = Color.Crimson;
            labelErrorPassWord.ImageAlign = ContentAlignment.MiddleLeft;
            labelErrorPassWord.Location = new Point(19, 283);
            labelErrorPassWord.Name = "labelErrorPassWord";
            labelErrorPassWord.Size = new Size(55, 19);
            labelErrorPassWord.TabIndex = 9;
            labelErrorPassWord.Text = "Moficar";
            labelErrorPassWord.TextAlign = ContentAlignment.MiddleRight;
            labelErrorPassWord.Visible = false;
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
            button1.Location = new Point(491, 59);
            button1.Name = "button1";
            button1.Size = new Size(81, 36);
            button1.TabIndex = 10;
            button1.Text = "Ingresar";
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
            button2.Location = new Point(560, 4);
            button2.Name = "button2";
            button2.Size = new Size(25, 34);
            button2.TabIndex = 11;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // LoginDesing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 0, 15);
            ClientSize = new Size(600, 420);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelErrorPassWord);
            Controls.Add(labelErrorEmail);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(buttonSignIn);
            Controls.Add(textBoxPasswordUser);
            Controls.Add(textBoxEmailUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(600, 420);
            Name = "LoginDesing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginDesing";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmailUser;
        private Button buttonSignIn;
        private Label label4;
        private PictureBox pictureBox1;
        private TextBox textBoxPasswordUser;
        private Label labelErrorEmail;
        private Label labelErrorPassWord;
        private Button button1;
        private Button button2;
    }
}