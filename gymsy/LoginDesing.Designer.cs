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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxPasswordUser
            // 
            textBoxPasswordUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordUser.ForeColor = SystemColors.WindowText;
            textBoxPasswordUser.Location = new Point(70, 236);
            textBoxPasswordUser.Name = "textBoxPasswordUser";
            textBoxPasswordUser.Size = new Size(263, 29);
            textBoxPasswordUser.TabIndex = 4;
            textBoxPasswordUser.TextChanged += textBoxPasswordUser_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 56);
            label1.Name = "label1";
            label1.Size = new Size(237, 30);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el usuario aquí!";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 116);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Correo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(70, 207);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // textBoxEmailUser
            // 
            textBoxEmailUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailUser.Location = new Point(70, 145);
            textBoxEmailUser.Name = "textBoxEmailUser";
            textBoxEmailUser.Size = new Size(263, 29);
            textBoxEmailUser.TabIndex = 3;
            textBoxEmailUser.TextChanged += textBoxEmailUser_TextChanged;
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.DarkOrange;
            buttonSignIn.BackgroundImageLayout = ImageLayout.None;
            buttonSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSignIn.Location = new Point(96, 309);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(185, 56);
            buttonSignIn.TabIndex = 5;
            buttonSignIn.Text = "Iniciar sesión";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(86, 381);
            label4.Name = "label4";
            label4.Size = new Size(195, 25);
            label4.TabIndex = 6;
            label4.Text = "¿Olvido su contraseña?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gymsy2;
            pictureBox1.Location = new Point(370, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // labelErrorEmail
            // 
            labelErrorEmail.AutoSize = true;
            labelErrorEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorEmail.ForeColor = Color.Red;
            labelErrorEmail.Location = new Point(70, 178);
            labelErrorEmail.Name = "labelErrorEmail";
            labelErrorEmail.Size = new Size(72, 25);
            labelErrorEmail.TabIndex = 8;
            labelErrorEmail.Text = "Moficar";
            labelErrorEmail.Visible = false;
            // 
            // labelErrorPassWord
            // 
            labelErrorPassWord.AutoSize = true;
            labelErrorPassWord.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelErrorPassWord.ForeColor = Color.Red;
            labelErrorPassWord.Image = Properties.Resources.x_mark;
            labelErrorPassWord.ImageAlign = ContentAlignment.MiddleLeft;
            labelErrorPassWord.Location = new Point(70, 269);
            labelErrorPassWord.Name = "labelErrorPassWord";
            labelErrorPassWord.Size = new Size(82, 25);
            labelErrorPassWord.TabIndex = 9;
            labelErrorPassWord.Text = "Moficar";
            labelErrorPassWord.TextAlign = ContentAlignment.MiddleRight;
            labelErrorPassWord.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(606, 24);
            button1.Name = "button1";
            button1.Size = new Size(131, 36);
            button1.TabIndex = 10;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = false;
            // 
            // LoginDesing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 0, 40);
            ClientSize = new Size(800, 450);
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
            Name = "LoginDesing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginDesing";
            Load += LoginDesing_Load;
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
    }
}