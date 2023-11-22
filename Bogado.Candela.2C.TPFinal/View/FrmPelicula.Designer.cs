namespace View
{
    partial class FrmPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPelicula));
            lblAnio = new Label();
            lblTitulo = new Label();
            lblAlquilar = new Label();
            pcbPoster = new PictureBox();
            rtbSinopsis = new RichTextBox();
            lblDuracion = new Label();
            lblDireccion = new Label();
            lblActuacion = new Label();
            lblVolver = new Label();
            dtpInicio = new DateTimePicker();
            lblCancelar = new Label();
            lblConfirmar = new Label();
            lblInicio = new Label();
            lblFin = new Label();
            dtpFin = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pcbPoster).BeginInit();
            SuspendLayout();
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.BackColor = SystemColors.ControlText;
            lblAnio.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnio.ForeColor = SystemColors.Control;
            lblAnio.Location = new Point(723, 566);
            lblAnio.Margin = new Padding(4, 0, 4, 0);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(75, 33);
            lblAnio.TabIndex = 1;
            lblAnio.Text = "Año:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoEllipsis = true;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Consolas", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.Magenta;
            lblTitulo.Location = new Point(94, 49);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(152, 47);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Título";
            // 
            // lblAlquilar
            // 
            lblAlquilar.AutoSize = true;
            lblAlquilar.BackColor = Color.Transparent;
            lblAlquilar.Cursor = Cursors.Hand;
            lblAlquilar.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblAlquilar.ForeColor = Color.LawnGreen;
            lblAlquilar.Location = new Point(981, 900);
            lblAlquilar.Margin = new Padding(4, 0, 4, 0);
            lblAlquilar.Name = "lblAlquilar";
            lblAlquilar.Size = new Size(358, 42);
            lblAlquilar.TabIndex = 16;
            lblAlquilar.Text = "Alquilar pelicula";
            lblAlquilar.Click += lblAlquilar_Click;
            // 
            // pcbPoster
            // 
            pcbPoster.Location = new Point(94, 125);
            pcbPoster.Name = "pcbPoster";
            pcbPoster.Size = new Size(531, 720);
            pcbPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pcbPoster.TabIndex = 8;
            pcbPoster.TabStop = false;
            // 
            // rtbSinopsis
            // 
            rtbSinopsis.BackColor = SystemColors.ControlText;
            rtbSinopsis.BorderStyle = BorderStyle.None;
            rtbSinopsis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbSinopsis.ForeColor = SystemColors.Control;
            rtbSinopsis.Location = new Point(705, 125);
            rtbSinopsis.Margin = new Padding(15);
            rtbSinopsis.Name = "rtbSinopsis";
            rtbSinopsis.ReadOnly = true;
            rtbSinopsis.Size = new Size(616, 384);
            rtbSinopsis.TabIndex = 18;
            rtbSinopsis.Text = "Sinopsis";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = SystemColors.ControlText;
            lblDuracion.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDuracion.ForeColor = SystemColors.Control;
            lblDuracion.Location = new Point(723, 622);
            lblDuracion.Margin = new Padding(4, 0, 4, 0);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(150, 33);
            lblDuracion.TabIndex = 19;
            lblDuracion.Text = "Duración:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = SystemColors.ControlText;
            lblDireccion.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDireccion.ForeColor = SystemColors.Control;
            lblDireccion.Location = new Point(723, 678);
            lblDireccion.Margin = new Padding(4, 0, 4, 0);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(165, 33);
            lblDireccion.TabIndex = 20;
            lblDireccion.Text = "Dirección:";
            // 
            // lblActuacion
            // 
            lblActuacion.AutoSize = true;
            lblActuacion.BackColor = SystemColors.ControlText;
            lblActuacion.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblActuacion.ForeColor = SystemColors.Control;
            lblActuacion.Location = new Point(723, 736);
            lblActuacion.Margin = new Padding(4, 0, 4, 0);
            lblActuacion.Name = "lblActuacion";
            lblActuacion.Size = new Size(165, 33);
            lblActuacion.TabIndex = 21;
            lblActuacion.Text = "Actuación:";
            // 
            // lblVolver
            // 
            lblVolver.AutoSize = true;
            lblVolver.BackColor = Color.Transparent;
            lblVolver.Cursor = Cursors.Hand;
            lblVolver.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblVolver.ForeColor = Color.Aqua;
            lblVolver.Location = new Point(80, 900);
            lblVolver.Margin = new Padding(4, 0, 4, 0);
            lblVolver.Name = "lblVolver";
            lblVolver.Size = new Size(138, 42);
            lblVolver.TabIndex = 22;
            lblVolver.Text = "Volver";
            lblVolver.Click += lblVolver_Click;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(1021, 288);
            dtpInicio.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(300, 31);
            dtpInicio.TabIndex = 23;
            // 
            // lblCancelar
            // 
            lblCancelar.AutoSize = true;
            lblCancelar.BackColor = Color.Transparent;
            lblCancelar.Cursor = Cursors.Hand;
            lblCancelar.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCancelar.ForeColor = Color.Aqua;
            lblCancelar.Location = new Point(80, 900);
            lblCancelar.Margin = new Padding(4, 0, 4, 0);
            lblCancelar.Name = "lblCancelar";
            lblCancelar.Size = new Size(178, 42);
            lblCancelar.TabIndex = 25;
            lblCancelar.Text = "Cancelar";
            lblCancelar.Click += lblCancelar_Click;
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.BackColor = Color.Transparent;
            lblConfirmar.Cursor = Cursors.Hand;
            lblConfirmar.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmar.ForeColor = Color.LawnGreen;
            lblConfirmar.Location = new Point(981, 900);
            lblConfirmar.Margin = new Padding(4, 0, 4, 0);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(378, 42);
            lblConfirmar.TabIndex = 24;
            lblConfirmar.Text = "Confirmar alquiler";
            lblConfirmar.Click += lblConfirmar_Click;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.BackColor = SystemColors.ControlText;
            lblInicio.Font = new Font("Consolas", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblInicio.ForeColor = SystemColors.Control;
            lblInicio.Location = new Point(705, 288);
            lblInicio.Margin = new Padding(4, 0, 4, 0);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(294, 31);
            lblInicio.TabIndex = 26;
            lblInicio.Text = "Inicio del Alquiler:";
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.BackColor = SystemColors.ControlText;
            lblFin.Font = new Font("Consolas", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFin.ForeColor = SystemColors.Control;
            lblFin.Location = new Point(705, 354);
            lblFin.Margin = new Padding(4, 0, 4, 0);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(252, 31);
            lblFin.TabIndex = 28;
            lblFin.Text = "Fin del Alquiler:";
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(1021, 354);
            dtpFin.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(300, 31);
            dtpFin.TabIndex = 27;
            // 
            // FrmPelicula
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1406, 996);
            Controls.Add(lblFin);
            Controls.Add(dtpFin);
            Controls.Add(lblInicio);
            Controls.Add(dtpInicio);
            Controls.Add(lblVolver);
            Controls.Add(lblActuacion);
            Controls.Add(lblDireccion);
            Controls.Add(lblDuracion);
            Controls.Add(rtbSinopsis);
            Controls.Add(pcbPoster);
            Controls.Add(lblTitulo);
            Controls.Add(lblAnio);
            Controls.Add(lblAlquilar);
            Controls.Add(lblCancelar);
            Controls.Add(lblConfirmar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pelicula";
            Load += FrmPelicula_Load;
            ((System.ComponentModel.ISupportInitialize)pcbPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAnio;
        private Label lblTitulo;
        private Label lblAlquilar;
        private PictureBox pcbPoster;
        private RichTextBox rtbSinopsis;
        private Label lblDuracion;
        private Label lblDireccion;
        private Label lblActuacion;
        private Label lblVolver;
        private DateTimePicker dtpInicio;
        private Label lblCancelar;
        private Label lblConfirmar;
        private Label lblInicio;
        private Label lblFin;
        private DateTimePicker dtpFin;
    }
}