namespace View
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictBoxHome = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictBoxHome).BeginInit();
            SuspendLayout();
            // 
            // pictBoxHome
            // 
            pictBoxHome.Image = (Image)resources.GetObject("pictBoxHome.Image");
            pictBoxHome.InitialImage = null;
            pictBoxHome.Location = new Point(229, 77);
            pictBoxHome.Name = "pictBoxHome";
            pictBoxHome.Size = new Size(650, 443);
            pictBoxHome.SizeMode = PictureBoxSizeMode.Zoom;
            pictBoxHome.TabIndex = 0;
            pictBoxHome.TabStop = false;
            pictBoxHome.Click += pictBoxHome_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 616);
            Controls.Add(pictBoxHome);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictBoxHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictBoxHome;
    }
}