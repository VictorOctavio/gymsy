namespace gymsy.App.Views.UserControls.AdminControls
{
    partial class adminControl
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
            panel1 = new Panel();
            rjButton1 = new ClassCustom.RJButton();
            label2 = new Label();
            BBuscarArchivo = new ClassCustom.RJButton();
            label20 = new Label();
            TBRutaArchivo = new TextBox();
            BGuardarBackUp = new ClassCustom.RJButton();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(rjButton1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(BBuscarArchivo);
            panel1.Controls.Add(label20);
            panel1.Controls.Add(TBRutaArchivo);
            panel1.Controls.Add(BGuardarBackUp);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(230, 237, 243);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 0;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(0, 0, 192);
            rjButton1.BackgroundColor = Color.FromArgb(0, 0, 192);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rjButton1.ForeColor = Color.White;
            rjButton1.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            rjButton1.IconColor = Color.FromArgb(230, 237, 243);
            rjButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            rjButton1.IconSize = 45;
            rjButton1.ImageAlign = ContentAlignment.MiddleRight;
            rjButton1.Location = new Point(390, 200);
            rjButton1.Name = "rjButton1";
            rjButton1.Padding = new Padding(10, 0, 0, 0);
            rjButton1.Size = new Size(186, 61);
            rjButton1.TabIndex = 95;
            rjButton1.Text = "Restaurar";
            rjButton1.TextAlign = ContentAlignment.MiddleLeft;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(378, 73);
            label2.Name = "label2";
            label2.Size = new Size(269, 30);
            label2.TabIndex = 94;
            label2.Text = "Buscar copia de seguridad";
            // 
            // BBuscarArchivo
            // 
            BBuscarArchivo.BackColor = Color.DarkOrange;
            BBuscarArchivo.BackgroundColor = Color.DarkOrange;
            BBuscarArchivo.BorderColor = Color.PaleVioletRed;
            BBuscarArchivo.BorderRadius = 25;
            BBuscarArchivo.BorderSize = 0;
            BBuscarArchivo.FlatAppearance.BorderSize = 0;
            BBuscarArchivo.FlatStyle = FlatStyle.Flat;
            BBuscarArchivo.ForeColor = Color.White;
            BBuscarArchivo.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BBuscarArchivo.IconColor = Color.White;
            BBuscarArchivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BBuscarArchivo.IconSize = 30;
            BBuscarArchivo.Location = new Point(582, 143);
            BBuscarArchivo.Name = "BBuscarArchivo";
            BBuscarArchivo.Size = new Size(50, 50);
            BBuscarArchivo.TabIndex = 93;
            BBuscarArchivo.TextColor = Color.White;
            BBuscarArchivo.UseVisualStyleBackColor = false;
            BBuscarArchivo.Click += BBuscarArchivo_Click_1;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.FromArgb(230, 237, 243);
            label20.Location = new Point(378, 119);
            label20.Name = "label20";
            label20.Size = new Size(236, 21);
            label20.TabIndex = 92;
            label20.Text = "Ruta de restauracion con backup";
            // 
            // TBRutaArchivo
            // 
            TBRutaArchivo.BackColor = Color.FromArgb(69, 34, 99);
            TBRutaArchivo.BorderStyle = BorderStyle.None;
            TBRutaArchivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBRutaArchivo.ForeColor = Color.FromArgb(230, 237, 243);
            TBRutaArchivo.Location = new Point(390, 156);
            TBRutaArchivo.Name = "TBRutaArchivo";
            TBRutaArchivo.PlaceholderText = "...";
            TBRutaArchivo.ReadOnly = true;
            TBRutaArchivo.Size = new Size(186, 22);
            TBRutaArchivo.TabIndex = 91;
            // 
            // BGuardarBackUp
            // 
            BGuardarBackUp.BackColor = Color.FromArgb(41, 147, 45);
            BGuardarBackUp.BackgroundColor = Color.FromArgb(41, 147, 45);
            BGuardarBackUp.BorderColor = Color.PaleVioletRed;
            BGuardarBackUp.BorderRadius = 15;
            BGuardarBackUp.BorderSize = 0;
            BGuardarBackUp.FlatAppearance.BorderSize = 0;
            BGuardarBackUp.FlatStyle = FlatStyle.Flat;
            BGuardarBackUp.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardarBackUp.ForeColor = Color.White;
            BGuardarBackUp.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            BGuardarBackUp.IconColor = Color.FromArgb(230, 237, 243);
            BGuardarBackUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BGuardarBackUp.IconSize = 45;
            BGuardarBackUp.ImageAlign = ContentAlignment.MiddleRight;
            BGuardarBackUp.Location = new Point(137, 184);
            BGuardarBackUp.Name = "BGuardarBackUp";
            BGuardarBackUp.Padding = new Padding(10, 0, 0, 0);
            BGuardarBackUp.Size = new Size(160, 65);
            BGuardarBackUp.TabIndex = 90;
            BGuardarBackUp.Text = "Crear Nueva Copia";
            BGuardarBackUp.TextAlign = ContentAlignment.MiddleLeft;
            BGuardarBackUp.TextColor = Color.White;
            BGuardarBackUp.UseVisualStyleBackColor = false;
            BGuardarBackUp.Click += BAgregarCliente_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(121, 73);
            label1.Name = "label1";
            label1.Size = new Size(202, 30);
            label1.TabIndex = 0;
            label1.Text = "Copia de seguridad";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // adminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "adminControl";
            Size = new Size(1000, 530);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ClassCustom.RJButton BGuardarBackUp;
        private OpenFileDialog openFileDialog1;
        private TextBox TBRutaArchivo;
        private Label label20;
        private ClassCustom.RJButton BBuscarArchivo;
        private Label label2;
        private ClassCustom.RJButton rjButton1;
    }
}
