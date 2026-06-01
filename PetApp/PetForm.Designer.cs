namespace PetApp
{
    partial class PetForm
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
            PetPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PetPicture).BeginInit();
            SuspendLayout();
            // 
            // PetPicture
            // 
            PetPicture.Location = new Point(12, 57);
            PetPicture.Name = "PetPicture";
            PetPicture.Size = new Size(352, 340);
            PetPicture.TabIndex = 0;
            PetPicture.TabStop = false;
            PetPicture.Click += pictureBox1_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PetPicture);
            Name = "Form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PetPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox PetPicture;
    }
}
