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
            Btn_Feed = new Button();
            Btn_PetMe = new Button();
            Btn_NamePet = new Button();
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
            // Btn_Feed
            // 
            Btn_Feed.Location = new Point(535, 57);
            Btn_Feed.Name = "Btn_Feed";
            Btn_Feed.Size = new Size(75, 23);
            Btn_Feed.TabIndex = 1;
            Btn_Feed.Text = "Feed Me!";
            Btn_Feed.UseVisualStyleBackColor = true;
            Btn_Feed.Click += Btn_Feed_Click;
            // 
            // Btn_PetMe
            // 
            Btn_PetMe.Location = new Point(535, 234);
            Btn_PetMe.Name = "Btn_PetMe";
            Btn_PetMe.Size = new Size(75, 23);
            Btn_PetMe.TabIndex = 2;
            Btn_PetMe.Text = "Pet Me!";
            Btn_PetMe.UseVisualStyleBackColor = true;
            // 
            // Btn_NamePet
            // 
            Btn_NamePet.Location = new Point(12, 12);
            Btn_NamePet.Name = "Btn_NamePet";
            Btn_NamePet.Size = new Size(362, 23);
            Btn_NamePet.TabIndex = 3;
            Btn_NamePet.Text = "Rename/Name Pet";
            Btn_NamePet.UseVisualStyleBackColor = true;
            Btn_NamePet.Click += Btn_NamePet_Click;
            // 
            // PetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_NamePet);
            Controls.Add(Btn_PetMe);
            Controls.Add(Btn_Feed);
            Controls.Add(PetPicture);
            Name = "PetForm";
            Text = "PetForm";
            ((System.ComponentModel.ISupportInitialize)PetPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox PetPicture;
        private Button Btn_Feed;
        private Button Btn_PetMe;
        private Button Btn_NamePet;
    }
}
