namespace View
{
    partial class FrmAdmin_Usuarios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin_Usuarios));
            lblBienvenido = new Label();
            lblCrear = new Label();
            lblVolver = new Label();
            lblUsuarios = new Label();
            lblEditar = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            lblIsAdmin = new Label();
            chbIsAdmin = new CheckBox();
            btnEliminarUsuario = new Button();
            lblLimpiar = new Label();
            btnBuscar = new Button();
            txtBuscador = new TextBox();
            lblBuscador = new Label();
            lblErrorUsername = new Label();
            lblErrorPassword = new Label();
            lblErrorNombre = new Label();
            lblErrorApellido = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BackColor = Color.Transparent;
            lblBienvenido.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenido.ForeColor = Color.DeepSkyBlue;
            lblBienvenido.Location = new Point(22, 22);
            lblBienvenido.Margin = new Padding(4, 0, 4, 0);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(240, 47);
            lblBienvenido.TabIndex = 1;
            lblBienvenido.Text = "Bienvenid@";
            // 
            // lblCrear
            // 
            lblCrear.AutoSize = true;
            lblCrear.BackColor = Color.Transparent;
            lblCrear.Cursor = Cursors.Hand;
            lblCrear.Font = new Font("Consolas", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblCrear.ForeColor = Color.LawnGreen;
            lblCrear.Location = new Point(169, 185);
            lblCrear.Margin = new Padding(4, 0, 4, 0);
            lblCrear.Name = "lblCrear";
            lblCrear.Size = new Size(378, 40);
            lblCrear.TabIndex = 16;
            lblCrear.Text = "Crear nuevo usuario";
            lblCrear.Click += lblCrear_Click;
            // 
            // lblVolver
            // 
            lblVolver.AutoSize = true;
            lblVolver.BackColor = Color.Transparent;
            lblVolver.Cursor = Cursors.Hand;
            lblVolver.Font = new Font("Consolas", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblVolver.ForeColor = Color.Yellow;
            lblVolver.Location = new Point(1276, 35);
            lblVolver.Margin = new Padding(4, 0, 4, 0);
            lblVolver.Name = "lblVolver";
            lblVolver.Size = new Size(98, 31);
            lblVolver.TabIndex = 17;
            lblVolver.Text = "Volver";
            lblVolver.Click += lblVolver_Click;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.BackColor = Color.Transparent;
            lblUsuarios.Cursor = Cursors.Hand;
            lblUsuarios.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarios.ForeColor = Color.LawnGreen;
            lblUsuarios.Location = new Point(591, 91);
            lblUsuarios.Margin = new Padding(4, 0, 4, 0);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(196, 47);
            lblUsuarios.TabIndex = 18;
            lblUsuarios.Text = "Usuarios";
            // 
            // lblEditar
            // 
            lblEditar.AutoSize = true;
            lblEditar.BackColor = Color.Transparent;
            lblEditar.Cursor = Cursors.Hand;
            lblEditar.Font = new Font("Consolas", 17F, FontStyle.Regular, GraphicsUnit.Point);
            lblEditar.ForeColor = Color.LawnGreen;
            lblEditar.Location = new Point(855, 185);
            lblEditar.Margin = new Padding(4, 0, 4, 0);
            lblEditar.Name = "lblEditar";
            lblEditar.Size = new Size(473, 40);
            lblEditar.TabIndex = 19;
            lblEditar.Text = "Editar usuario existente";
            lblEditar.Click += lblEditar_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Cursor = Cursors.Hand;
            lblUsername.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.LawnGreen;
            lblUsername.Location = new Point(529, 410);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(143, 36);
            lblUsername.TabIndex = 20;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(690, 407);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(441, 36);
            txtUsername.TabIndex = 21;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(690, 496);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(441, 36);
            txtPassword.TabIndex = 23;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Cursor = Cursors.Hand;
            lblPassword.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.LawnGreen;
            lblPassword.Location = new Point(529, 496);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(143, 36);
            lblPassword.TabIndex = 22;
            lblPassword.Text = "Password";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(690, 584);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(441, 36);
            txtNombre.TabIndex = 25;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Cursor = Cursors.Hand;
            lblNombre.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.LawnGreen;
            lblNombre.Location = new Point(561, 584);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(111, 36);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(690, 676);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(441, 36);
            txtApellido.TabIndex = 27;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Cursor = Cursors.Hand;
            lblApellido.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.LawnGreen;
            lblApellido.Location = new Point(529, 676);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(143, 36);
            lblApellido.TabIndex = 26;
            lblApellido.Text = "Apellido";
            // 
            // lblIsAdmin
            // 
            lblIsAdmin.AutoSize = true;
            lblIsAdmin.BackColor = Color.Transparent;
            lblIsAdmin.Cursor = Cursors.Hand;
            lblIsAdmin.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblIsAdmin.ForeColor = Color.LawnGreen;
            lblIsAdmin.Location = new Point(241, 770);
            lblIsAdmin.Margin = new Padding(4, 0, 4, 0);
            lblIsAdmin.Name = "lblIsAdmin";
            lblIsAdmin.Size = new Size(431, 36);
            lblIsAdmin.TabIndex = 28;
            lblIsAdmin.Text = "Tildar si es Administrador";
            // 
            // chbIsAdmin
            // 
            chbIsAdmin.AutoSize = true;
            chbIsAdmin.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            chbIsAdmin.Location = new Point(690, 779);
            chbIsAdmin.Name = "chbIsAdmin";
            chbIsAdmin.Size = new Size(22, 21);
            chbIsAdmin.TabIndex = 29;
            chbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.Red;
            btnEliminarUsuario.CausesValidation = false;
            btnEliminarUsuario.Cursor = Cursors.Hand;
            btnEliminarUsuario.Font = new Font("Consolas", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminarUsuario.ForeColor = SystemColors.ButtonFace;
            btnEliminarUsuario.Location = new Point(1080, 867);
            btnEliminarUsuario.Margin = new Padding(0);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(276, 82);
            btnEliminarUsuario.TabIndex = 30;
            btnEliminarUsuario.Text = "Eliminar usuario";
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // lblLimpiar
            // 
            lblLimpiar.AutoSize = true;
            lblLimpiar.BackColor = Color.Transparent;
            lblLimpiar.Cursor = Cursors.Hand;
            lblLimpiar.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblLimpiar.ForeColor = Color.LawnGreen;
            lblLimpiar.Location = new Point(46, 916);
            lblLimpiar.Margin = new Padding(4, 0, 4, 0);
            lblLimpiar.Name = "lblLimpiar";
            lblLimpiar.Size = new Size(285, 33);
            lblLimpiar.TabIndex = 31;
            lblLimpiar.Text = "Limpiar formulario";
            lblLimpiar.Click += lblLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightGray;
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(1157, 271);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(54, 55);
            btnBuscar.TabIndex = 33;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscador
            // 
            txtBuscador.BorderStyle = BorderStyle.None;
            txtBuscador.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscador.Location = new Point(690, 284);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(441, 33);
            txtBuscador.TabIndex = 32;
            // 
            // lblBuscador
            // 
            lblBuscador.AutoSize = true;
            lblBuscador.BackColor = Color.Transparent;
            lblBuscador.Cursor = Cursors.Hand;
            lblBuscador.Font = new Font("Consolas", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblBuscador.ForeColor = Color.LawnGreen;
            lblBuscador.Location = new Point(401, 278);
            lblBuscador.Margin = new Padding(4, 0, 4, 0);
            lblBuscador.Name = "lblBuscador";
            lblBuscador.Size = new Size(271, 36);
            lblBuscador.TabIndex = 34;
            lblBuscador.Text = "Ingrese username";
            // 
            // lblErrorUsername
            // 
            lblErrorUsername.AutoSize = true;
            lblErrorUsername.BackColor = Color.Transparent;
            lblErrorUsername.Cursor = Cursors.Hand;
            lblErrorUsername.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorUsername.ForeColor = Color.Red;
            lblErrorUsername.Location = new Point(690, 446);
            lblErrorUsername.Margin = new Padding(4, 0, 4, 0);
            lblErrorUsername.Name = "lblErrorUsername";
            lblErrorUsername.Size = new Size(296, 23);
            lblErrorUsername.TabIndex = 35;
            lblErrorUsername.Text = "* Este campo es requerido.";
            // 
            // lblErrorPassword
            // 
            lblErrorPassword.AutoSize = true;
            lblErrorPassword.BackColor = Color.Transparent;
            lblErrorPassword.Cursor = Cursors.Hand;
            lblErrorPassword.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorPassword.ForeColor = Color.Red;
            lblErrorPassword.Location = new Point(690, 535);
            lblErrorPassword.Margin = new Padding(4, 0, 4, 0);
            lblErrorPassword.Name = "lblErrorPassword";
            lblErrorPassword.Size = new Size(296, 23);
            lblErrorPassword.TabIndex = 36;
            lblErrorPassword.Text = "* Este campo es requerido.";
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.BackColor = Color.Transparent;
            lblErrorNombre.Cursor = Cursors.Hand;
            lblErrorNombre.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorNombre.ForeColor = Color.Red;
            lblErrorNombre.Location = new Point(690, 623);
            lblErrorNombre.Margin = new Padding(4, 0, 4, 0);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(296, 23);
            lblErrorNombre.TabIndex = 37;
            lblErrorNombre.Text = "* Este campo es requerido.";
            // 
            // lblErrorApellido
            // 
            lblErrorApellido.AutoSize = true;
            lblErrorApellido.BackColor = Color.Transparent;
            lblErrorApellido.Cursor = Cursors.Hand;
            lblErrorApellido.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblErrorApellido.ForeColor = Color.Red;
            lblErrorApellido.Location = new Point(690, 715);
            lblErrorApellido.Margin = new Padding(4, 0, 4, 0);
            lblErrorApellido.Name = "lblErrorApellido";
            lblErrorApellido.Size = new Size(296, 23);
            lblErrorApellido.TabIndex = 38;
            lblErrorApellido.Text = "* Este campo es requerido.";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.DeepSkyBlue;
            btnConfirmar.CausesValidation = false;
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.Font = new Font("Consolas", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.ForeColor = SystemColors.ButtonFace;
            btnConfirmar.Location = new Point(591, 867);
            btnConfirmar.Margin = new Padding(0);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(276, 82);
            btnConfirmar.TabIndex = 39;
            btnConfirmar.Text = "Confirmar datos";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // FrmAdmin_Usuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1406, 997);
            Controls.Add(btnConfirmar);
            Controls.Add(lblErrorApellido);
            Controls.Add(lblErrorNombre);
            Controls.Add(lblErrorPassword);
            Controls.Add(lblErrorUsername);
            Controls.Add(lblBuscador);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(lblLimpiar);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(chbIsAdmin);
            Controls.Add(lblIsAdmin);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblEditar);
            Controls.Add(lblUsuarios);
            Controls.Add(lblVolver);
            Controls.Add(lblCrear);
            Controls.Add(lblBienvenido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAdmin_Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administradores - Usuarios";
            Load += FrmAdmin_Usuarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBienvenido;
        private PictureBox pcbPoster1;
        private Label lblTopPeliculas;
        private Panel pnlFondo1;
        private Label lblAnio1;
        private Label lblTitulo1;
        private Panel pnlFondo5;
        private Label lblAnio5;
        private Label lblTitulo5;
        private PictureBox pcbPoster5;
        private Panel pnlFondo6;
        private Label lblAnio6;
        private Label lblTitulo6;
        private PictureBox pcbPoster6;
        private Panel pnlFondo2;
        private Label lblAnio2;
        private Label lblTitulo2;
        private PictureBox pcbPoster2;
        private Panel pnlFondo8;
        private Label lblAnio8;
        private Label lblTitulo8;
        private PictureBox pcbPoster8;
        private Panel pnlFondo7;
        private Label lblAnio7;
        private Label lblTitulo7;
        private PictureBox pcbPoster7;
        private Panel pnlFondo4;
        private Label lblAnio4;
        private Label lblTitulo4;
        private PictureBox pcbPoster4;
        private Panel pnlFondo3;
        private Label lblAnio3;
        private Label lblTitulo3;
        private PictureBox pcbPoster3;
        private Label lblAlquilar;
        private Label lblCrear;
        private Label lblVolver;
        private Label lblUsuarios;
        private Label lblEditar;
        private Label lblUsername;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtApellido;
        private Label lblApellido;
        private Label lblIsAdmin;
        private CheckBox chbIsAdmin;
        private Button btnEliminarUsuario;
        private Label lblLimpiar;
        private Button btnBuscar;
        private TextBox txtBuscador;
        private Label lblBuscador;
        private Label lblErrorUsername;
        private Label lblErrorPassword;
        private Label lblErrorNombre;
        private Label lblErrorApellido;
        private Button btnConfirmar;
    }
}