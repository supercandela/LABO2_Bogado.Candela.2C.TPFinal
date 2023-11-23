namespace View
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            pictBoxHome = new PictureBox();
            lblBienvenidos = new Label();
            btnIniciarSesion = new Button();
            lblCerrar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictBoxHome).BeginInit();
            SuspendLayout();
            // 
            // pictBoxHome
            // 
            pictBoxHome.Image = (Image)resources.GetObject("pictBoxHome.Image");
            pictBoxHome.InitialImage = null;
            pictBoxHome.Location = new Point(-70, -68);
            pictBoxHome.Name = "pictBoxHome";
            pictBoxHome.Size = new Size(997, 837);
            pictBoxHome.SizeMode = PictureBoxSizeMode.CenterImage;
            pictBoxHome.TabIndex = 0;
            pictBoxHome.TabStop = false;
            // 
            // lblBienvenidos
            // 
            lblBienvenidos.AutoSize = true;
            lblBienvenidos.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenidos.ForeColor = SystemColors.Control;
            lblBienvenidos.Location = new Point(536, 562);
            lblBienvenidos.Margin = new Padding(4, 0, 4, 0);
            lblBienvenidos.Name = "lblBienvenidos";
            lblBienvenidos.Size = new Size(435, 84);
            lblBienvenidos.TabIndex = 1;
            lblBienvenidos.Text = "Bienvenid@";
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.DeepSkyBlue;
            btnIniciarSesion.CausesValidation = false;
            btnIniciarSesion.Cursor = Cursors.Hand;
            btnIniciarSesion.Font = new Font("Consolas", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesion.ForeColor = SystemColors.ButtonFace;
            btnIniciarSesion.Location = new Point(1087, 813);
            btnIniciarSesion.Margin = new Padding(0);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(276, 82);
            btnIniciarSesion.TabIndex = 2;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // lblCerrar
            // 
            lblCerrar.AutoSize = true;
            lblCerrar.BackColor = Color.Transparent;
            lblCerrar.Cursor = Cursors.Hand;
            lblCerrar.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblCerrar.ForeColor = Color.Magenta;
            lblCerrar.Location = new Point(42, 853);
            lblCerrar.Margin = new Padding(4, 0, 4, 0);
            lblCerrar.Name = "lblCerrar";
            lblCerrar.Size = new Size(318, 42);
            lblCerrar.TabIndex = 3;
            lblCerrar.Text = "Cerrar programa";
            lblCerrar.Click += lblCerrar_Click;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1406, 935);
            Controls.Add(lblCerrar);
            Controls.Add(btnIniciarSesion);
            Controls.Add(lblBienvenidos);
            Controls.Add(pictBoxHome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VideoClub - Home";
            ((System.ComponentModel.ISupportInitialize)pictBoxHome).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictBoxHome;
        private Label lblBienvenidos;
        private Button btnIniciarSesion;
        private Label lblCerrar;
    }
}