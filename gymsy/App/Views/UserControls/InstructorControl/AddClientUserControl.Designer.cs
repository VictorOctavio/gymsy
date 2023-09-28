namespace gymsy.UserControls
{
    partial class AddClientUserControl
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
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            TBNombreInstructor = new CustomControls.RJControls.RJTextBox();
            TBDescripcion = new CustomControls.RJControls.RJTextBox();
            TBPrecio = new CustomControls.RJControls.RJTextBox();
            rjComboBox1 = new CustomControls.RJControls.RJComboBox();
            BGuardarCliente = new ClassCustom.RJButton();
            LPlanRequerido = new Label();
            label20 = new Label();
            label18 = new Label();
            label16 = new Label();
            label14 = new Label();
            label12 = new Label();
            newClientOrEditClient = new Label();
            panel2 = new Panel();
            LFechaNacimiento = new Label();
            label2 = new Label();
            TBRutaImagen = new CustomControls.RJControls.RJTextBox();
            label23 = new Label();
            RBFemenino = new RadioButton();
            label22 = new Label();
            DPFechaNacimiento = new DateTimePicker();
            RBMasculino = new RadioButton();
            TBContraseña = new CustomControls.RJControls.RJTextBox();
            label17 = new Label();
            LContraseñaRequerido = new Label();
            label15 = new Label();
            TBTelefono = new CustomControls.RJControls.RJTextBox();
            TBUsuario = new CustomControls.RJControls.RJTextBox();
            TBApellido = new CustomControls.RJControls.RJTextBox();
            TBNombre = new CustomControls.RJControls.RJTextBox();
            BTAgregarImagen = new ClassCustom.RJButton();
            label10 = new Label();
            LRuraImagen = new Label();
            IPImagenUsuario = new FontAwesome.Sharp.IconPictureBox();
            label8 = new Label();
            LTelefonoRequerido = new Label();
            LNombreRequerido = new Label();
            label6 = new Label();
            label3 = new Label();
            LCorreoRequerido = new Label();
            LApellidoRequerido = new Label();
            label4 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IPImagenUsuario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1469, 490);
            label1.Name = "label1";
            label1.Size = new Size(277, 37);
            label1.TabIndex = 0;
            label1.Text = "AddClientUserControl";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 8, 23);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(newClientOrEditClient);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = Color.FromArgb(230, 237, 243);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 530);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(TBNombreInstructor);
            panel3.Controls.Add(TBDescripcion);
            panel3.Controls.Add(TBPrecio);
            panel3.Controls.Add(rjComboBox1);
            panel3.Controls.Add(BGuardarCliente);
            panel3.Controls.Add(LPlanRequerido);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(714, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(283, 439);
            panel3.TabIndex = 52;
            // 
            // TBNombreInstructor
            // 
            TBNombreInstructor.BackColor = Color.FromArgb(69, 34, 99);
            TBNombreInstructor.BorderColor = Color.Transparent;
            TBNombreInstructor.BorderFocusColor = Color.HotPink;
            TBNombreInstructor.BorderRadius = 15;
            TBNombreInstructor.BorderSize = 2;
            TBNombreInstructor.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreInstructor.ForeColor = Color.FromArgb(230, 237, 243);
            TBNombreInstructor.Location = new Point(21, 245);
            TBNombreInstructor.Margin = new Padding(4);
            TBNombreInstructor.Multiline = false;
            TBNombreInstructor.Name = "TBNombreInstructor";
            TBNombreInstructor.Padding = new Padding(10, 7, 10, 7);
            TBNombreInstructor.PasswordChar = false;
            TBNombreInstructor.PlaceholderColor = Color.DarkGray;
            TBNombreInstructor.PlaceholderText = "...";
            TBNombreInstructor.Size = new Size(204, 31);
            TBNombreInstructor.TabIndex = 70;
            TBNombreInstructor.Texts = "";
            TBNombreInstructor.UnderlinedStyle = false;
            // 
            // TBDescripcion
            // 
            TBDescripcion.BackColor = Color.FromArgb(69, 34, 99);
            TBDescripcion.BorderColor = Color.Transparent;
            TBDescripcion.BorderFocusColor = Color.HotPink;
            TBDescripcion.BorderRadius = 15;
            TBDescripcion.BorderSize = 2;
            TBDescripcion.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBDescripcion.ForeColor = Color.FromArgb(230, 237, 243);
            TBDescripcion.Location = new Point(21, 178);
            TBDescripcion.Margin = new Padding(4);
            TBDescripcion.Multiline = false;
            TBDescripcion.Name = "TBDescripcion";
            TBDescripcion.Padding = new Padding(10, 7, 10, 7);
            TBDescripcion.PasswordChar = false;
            TBDescripcion.PlaceholderColor = Color.DarkGray;
            TBDescripcion.PlaceholderText = "...";
            TBDescripcion.Size = new Size(204, 31);
            TBDescripcion.TabIndex = 69;
            TBDescripcion.Texts = "";
            TBDescripcion.UnderlinedStyle = false;
            TBDescripcion.KeyPress += TBDescripcion_KeyPress;
            // 
            // TBPrecio
            // 
            TBPrecio.BackColor = Color.FromArgb(69, 34, 99);
            TBPrecio.BorderColor = Color.Transparent;
            TBPrecio.BorderFocusColor = Color.HotPink;
            TBPrecio.BorderRadius = 15;
            TBPrecio.BorderSize = 2;
            TBPrecio.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBPrecio.ForeColor = Color.FromArgb(230, 237, 243);
            TBPrecio.Location = new Point(21, 119);
            TBPrecio.Margin = new Padding(4);
            TBPrecio.Multiline = false;
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Padding = new Padding(10, 7, 10, 7);
            TBPrecio.PasswordChar = false;
            TBPrecio.PlaceholderColor = Color.DarkGray;
            TBPrecio.PlaceholderText = "...";
            TBPrecio.Size = new Size(204, 31);
            TBPrecio.TabIndex = 68;
            TBPrecio.Texts = "";
            TBPrecio.UnderlinedStyle = false;
            TBPrecio.KeyPress += TBPrecio_KeyPress;
            // 
            // rjComboBox1
            // 
            rjComboBox1.BackColor = Color.WhiteSmoke;
            rjComboBox1.BorderColor = Color.MediumSlateBlue;
            rjComboBox1.BorderSize = 1;
            rjComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            rjComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            rjComboBox1.ForeColor = Color.DimGray;
            rjComboBox1.IconColor = Color.MediumSlateBlue;
            rjComboBox1.ListBackColor = Color.FromArgb(230, 228, 245);
            rjComboBox1.ListTextColor = Color.DimGray;
            rjComboBox1.Location = new Point(21, 52);
            rjComboBox1.MinimumSize = new Size(200, 30);
            rjComboBox1.Name = "rjComboBox1";
            rjComboBox1.Padding = new Padding(1);
            rjComboBox1.Size = new Size(219, 30);
            rjComboBox1.TabIndex = 65;
            rjComboBox1.Texts = "";
            // 
            // BGuardarCliente
            // 
            BGuardarCliente.BackColor = Color.FromArgb(41, 147, 45);
            BGuardarCliente.BackgroundColor = Color.FromArgb(41, 147, 45);
            BGuardarCliente.BorderColor = Color.PaleVioletRed;
            BGuardarCliente.BorderRadius = 15;
            BGuardarCliente.BorderSize = 0;
            BGuardarCliente.FlatAppearance.BorderSize = 0;
            BGuardarCliente.FlatStyle = FlatStyle.Flat;
            BGuardarCliente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BGuardarCliente.ForeColor = Color.White;
            BGuardarCliente.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            BGuardarCliente.IconColor = Color.FromArgb(230, 237, 243);
            BGuardarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BGuardarCliente.ImageAlign = ContentAlignment.MiddleRight;
            BGuardarCliente.Location = new Point(21, 369);
            BGuardarCliente.Name = "BGuardarCliente";
            BGuardarCliente.Padding = new Padding(10, 0, 0, 0);
            BGuardarCliente.Size = new Size(188, 53);
            BGuardarCliente.TabIndex = 64;
            BGuardarCliente.Text = "Guardar Cliente";
            BGuardarCliente.TextAlign = ContentAlignment.MiddleLeft;
            BGuardarCliente.TextColor = Color.White;
            BGuardarCliente.UseVisualStyleBackColor = false;
            BGuardarCliente.Click += BGuardarCliente_Click;
            // 
            // LPlanRequerido
            // 
            LPlanRequerido.AutoSize = true;
            LPlanRequerido.ForeColor = Color.Red;
            LPlanRequerido.Location = new Point(32, 85);
            LPlanRequerido.Name = "LPlanRequerido";
            LPlanRequerido.Size = new Size(105, 15);
            LPlanRequerido.TabIndex = 60;
            LPlanRequerido.Text = "*Campo requerido";
            LPlanRequerido.Visible = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.ForeColor = Color.FromArgb(230, 237, 243);
            label20.Location = new Point(21, 219);
            label20.Name = "label20";
            label20.Size = new Size(121, 15);
            label20.TabIndex = 61;
            label20.Text = "Nombre de Instructor";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.ForeColor = Color.FromArgb(230, 237, 243);
            label18.Location = new Point(21, 155);
            label18.Name = "label18";
            label18.Size = new Size(69, 15);
            label18.TabIndex = 58;
            label18.Text = "Descripcion";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.FromArgb(230, 237, 243);
            label16.Location = new Point(21, 100);
            label16.Name = "label16";
            label16.Size = new Size(40, 15);
            label16.TabIndex = 55;
            label16.Text = "Precio";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.FromArgb(230, 237, 243);
            label14.Location = new Point(69, 13);
            label14.Name = "label14";
            label14.Size = new Size(118, 25);
            label14.TabIndex = 53;
            label14.Text = "Asignar plan";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(1323, 112);
            label12.Name = "label12";
            label12.Size = new Size(153, 25);
            label12.TabIndex = 50;
            label12.Text = "Asignale un plan";
            // 
            // newClientOrEditClient
            // 
            newClientOrEditClient.Anchor = AnchorStyles.Top;
            newClientOrEditClient.AutoSize = true;
            newClientOrEditClient.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            newClientOrEditClient.ForeColor = Color.FromArgb(230, 237, 243);
            newClientOrEditClient.Location = new Point(367, 10);
            newClientOrEditClient.Name = "newClientOrEditClient";
            newClientOrEditClient.Size = new Size(263, 52);
            newClientOrEditClient.TabIndex = 33;
            newClientOrEditClient.Text = "Nuevo Cliente";
            // 
            // panel2
            // 
            panel2.Controls.Add(LFechaNacimiento);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(TBRutaImagen);
            panel2.Controls.Add(label23);
            panel2.Controls.Add(RBFemenino);
            panel2.Controls.Add(label22);
            panel2.Controls.Add(DPFechaNacimiento);
            panel2.Controls.Add(RBMasculino);
            panel2.Controls.Add(TBContraseña);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(LContraseñaRequerido);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(TBTelefono);
            panel2.Controls.Add(TBUsuario);
            panel2.Controls.Add(TBApellido);
            panel2.Controls.Add(TBNombre);
            panel2.Controls.Add(BTAgregarImagen);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(LRuraImagen);
            panel2.Controls.Add(IPImagenUsuario);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(LTelefonoRequerido);
            panel2.Controls.Add(LNombreRequerido);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(LCorreoRequerido);
            panel2.Controls.Add(LApellidoRequerido);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(3, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(693, 439);
            panel2.TabIndex = 51;
            // 
            // LFechaNacimiento
            // 
            LFechaNacimiento.AutoSize = true;
            LFechaNacimiento.ForeColor = Color.Red;
            LFechaNacimiento.Location = new Point(262, 102);
            LFechaNacimiento.Name = "LFechaNacimiento";
            LFechaNacimiento.Size = new Size(105, 15);
            LFechaNacimiento.TabIndex = 83;
            LFechaNacimiento.Text = "*Campo requerido";
            LFechaNacimiento.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(230, 237, 243);
            label2.Location = new Point(494, 285);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 82;
            label2.Text = "Ruta de la imagen";
            // 
            // TBRutaImagen
            // 
            TBRutaImagen.BackColor = Color.FromArgb(69, 34, 99);
            TBRutaImagen.BorderColor = Color.Transparent;
            TBRutaImagen.BorderFocusColor = Color.HotPink;
            TBRutaImagen.BorderRadius = 15;
            TBRutaImagen.BorderSize = 2;
            TBRutaImagen.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBRutaImagen.ForeColor = Color.FromArgb(230, 237, 243);
            TBRutaImagen.Location = new Point(485, 304);
            TBRutaImagen.Margin = new Padding(4);
            TBRutaImagen.Multiline = false;
            TBRutaImagen.Name = "TBRutaImagen";
            TBRutaImagen.Padding = new Padding(10, 7, 10, 7);
            TBRutaImagen.PasswordChar = false;
            TBRutaImagen.PlaceholderColor = Color.DarkGray;
            TBRutaImagen.PlaceholderText = "Ruta...";
            TBRutaImagen.Size = new Size(204, 31);
            TBRutaImagen.TabIndex = 81;
            TBRutaImagen.Texts = "";
            TBRutaImagen.UnderlinedStyle = false;
            TBRutaImagen.KeyPress += rjTextBox1_KeyPress;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.ForeColor = Color.FromArgb(230, 237, 243);
            label23.Location = new Point(262, 52);
            label23.Name = "label23";
            label23.Size = new Size(117, 15);
            label23.TabIndex = 80;
            label23.Text = "Fecha de nacimiento";
            // 
            // RBFemenino
            // 
            RBFemenino.AutoSize = true;
            RBFemenino.Location = new Point(125, 301);
            RBFemenino.Name = "RBFemenino";
            RBFemenino.Size = new Size(78, 19);
            RBFemenino.TabIndex = 79;
            RBFemenino.Text = "Femenino";
            RBFemenino.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.ForeColor = Color.FromArgb(230, 237, 243);
            label22.Location = new Point(96, 283);
            label22.Name = "label22";
            label22.Size = new Size(32, 15);
            label22.TabIndex = 78;
            label22.Text = "Sexo";
            // 
            // DPFechaNacimiento
            // 
            DPFechaNacimiento.Format = DateTimePickerFormat.Short;
            DPFechaNacimiento.Location = new Point(262, 71);
            DPFechaNacimiento.Name = "DPFechaNacimiento";
            DPFechaNacimiento.Size = new Size(117, 23);
            DPFechaNacimiento.TabIndex = 77;
            // 
            // RBMasculino
            // 
            RBMasculino.AutoSize = true;
            RBMasculino.Checked = true;
            RBMasculino.Location = new Point(39, 301);
            RBMasculino.Name = "RBMasculino";
            RBMasculino.Size = new Size(80, 19);
            RBMasculino.TabIndex = 76;
            RBMasculino.TabStop = true;
            RBMasculino.Text = "Masculino";
            RBMasculino.UseVisualStyleBackColor = true;
            // 
            // TBContraseña
            // 
            TBContraseña.BackColor = Color.FromArgb(69, 34, 99);
            TBContraseña.BorderColor = Color.Transparent;
            TBContraseña.BorderFocusColor = Color.HotPink;
            TBContraseña.BorderRadius = 15;
            TBContraseña.BorderSize = 2;
            TBContraseña.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBContraseña.ForeColor = Color.FromArgb(230, 237, 243);
            TBContraseña.Location = new Point(262, 216);
            TBContraseña.Margin = new Padding(4);
            TBContraseña.Multiline = false;
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Padding = new Padding(10, 7, 10, 7);
            TBContraseña.PasswordChar = false;
            TBContraseña.PlaceholderColor = Color.DarkGray;
            TBContraseña.PlaceholderText = "Ingrese una contraseña...";
            TBContraseña.Size = new Size(204, 31);
            TBContraseña.TabIndex = 75;
            TBContraseña.Texts = "";
            TBContraseña.UnderlinedStyle = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.FromArgb(230, 237, 243);
            label17.Location = new Point(262, 197);
            label17.Name = "label17";
            label17.Size = new Size(67, 15);
            label17.TabIndex = 74;
            label17.Text = "Contraseña";
            // 
            // LContraseñaRequerido
            // 
            LContraseñaRequerido.AutoSize = true;
            LContraseñaRequerido.ForeColor = Color.Red;
            LContraseñaRequerido.Location = new Point(262, 251);
            LContraseñaRequerido.Name = "LContraseñaRequerido";
            LContraseñaRequerido.Size = new Size(105, 15);
            LContraseñaRequerido.TabIndex = 73;
            LContraseñaRequerido.Text = "*Campo requerido";
            LContraseñaRequerido.Visible = false;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.FromArgb(230, 237, 243);
            label15.Location = new Point(245, 13);
            label15.Name = "label15";
            label15.Size = new Size(155, 25);
            label15.TabIndex = 72;
            label15.Text = "Datos del Cliente";
            // 
            // TBTelefono
            // 
            TBTelefono.BackColor = Color.FromArgb(69, 34, 99);
            TBTelefono.BorderColor = Color.Transparent;
            TBTelefono.BorderFocusColor = Color.HotPink;
            TBTelefono.BorderRadius = 15;
            TBTelefono.BorderSize = 2;
            TBTelefono.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBTelefono.ForeColor = Color.FromArgb(230, 237, 243);
            TBTelefono.Location = new Point(23, 214);
            TBTelefono.Margin = new Padding(4);
            TBTelefono.Multiline = true;
            TBTelefono.Name = "TBTelefono";
            TBTelefono.Padding = new Padding(10, 7, 10, 7);
            TBTelefono.PasswordChar = false;
            TBTelefono.PlaceholderColor = Color.DarkGray;
            TBTelefono.PlaceholderText = "Ingrese un número telefónico...";
            TBTelefono.Size = new Size(204, 31);
            TBTelefono.TabIndex = 70;
            TBTelefono.Texts = "";
            TBTelefono.UnderlinedStyle = false;
            // 
            // TBUsuario
            // 
            TBUsuario.BackColor = Color.FromArgb(69, 34, 99);
            TBUsuario.BorderColor = Color.Transparent;
            TBUsuario.BorderFocusColor = Color.HotPink;
            TBUsuario.BorderRadius = 15;
            TBUsuario.BorderSize = 2;
            TBUsuario.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBUsuario.ForeColor = Color.FromArgb(230, 237, 243);
            TBUsuario.Location = new Point(262, 142);
            TBUsuario.Margin = new Padding(4);
            TBUsuario.Multiline = false;
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Padding = new Padding(10, 7, 10, 7);
            TBUsuario.PasswordChar = false;
            TBUsuario.PlaceholderColor = Color.DarkGray;
            TBUsuario.PlaceholderText = "Ingrese un usuario...";
            TBUsuario.Size = new Size(204, 31);
            TBUsuario.TabIndex = 69;
            TBUsuario.Texts = "";
            TBUsuario.UnderlinedStyle = false;
            // 
            // TBApellido
            // 
            TBApellido.BackColor = Color.FromArgb(69, 34, 99);
            TBApellido.BorderColor = Color.Transparent;
            TBApellido.BorderFocusColor = Color.HotPink;
            TBApellido.BorderRadius = 15;
            TBApellido.BorderSize = 2;
            TBApellido.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBApellido.ForeColor = Color.FromArgb(230, 237, 243);
            TBApellido.Location = new Point(23, 139);
            TBApellido.Margin = new Padding(4);
            TBApellido.Multiline = false;
            TBApellido.Name = "TBApellido";
            TBApellido.Padding = new Padding(10, 7, 10, 7);
            TBApellido.PasswordChar = false;
            TBApellido.PlaceholderColor = Color.DarkGray;
            TBApellido.PlaceholderText = "Ingrese un apellido...";
            TBApellido.Size = new Size(204, 31);
            TBApellido.TabIndex = 68;
            TBApellido.Texts = "";
            TBApellido.UnderlinedStyle = false;
            TBApellido.KeyPress += TBApellido_KeyPress;
            // 
            // TBNombre
            // 
            TBNombre.BackColor = Color.FromArgb(69, 34, 99);
            TBNombre.BorderColor = Color.Transparent;
            TBNombre.BorderFocusColor = Color.HotPink;
            TBNombre.BorderRadius = 15;
            TBNombre.BorderSize = 2;
            TBNombre.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombre.ForeColor = Color.FromArgb(230, 237, 243);
            TBNombre.Location = new Point(23, 69);
            TBNombre.Margin = new Padding(4);
            TBNombre.Multiline = false;
            TBNombre.Name = "TBNombre";
            TBNombre.Padding = new Padding(10, 7, 10, 7);
            TBNombre.PasswordChar = false;
            TBNombre.PlaceholderColor = Color.DarkGray;
            TBNombre.PlaceholderText = "Ingrese un nombre...";
            TBNombre.Size = new Size(204, 31);
            TBNombre.TabIndex = 67;
            TBNombre.Texts = "";
            TBNombre.UnderlinedStyle = false;
            TBNombre.KeyPress += TBNombre_KeyPress;
            // 
            // BTAgregarImagen
            // 
            BTAgregarImagen.BackColor = Color.DarkOrange;
            BTAgregarImagen.BackgroundColor = Color.DarkOrange;
            BTAgregarImagen.BorderColor = Color.PaleVioletRed;
            BTAgregarImagen.BorderRadius = 15;
            BTAgregarImagen.BorderSize = 0;
            BTAgregarImagen.FlatAppearance.BorderSize = 0;
            BTAgregarImagen.FlatStyle = FlatStyle.Flat;
            BTAgregarImagen.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BTAgregarImagen.ForeColor = Color.White;
            BTAgregarImagen.IconChar = FontAwesome.Sharp.IconChar.FileImage;
            BTAgregarImagen.IconColor = Color.FromArgb(230, 237, 243);
            BTAgregarImagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BTAgregarImagen.ImageAlign = ContentAlignment.MiddleRight;
            BTAgregarImagen.Location = new Point(494, 223);
            BTAgregarImagen.Name = "BTAgregarImagen";
            BTAgregarImagen.Padding = new Padding(10, 0, 0, 0);
            BTAgregarImagen.Size = new Size(186, 53);
            BTAgregarImagen.TabIndex = 66;
            BTAgregarImagen.Text = "Agregar Imagen";
            BTAgregarImagen.TextAlign = ContentAlignment.MiddleLeft;
            BTAgregarImagen.TextColor = Color.White;
            BTAgregarImagen.UseVisualStyleBackColor = false;
            BTAgregarImagen.Click += BTAgregarImagen_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(-311, 40);
            label10.Name = "label10";
            label10.Size = new Size(155, 25);
            label10.TabIndex = 48;
            label10.Text = "Datos del Cliente";
            // 
            // LRuraImagen
            // 
            LRuraImagen.AutoSize = true;
            LRuraImagen.ForeColor = Color.Red;
            LRuraImagen.Location = new Point(494, 339);
            LRuraImagen.Name = "LRuraImagen";
            LRuraImagen.Size = new Size(105, 15);
            LRuraImagen.TabIndex = 49;
            LRuraImagen.Text = "*Campo requerido";
            LRuraImagen.Visible = false;
            // 
            // IPImagenUsuario
            // 
            IPImagenUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            IPImagenUsuario.BackColor = Color.FromArgb(16, 8, 23);
            IPImagenUsuario.BackgroundImageLayout = ImageLayout.Center;
            IPImagenUsuario.ForeColor = Color.FromArgb(230, 237, 243);
            IPImagenUsuario.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            IPImagenUsuario.IconColor = Color.FromArgb(230, 237, 243);
            IPImagenUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IPImagenUsuario.IconSize = 159;
            IPImagenUsuario.Location = new Point(494, 50);
            IPImagenUsuario.Name = "IPImagenUsuario";
            IPImagenUsuario.Size = new Size(185, 159);
            IPImagenUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            IPImagenUsuario.TabIndex = 35;
            IPImagenUsuario.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.FromArgb(230, 237, 243);
            label8.Location = new Point(23, 195);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 47;
            label8.Text = "Número telefónico";
            // 
            // LTelefonoRequerido
            // 
            LTelefonoRequerido.AutoSize = true;
            LTelefonoRequerido.ForeColor = Color.Red;
            LTelefonoRequerido.Location = new Point(23, 249);
            LTelefonoRequerido.Name = "LTelefonoRequerido";
            LTelefonoRequerido.Size = new Size(105, 15);
            LTelefonoRequerido.TabIndex = 46;
            LTelefonoRequerido.Text = "*Campo requerido";
            LTelefonoRequerido.Visible = false;
            // 
            // LNombreRequerido
            // 
            LNombreRequerido.AutoSize = true;
            LNombreRequerido.ForeColor = Color.Red;
            LNombreRequerido.Location = new Point(23, 104);
            LNombreRequerido.Name = "LNombreRequerido";
            LNombreRequerido.Size = new Size(105, 15);
            LNombreRequerido.TabIndex = 37;
            LNombreRequerido.Text = "*Campo requerido";
            LNombreRequerido.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(230, 237, 243);
            label6.Location = new Point(262, 123);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 44;
            label6.Text = "Usurio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(230, 237, 243);
            label3.Location = new Point(23, 50);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 38;
            label3.Text = "Nombre";
            // 
            // LCorreoRequerido
            // 
            LCorreoRequerido.AutoSize = true;
            LCorreoRequerido.ForeColor = Color.Red;
            LCorreoRequerido.Location = new Point(262, 177);
            LCorreoRequerido.Name = "LCorreoRequerido";
            LCorreoRequerido.Size = new Size(105, 15);
            LCorreoRequerido.TabIndex = 43;
            LCorreoRequerido.Text = "*Campo requerido";
            LCorreoRequerido.Visible = false;
            // 
            // LApellidoRequerido
            // 
            LApellidoRequerido.AutoSize = true;
            LApellidoRequerido.ForeColor = Color.Red;
            LApellidoRequerido.Location = new Point(23, 174);
            LApellidoRequerido.Name = "LApellidoRequerido";
            LApellidoRequerido.Size = new Size(105, 15);
            LApellidoRequerido.TabIndex = 40;
            LApellidoRequerido.Text = "*Campo requerido";
            LApellidoRequerido.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(230, 237, 243);
            label4.Location = new Point(23, 120);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 41;
            label4.Text = "Apellido";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddClientUserControl
            // 
            Name = "AddClientUserControl";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IPImagenUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label newClientOrEditClient;
        private FontAwesome.Sharp.IconPictureBox IPImagenUsuario;
        private Label LNombreRequerido;
        private Label label4;
        private Label LApellidoRequerido;
        private Label label3;
        private Label label12;
        private Label LRuraImagen;
        private Label label10;
        private Label label8;
        private Label LTelefonoRequerido;
        private Label label6;
        private Label LCorreoRequerido;
        private Panel panel2;
        private Panel panel3;
        private Label label14;
        private Label LPlanRequerido;
        private Label label20;
        private Label label18;
        private Label label16;
        private ClassCustom.RJButton BGuardarCliente;
        private ClassCustom.RJButton BTAgregarImagen;
        private CustomControls.RJControls.RJTextBox TBTelefono;
        private CustomControls.RJControls.RJTextBox TBUsuario;
        private CustomControls.RJControls.RJTextBox TBApellido;
        private CustomControls.RJControls.RJTextBox TBNombre;
        private CustomControls.RJControls.RJComboBox rjComboBox1;
        private CustomControls.RJControls.RJTextBox TBNombreInstructor;
        private CustomControls.RJControls.RJTextBox TBDescripcion;
        private CustomControls.RJControls.RJTextBox TBPrecio;
        private Label label15;
        private CustomControls.RJControls.RJTextBox TBContraseña;
        private Label label17;
        private Label LContraseñaRequerido;
        private Label label23;
        private RadioButton RBFemenino;
        private Label label22;
        private DateTimePicker DPFechaNacimiento;
        private RadioButton RBMasculino;
        private OpenFileDialog openFileDialog1;
        private Label label2;
        private CustomControls.RJControls.RJTextBox TBRutaImagen;
        private Label LFechaNacimiento;
    }
}
