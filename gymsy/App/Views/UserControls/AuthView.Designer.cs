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
            ButtonSignIn = new Button();
            pictureBox1 = new PictureBox();
            labelErrorPass = new Label();
            button1 = new Button();
            button2 = new Button();
            labelErrorNickname = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            BtnMessageDB = new ClassCustom.RJButton();
            loading_gif = new PictureBox();
            panelWelcome = new Panel();
            label6 = new Label();
            label5 = new Label();
            TBNameUser = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loading_gif).BeginInit();
            panelWelcome.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPasswordUser
            // 
            textBoxPasswordUser.Anchor = AnchorStyles.None;
            textBoxPasswordUser.BackColor = SystemColors.WindowFrame;
            textBoxPasswordUser.BorderStyle = BorderStyle.None;
            textBoxPasswordUser.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPasswordUser.ForeColor = SystemColors.WindowText;
            textBoxPasswordUser.Location = new Point(19, 241);
            textBoxPasswordUser.MaxLength = 50;
            textBoxPasswordUser.Name = "textBoxPasswordUser";
            textBoxPasswordUser.PasswordChar = '*';
            textBoxPasswordUser.Size = new Size(263, 24);
            textBoxPasswordUser.TabIndex = 4;
            textBoxPasswordUser.Text = "instruc";
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
            label2.Location = new Point(17, 139);
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
            label3.Location = new Point(18, 220);
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
            textBoxEmailUser.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailUser.Location = new Point(18, 157);
            textBoxEmailUser.Margin = new Padding(0);
            textBoxEmailUser.MaxLength = 7;
            textBoxEmailUser.Name = "textBoxEmailUser";
            textBoxEmailUser.Size = new Size(264, 24);
            textBoxEmailUser.TabIndex = 3;
            textBoxEmailUser.Text = "instruc";
            // 
            // ButtonSignIn
            // 
            ButtonSignIn.BackColor = Color.DarkCyan;
            ButtonSignIn.BackgroundImageLayout = ImageLayout.None;
            ButtonSignIn.Cursor = Cursors.Hand;
            ButtonSignIn.FlatAppearance.BorderSize = 0;
            ButtonSignIn.FlatAppearance.MouseDownBackColor = Color.DarkCyan;
            ButtonSignIn.FlatAppearance.MouseOverBackColor = Color.DarkCyan;
            ButtonSignIn.FlatStyle = FlatStyle.Flat;
            ButtonSignIn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSignIn.ForeColor = Color.White;
            ButtonSignIn.Location = new Point(62, 305);
            ButtonSignIn.Margin = new Padding(0);
            ButtonSignIn.Name = "ButtonSignIn";
            ButtonSignIn.Size = new Size(185, 38);
            ButtonSignIn.TabIndex = 5;
            ButtonSignIn.Text = "Iniciar sesión";
            ButtonSignIn.UseVisualStyleBackColor = false;
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
            labelErrorPass.Location = new Point(19, 270);
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
            labelErrorNickname.Location = new Point(19, 186);
            labelErrorNickname.Name = "labelErrorNickname";
            labelErrorNickname.Size = new Size(78, 19);
            labelErrorNickname.TabIndex = 12;
            labelErrorNickname.Text = "Obligatorio";
            labelErrorNickname.TextAlign = ContentAlignment.MiddleRight;
            labelErrorNickname.Visible = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // BtnMessageDB
            // 
            BtnMessageDB.BackColor = Color.Transparent;
            BtnMessageDB.BackgroundColor = Color.Transparent;
            BtnMessageDB.BorderColor = Color.Crimson;
            BtnMessageDB.BorderRadius = 12;
            BtnMessageDB.BorderSize = 1;
            BtnMessageDB.FlatAppearance.BorderSize = 0;
            BtnMessageDB.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnMessageDB.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnMessageDB.FlatStyle = FlatStyle.Flat;
            BtnMessageDB.Flip = FontAwesome.Sharp.FlipOrientation.Vertical;
            BtnMessageDB.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMessageDB.ForeColor = Color.Red;
            BtnMessageDB.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            BtnMessageDB.IconColor = Color.Red;
            BtnMessageDB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMessageDB.IconSize = 1;
            BtnMessageDB.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMessageDB.Location = new Point(3, 370);
            BtnMessageDB.Margin = new Padding(0);
            BtnMessageDB.Name = "BtnMessageDB";
            BtnMessageDB.Size = new Size(293, 31);
            BtnMessageDB.TabIndex = 47;
            BtnMessageDB.Text = "Retirar";
            BtnMessageDB.TextColor = Color.Red;
            BtnMessageDB.UseVisualStyleBackColor = false;
            BtnMessageDB.Visible = false;
            // 
            // loading_gif
            // 
            loading_gif.Anchor = AnchorStyles.Top;
            loading_gif.BackColor = Color.Transparent;
            loading_gif.BorderStyle = BorderStyle.FixedSingle;
            loading_gif.ErrorImage = Properties.Resources.output_onlinegiftoolsw;
            loading_gif.Image = Properties.Resources.output_onlinegiftoolsw;
            loading_gif.InitialImage = Properties.Resources.output_onlinegiftoolsw;
            loading_gif.Location = new Point(119, 176);
            loading_gif.Name = "loading_gif";
            loading_gif.Size = new Size(60, 64);
            loading_gif.SizeMode = PictureBoxSizeMode.Zoom;
            loading_gif.TabIndex = 48;
            loading_gif.TabStop = false;
            // 
            // panelWelcome
            // 
            panelWelcome.Anchor = AnchorStyles.Right;
            panelWelcome.BackColor = Color.FromArgb(9, 0, 15);
            panelWelcome.Controls.Add(label6);
            panelWelcome.Controls.Add(label5);
            panelWelcome.Controls.Add(TBNameUser);
            panelWelcome.Controls.Add(loading_gif);
            panelWelcome.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panelWelcome.ForeColor = Color.White;
            panelWelcome.Location = new Point(3, 49);
            panelWelcome.Margin = new Padding(0);
            panelWelcome.Name = "panelWelcome";
            panelWelcome.Size = new Size(297, 352);
            panelWelcome.TabIndex = 49;
            panelWelcome.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkOrange;
            label6.Location = new Point(16, 140);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(267, 16);
            label6.TabIndex = 52;
            label6.Text = "\"Entrena duro, trabaja fuerte, logra tus sueños\"";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(53, 328);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(191, 19);
            label5.TabIndex = 51;
            label5.Text = "Estamos preparando la App ...";
            // 
            // TBNameUser
            // 
            TBNameUser.AutoSize = true;
            TBNameUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TBNameUser.ForeColor = Color.DarkCyan;
            TBNameUser.Location = new Point(58, 90);
            TBNameUser.Margin = new Padding(0);
            TBNameUser.Name = "TBNameUser";
            TBNameUser.Size = new Size(186, 32);
            TBNameUser.TabIndex = 50;
            TBNameUser.Text = "Hola, BRIC     :)";
            // 
            // AuthView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 0, 15);
            ClientSize = new Size(600, 420);
            Controls.Add(panelWelcome);
            Controls.Add(BtnMessageDB);
            Controls.Add(labelErrorNickname);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelErrorPass);
            Controls.Add(pictureBox1);
            Controls.Add(ButtonSignIn);
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
            TransparencyKey = Color.FromArgb(192, 0, 192);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loading_gif).EndInit();
            panelWelcome.ResumeLayout(false);
            panelWelcome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxEmailUser;
        private Button ButtonSignIn;
        private PictureBox pictureBox1;
        private TextBox textBoxPasswordUser;
        private Label labelErrorPass;
        private Button button1;
        private Button button2;
        private Label labelErrorNickname;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ClassCustom.RJButton BtnMessageDB;
        private PictureBox loading_gif;
        private Label label5;
        private Label TBNameUser;
        private Label label6;
        public Panel panelWelcome;
    }
}