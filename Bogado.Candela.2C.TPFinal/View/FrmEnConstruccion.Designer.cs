namespace View
{
    partial class FrmEnConstruccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnConstruccion));
            lblBienvenido = new Label();
            lblDisculpas = new Label();
            lblEnConstruccion = new Label();
            lblVolver = new Label();
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
            // lblDisculpas
            // 
            lblDisculpas.AutoSize = true;
            lblDisculpas.BackColor = Color.Transparent;
            lblDisculpas.Cursor = Cursors.Hand;
            lblDisculpas.Font = new Font("Consolas", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDisculpas.ForeColor = Color.Magenta;
            lblDisculpas.Location = new Point(426, 387);
            lblDisculpas.Margin = new Padding(4, 0, 4, 0);
            lblDisculpas.Name = "lblDisculpas";
            lblDisculpas.Size = new Size(600, 33);
            lblDisculpas.TabIndex = 4;
            lblDisculpas.Text = "Te pedimos disculpas por las molestias.";
            // 
            // lblEnConstruccion
            // 
            lblEnConstruccion.AutoSize = true;
            lblEnConstruccion.BackColor = Color.Transparent;
            lblEnConstruccion.Cursor = Cursors.Hand;
            lblEnConstruccion.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblEnConstruccion.ForeColor = Color.LawnGreen;
            lblEnConstruccion.Location = new Point(502, 242);
            lblEnConstruccion.Margin = new Padding(4, 0, 4, 0);
            lblEnConstruccion.Name = "lblEnConstruccion";
            lblEnConstruccion.Size = new Size(438, 42);
            lblEnConstruccion.TabIndex = 16;
            lblEnConstruccion.Text = "Sitio en Construcción";
            // 
            // lblVolver
            // 
            lblVolver.AutoSize = true;
            lblVolver.BackColor = Color.Transparent;
            lblVolver.Cursor = Cursors.Hand;
            lblVolver.Font = new Font("Consolas", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblVolver.ForeColor = Color.Yellow;
            lblVolver.Location = new Point(1273, 38);
            lblVolver.Margin = new Padding(4, 0, 4, 0);
            lblVolver.Name = "lblVolver";
            lblVolver.Size = new Size(98, 31);
            lblVolver.TabIndex = 17;
            lblVolver.Text = "Volver";
            lblVolver.Click += lblVolver_Click;
            // 
            // FrmEnConstruccion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1406, 997);
            Controls.Add(lblVolver);
            Controls.Add(lblEnConstruccion);
            Controls.Add(lblDisculpas);
            Controls.Add(lblBienvenido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmEnConstruccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home - Administardores";
            Load += FrmEnConstruccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBienvenido;
        private Label lblDisculpas;
        private Label lblArtistas;
        private Label lblEnConstruccion;
        private Label lblVolver;
    }
}