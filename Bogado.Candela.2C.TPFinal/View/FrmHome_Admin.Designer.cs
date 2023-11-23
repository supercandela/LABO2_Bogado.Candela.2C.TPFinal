namespace View
{
    partial class FrmHome_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome_Admin));
            lblBienvenido = new Label();
            lblPeliculas = new Label();
            lblArtistas = new Label();
            lblUsuarios = new Label();
            lblCerrarSesion = new Label();
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
            // lblPeliculas
            // 
            lblPeliculas.AutoSize = true;
            lblPeliculas.BackColor = Color.Transparent;
            lblPeliculas.Cursor = Cursors.Hand;
            lblPeliculas.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeliculas.ForeColor = Color.Magenta;
            lblPeliculas.Location = new Point(617, 409);
            lblPeliculas.Margin = new Padding(4, 0, 4, 0);
            lblPeliculas.Name = "lblPeliculas";
            lblPeliculas.Size = new Size(198, 42);
            lblPeliculas.TabIndex = 4;
            lblPeliculas.Text = "Películas";
            lblPeliculas.Click += lblPeliculas_Click;
            // 
            // lblArtistas
            // 
            lblArtistas.AutoSize = true;
            lblArtistas.BackColor = Color.Transparent;
            lblArtistas.Cursor = Cursors.Hand;
            lblArtistas.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblArtistas.ForeColor = Color.Crimson;
            lblArtistas.Location = new Point(627, 592);
            lblArtistas.Margin = new Padding(4, 0, 4, 0);
            lblArtistas.Name = "lblArtistas";
            lblArtistas.Size = new Size(178, 42);
            lblArtistas.TabIndex = 15;
            lblArtistas.Text = "Artistas";
            lblArtistas.Click += lblArtistas_Click;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.BackColor = Color.Transparent;
            lblUsuarios.Cursor = Cursors.Hand;
            lblUsuarios.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuarios.ForeColor = Color.LawnGreen;
            lblUsuarios.Location = new Point(627, 230);
            lblUsuarios.Margin = new Padding(4, 0, 4, 0);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(178, 42);
            lblUsuarios.TabIndex = 16;
            lblUsuarios.Text = "Usuarios";
            lblUsuarios.Click += lblUsuarios_Click;
            // 
            // lblCerrarSesion
            // 
            lblCerrarSesion.AutoSize = true;
            lblCerrarSesion.BackColor = Color.Transparent;
            lblCerrarSesion.Cursor = Cursors.Hand;
            lblCerrarSesion.Font = new Font("Consolas", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblCerrarSesion.ForeColor = Color.Yellow;
            lblCerrarSesion.Location = new Point(1175, 38);
            lblCerrarSesion.Margin = new Padding(4, 0, 4, 0);
            lblCerrarSesion.Name = "lblCerrarSesion";
            lblCerrarSesion.Size = new Size(196, 31);
            lblCerrarSesion.TabIndex = 17;
            lblCerrarSesion.Text = "Cerrar sesión";
            lblCerrarSesion.Click += lblCerrarSesion_Click;
            // 
            // FrmHome_Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1406, 997);
            Controls.Add(lblCerrarSesion);
            Controls.Add(lblUsuarios);
            Controls.Add(lblArtistas);
            Controls.Add(lblPeliculas);
            Controls.Add(lblBienvenido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHome_Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home - Administardores";
            Load += FrmHome_Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBienvenido;
        private Label lblPeliculas;
        private Label lblArtistas;
        private Label lblUsuarios;
        private Label lblCerrarSesion;
    }
}