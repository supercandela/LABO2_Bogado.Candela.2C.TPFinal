namespace View
{
    partial class FrmSocio_Alquileres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSocio_Alquileres));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblBienvenido = new Label();
            lblAlquileres = new Label();
            grpBuscarPor = new GroupBox();
            rdbArtista = new RadioButton();
            rdbPelicula = new RadioButton();
            txtBuscador = new TextBox();
            btnBuscar = new Button();
            pnlFondo1 = new Panel();
            lbxListado = new ListBox();
            lblSinPeliculas = new Label();
            dgvListado = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            Anio = new DataGridViewTextBoxColumn();
            Sinopsis = new DataGridViewTextBoxColumn();
            grpBuscarPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
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
            // lblAlquileres
            // 
            lblAlquileres.AutoSize = true;
            lblAlquileres.BackColor = Color.Transparent;
            lblAlquileres.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlquileres.ForeColor = Color.Red;
            lblAlquileres.Location = new Point(893, 22);
            lblAlquileres.Margin = new Padding(4, 0, 4, 0);
            lblAlquileres.Name = "lblAlquileres";
            lblAlquileres.Size = new Size(482, 47);
            lblAlquileres.TabIndex = 4;
            lblAlquileres.Text = "Buscador de películas";
            // 
            // grpBuscarPor
            // 
            grpBuscarPor.BackColor = Color.Transparent;
            grpBuscarPor.Controls.Add(rdbArtista);
            grpBuscarPor.Controls.Add(rdbPelicula);
            grpBuscarPor.Font = new Font("Consolas", 13F, FontStyle.Bold, GraphicsUnit.Point);
            grpBuscarPor.ForeColor = Color.White;
            grpBuscarPor.Location = new Point(22, 81);
            grpBuscarPor.Name = "grpBuscarPor";
            grpBuscarPor.Size = new Size(621, 103);
            grpBuscarPor.TabIndex = 5;
            grpBuscarPor.TabStop = false;
            grpBuscarPor.Text = "Buscar por:";
            // 
            // rdbArtista
            // 
            rdbArtista.AutoSize = true;
            rdbArtista.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbArtista.Location = new Point(287, 45);
            rdbArtista.Name = "rdbArtista";
            rdbArtista.Size = new Size(271, 32);
            rdbArtista.TabIndex = 1;
            rdbArtista.TabStop = true;
            rdbArtista.Text = "Nombre del Artista";
            rdbArtista.UseVisualStyleBackColor = true;
            // 
            // rdbPelicula
            // 
            rdbPelicula.AutoSize = true;
            rdbPelicula.Checked = true;
            rdbPelicula.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdbPelicula.Location = new Point(64, 45);
            rdbPelicula.Name = "rdbPelicula";
            rdbPelicula.Size = new Size(141, 32);
            rdbPelicula.TabIndex = 0;
            rdbPelicula.TabStop = true;
            rdbPelicula.Text = "Pelicula";
            rdbPelicula.UseVisualStyleBackColor = true;
            // 
            // txtBuscador
            // 
            txtBuscador.Font = new Font("Consolas", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtBuscador.Location = new Point(693, 123);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(604, 38);
            txtBuscador.TabIndex = 6;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightGray;
            btnBuscar.BackgroundImage = (Image)resources.GetObject("btnBuscar.BackgroundImage");
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(1313, 108);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(64, 64);
            btnBuscar.TabIndex = 7;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // pnlFondo1
            // 
            pnlFondo1.BackColor = Color.White;
            pnlFondo1.Location = new Point(685, 109);
            pnlFondo1.Name = "pnlFondo1";
            pnlFondo1.Size = new Size(622, 63);
            pnlFondo1.TabIndex = 8;
            // 
            // lbxListado
            // 
            lbxListado.BackColor = Color.Black;
            lbxListado.BorderStyle = BorderStyle.None;
            lbxListado.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbxListado.ForeColor = Color.White;
            lbxListado.FormattingEnabled = true;
            lbxListado.ItemHeight = 28;
            lbxListado.Location = new Point(22, 313);
            lbxListado.Margin = new Padding(10);
            lbxListado.Name = "lbxListado";
            lbxListado.Size = new Size(1353, 672);
            lbxListado.TabIndex = 9;
            // 
            // lblSinPeliculas
            // 
            lblSinPeliculas.AutoSize = true;
            lblSinPeliculas.BackColor = Color.Transparent;
            lblSinPeliculas.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblSinPeliculas.ForeColor = Color.LawnGreen;
            lblSinPeliculas.Location = new Point(183, 743);
            lblSinPeliculas.Margin = new Padding(4, 0, 4, 0);
            lblSinPeliculas.Name = "lblSinPeliculas";
            lblSinPeliculas.Size = new Size(1054, 47);
            lblSinPeliculas.TabIndex = 10;
            lblSinPeliculas.Text = "No hay películas que coincidan con tu búsqueda.";
            // 
            // dgvListado
            // 
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle1.SelectionForeColor = Color.Red;
            dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListado.BackgroundColor = SystemColors.Desktop;
            dgvListado.BorderStyle = BorderStyle.None;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Columns.AddRange(new DataGridViewColumn[] { Titulo, Anio, Sinopsis });
            dgvListado.Location = new Point(22, 313);
            dgvListado.Name = "dgvListado";
            dgvListado.RowHeadersVisible = false;
            dgvListado.RowHeadersWidth = 62;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Red;
            dgvListado.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvListado.RowTemplate.Height = 33;
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.Size = new Size(1353, 671);
            dgvListado.TabIndex = 11;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Título";
            Titulo.MinimumWidth = 8;
            Titulo.Name = "Titulo";
            Titulo.Width = 350;
            // 
            // Anio
            // 
            Anio.HeaderText = "Año";
            Anio.MinimumWidth = 8;
            Anio.Name = "Anio";
            Anio.Width = 150;
            // 
            // Sinopsis
            // 
            Sinopsis.HeaderText = "Sinopsis";
            Sinopsis.MinimumWidth = 8;
            Sinopsis.Name = "Sinopsis";
            Sinopsis.Width = 820;
            // 
            // FrmSocio_Alquileres
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1406, 996);
            Controls.Add(dgvListado);
            Controls.Add(lblSinPeliculas);
            Controls.Add(lbxListado);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(grpBuscarPor);
            Controls.Add(lblAlquileres);
            Controls.Add(lblBienvenido);
            Controls.Add(pnlFondo1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmSocio_Alquileres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alquileres - Socios";
            Load += FrmSocio_Alquileres_Load;
            grpBuscarPor.ResumeLayout(false);
            grpBuscarPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBienvenido;
        private Label lblAlquileres;
        private GroupBox grpBuscarPor;
        private RadioButton rdbArtista;
        private RadioButton rdbPelicula;
        private TextBox txtBuscador;
        private Button btnBuscar;
        private Panel pnlFondo1;
        private ListBox lbxListado;
        private Label lblSinPeliculas;
        private DataGridView dgvListado;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Anio;
        private DataGridViewTextBoxColumn Sinopsis;
    }
}