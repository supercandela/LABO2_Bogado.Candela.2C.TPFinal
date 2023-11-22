namespace View
{
    partial class FrmHistorial_Alquileres
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorial_Alquileres));
            lblHistorial = new Label();
            lblVolver = new Label();
            dgvListado = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fecha_Inicio = new DataGridViewTextBoxColumn();
            Fecha_Fin = new DataGridViewTextBoxColumn();
            Pelicula = new DataGridViewTextBoxColumn();
            lblGuardar = new Label();
            lblSinPeliculas = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.BackColor = Color.Transparent;
            lblHistorial.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblHistorial.ForeColor = Color.DeepSkyBlue;
            lblHistorial.Location = new Point(22, 22);
            lblHistorial.Margin = new Padding(4, 0, 4, 0);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(526, 47);
            lblHistorial.TabIndex = 1;
            lblHistorial.Text = "Historial de Alquileres";
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
            dgvListado.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha_Inicio, Fecha_Fin, Pelicula });
            dgvListado.Cursor = Cursors.Hand;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvListado.DefaultCellStyle = dataGridViewCellStyle3;
            dgvListado.Location = new Point(24, 196);
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
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 150;
            // 
            // Fecha_Inicio
            // 
            Fecha_Inicio.HeaderText = "Inicio";
            Fecha_Inicio.MinimumWidth = 8;
            Fecha_Inicio.Name = "Fecha_Inicio";
            Fecha_Inicio.Width = 150;
            // 
            // Fecha_Fin
            // 
            Fecha_Fin.HeaderText = "Fin";
            Fecha_Fin.MinimumWidth = 8;
            Fecha_Fin.Name = "Fecha_Fin";
            Fecha_Fin.Width = 150;
            // 
            // Pelicula
            // 
            Pelicula.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Pelicula.HeaderText = "Película";
            Pelicula.MinimumWidth = 8;
            Pelicula.Name = "Pelicula";
            // 
            // lblGuardar
            // 
            lblGuardar.AutoSize = true;
            lblGuardar.BackColor = Color.Transparent;
            lblGuardar.Cursor = Cursors.Hand;
            lblGuardar.Font = new Font("Consolas", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblGuardar.ForeColor = Color.LawnGreen;
            lblGuardar.Location = new Point(1125, 919);
            lblGuardar.Margin = new Padding(4, 0, 4, 0);
            lblGuardar.Name = "lblGuardar";
            lblGuardar.Size = new Size(252, 31);
            lblGuardar.TabIndex = 12;
            lblGuardar.Text = "Guardar historial";
            lblGuardar.Click += lblGuardar_Click;
            // 
            // lblSinPeliculas
            // 
            lblSinPeliculas.AutoSize = true;
            lblSinPeliculas.BackColor = Color.Transparent;
            lblSinPeliculas.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblSinPeliculas.ForeColor = Color.LawnGreen;
            lblSinPeliculas.Location = new Point(361, 512);
            lblSinPeliculas.Margin = new Padding(4, 0, 4, 0);
            lblSinPeliculas.Name = "lblSinPeliculas";
            lblSinPeliculas.Size = new Size(702, 47);
            lblSinPeliculas.TabIndex = 13;
            lblSinPeliculas.Text = "No hay alquileres para mostrar.";
            // 
            // FrmHistorial_Alquileres
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1406, 996);
            Controls.Add(lblSinPeliculas);
            Controls.Add(lblGuardar);
            Controls.Add(lblVolver);
            Controls.Add(lblHistorial);
            Controls.Add(dgvListado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHistorial_Alquileres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alquileres - Socios";
            Load += FrmHistorial_Alquileres_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHistorial;
        private Label lblVolver;
        private DataGridView dgvListado;
        private Label lblGuardar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha_Inicio;
        private DataGridViewTextBoxColumn Fecha_Fin;
        private DataGridViewTextBoxColumn Pelicula;
        private Label lblSinPeliculas;
    }
}