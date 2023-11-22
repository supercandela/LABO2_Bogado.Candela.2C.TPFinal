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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblBuscador = new Label();
            lblVolver = new Label();
            grpBuscarPor = new GroupBox();
            rdbArtista = new RadioButton();
            rdbPelicula = new RadioButton();
            txtBuscador = new TextBox();
            btnBuscar = new Button();
            pnlFondo1 = new Panel();
            lblSinPeliculas = new Label();
            dgvListado = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            Anio = new DataGridViewTextBoxColumn();
            Sinopsis = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            lblLimpiar = new Label();
            grpBuscarPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // lblBuscador
            // 
            lblBuscador.AutoSize = true;
            lblBuscador.BackColor = Color.Transparent;
            lblBuscador.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblBuscador.ForeColor = Color.DeepSkyBlue;
            lblBuscador.Location = new Point(22, 22);
            lblBuscador.Margin = new Padding(4, 0, 4, 0);
            lblBuscador.Name = "lblBuscador";
            lblBuscador.Size = new Size(482, 47);
            lblBuscador.TabIndex = 1;
            lblBuscador.Text = "Buscador de Películas";
            // 
            // lblVolver
            // 
            lblVolver.AutoSize = true;
            lblVolver.BackColor = Color.Transparent;
            lblVolver.Cursor = Cursors.Hand;
            lblVolver.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblVolver.ForeColor = Color.Red;
            lblVolver.Location = new Point(1266, 33);
            lblVolver.Margin = new Padding(4, 0, 4, 0);
            lblVolver.Name = "lblVolver";
            lblVolver.Size = new Size(111, 36);
            lblVolver.TabIndex = 4;
            lblVolver.Text = "Volver";
            lblVolver.Click += lblVolver_Click;
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
            btnBuscar.Cursor = Cursors.Hand;
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
            dgvListado.AllowUserToAddRows = false;
            dgvListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(100, 100, 100);
            dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvListado.BackgroundColor = SystemColors.Desktop;
            dgvListado.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Columns.AddRange(new DataGridViewColumn[] { Titulo, Anio, Sinopsis, Id });
            dgvListado.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListado.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListado.Location = new Point(22, 313);
            dgvListado.Name = "dgvListado";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvListado.RowHeadersVisible = false;
            dgvListado.RowHeadersWidth = 62;
            dgvListado.RowTemplate.Height = 33;
            dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListado.Size = new Size(1353, 671);
            dgvListado.TabIndex = 11;
            dgvListado.CellClick += dgvListado_CellClick;
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
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 150;
            // 
            // lblLimpiar
            // 
            lblLimpiar.AutoSize = true;
            lblLimpiar.BackColor = Color.Transparent;
            lblLimpiar.Cursor = Cursors.Hand;
            lblLimpiar.Font = new Font("Consolas", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblLimpiar.ForeColor = Color.LawnGreen;
            lblLimpiar.Location = new Point(1137, 193);
            lblLimpiar.Margin = new Padding(4, 0, 4, 0);
            lblLimpiar.Name = "lblLimpiar";
            lblLimpiar.Size = new Size(238, 31);
            lblLimpiar.TabIndex = 12;
            lblLimpiar.Text = "Limpiar búsqueda";
            lblLimpiar.Click += lblLimpiar_Click;
            // 
            // FrmSocio_Alquileres
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1406, 996);
            Controls.Add(lblLimpiar);
            Controls.Add(lblSinPeliculas);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(grpBuscarPor);
            Controls.Add(lblVolver);
            Controls.Add(lblBuscador);
            Controls.Add(pnlFondo1);
            Controls.Add(dgvListado);
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
        private Label lblBuscador;
        private Label lblVolver;
        private GroupBox grpBuscarPor;
        private RadioButton rdbArtista;
        private RadioButton rdbPelicula;
        private TextBox txtBuscador;
        private Button btnBuscar;
        private Panel pnlFondo1;
        private Label lblSinPeliculas;
        private DataGridView dgvListado;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Anio;
        private DataGridViewTextBoxColumn Sinopsis;
        private DataGridViewTextBoxColumn Id;
        private Label lblLimpiar;
    }
}