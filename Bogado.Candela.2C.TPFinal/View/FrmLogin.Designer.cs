namespace View
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            pcbIsologo = new PictureBox();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnSignIn = new Button();
            pcbUser = new PictureBox();
            pcbLock = new PictureBox();
            pnlFondo1 = new Panel();
            pnlFondo2 = new Panel();
            lblCancel = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbIsologo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLock).BeginInit();
            pnlFondo1.SuspendLayout();
            SuspendLayout();
            // 
            // pcbIsologo
            // 
            pcbIsologo.Image = (Image)resources.GetObject("pcbIsologo.Image");
            pcbIsologo.Location = new Point(181, 37);
            pcbIsologo.Name = "pcbIsologo";
            pcbIsologo.Size = new Size(198, 146);
            pcbIsologo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbIsologo.TabIndex = 0;
            pcbIsologo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(6, 11);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingrese su usuario";
            txtUsuario.Size = new Size(383, 36);
            txtUsuario.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(111, 325);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "Ingrese su contraseña";
            txtPass.Size = new Size(383, 36);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.DeepSkyBlue;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.Font = new Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignIn.ForeColor = SystemColors.ButtonFace;
            btnSignIn.Location = new Point(41, 420);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(462, 55);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Ingresar";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // pcbUser
            // 
            pcbUser.Image = (Image)resources.GetObject("pcbUser.Image");
            pcbUser.Location = new Point(41, 224);
            pcbUser.Name = "pcbUser";
            pcbUser.Size = new Size(58, 53);
            pcbUser.SizeMode = PictureBoxSizeMode.Zoom;
            pcbUser.TabIndex = 8;
            pcbUser.TabStop = false;
            // 
            // pcbLock
            // 
            pcbLock.Image = (Image)resources.GetObject("pcbLock.Image");
            pcbLock.Location = new Point(41, 314);
            pcbLock.Name = "pcbLock";
            pcbLock.Size = new Size(58, 53);
            pcbLock.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLock.TabIndex = 9;
            pcbLock.TabStop = false;
            // 
            // pnlFondo1
            // 
            pnlFondo1.BackColor = SystemColors.Window;
            pnlFondo1.Controls.Add(txtUsuario);
            pnlFondo1.Location = new Point(105, 224);
            pnlFondo1.Name = "pnlFondo1";
            pnlFondo1.Size = new Size(395, 53);
            pnlFondo1.TabIndex = 10;
            // 
            // pnlFondo2
            // 
            pnlFondo2.BackColor = SystemColors.Window;
            pnlFondo2.Location = new Point(105, 314);
            pnlFondo2.Name = "pnlFondo2";
            pnlFondo2.Size = new Size(395, 53);
            pnlFondo2.TabIndex = 11;
            // 
            // lblCancel
            // 
            lblCancel.AutoSize = true;
            lblCancel.Cursor = Cursors.Hand;
            lblCancel.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCancel.ForeColor = Color.DeepSkyBlue;
            lblCancel.Location = new Point(210, 497);
            lblCancel.Name = "lblCancel";
            lblCancel.Size = new Size(116, 28);
            lblCancel.TabIndex = 12;
            lblCancel.Text = "Cancelar";
            lblCancel.Click += lblCancel_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(545, 564);
            Controls.Add(lblCancel);
            Controls.Add(pcbLock);
            Controls.Add(pcbUser);
            Controls.Add(btnSignIn);
            Controls.Add(txtPass);
            Controls.Add(pcbIsologo);
            Controls.Add(pnlFondo1);
            Controls.Add(pnlFondo2);
            Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Autenticación de Usuario";
            ((System.ComponentModel.ISupportInitialize)pcbIsologo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLock).EndInit();
            pnlFondo1.ResumeLayout(false);
            pnlFondo1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbIsologo;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnSignIn;
        private PictureBox pcbUser;
        private PictureBox pcbLock;
        private Panel pnlFondo1;
        private Panel pnlFondo2;
        private Label lblCancel;
    }
}