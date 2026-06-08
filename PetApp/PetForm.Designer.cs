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
            lbl_status = new Label();
            lbl_petname = new Label();
            lbl_PetAge = new Label();
            lblShowTime = new Label();
            btn_FeedingTimes = new Button();
            btn_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)PetPicture).BeginInit();
            SuspendLayout();
            // 
            // PetPicture
            // 
            PetPicture.Image = Properties.Resources.HappyDog;
            PetPicture.Location = new Point(12, 41);
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
            Btn_PetMe.Click += Btn_PetMe_Click;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(3, 384);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(85, 15);
            lbl_status.TabIndex = 4;
            lbl_status.Text = "Current Status:";
            // 
            // lbl_petname
            // 
            lbl_petname.AutoSize = true;
            lbl_petname.Location = new Point(3, 426);
            lbl_petname.Name = "lbl_petname";
            lbl_petname.Size = new Size(62, 15);
            lbl_petname.TabIndex = 5;
            lbl_petname.Text = "Pet Name:";
            // 
            // lbl_PetAge
            // 
            lbl_PetAge.AutoSize = true;
            lbl_PetAge.Location = new Point(3, 400);
            lbl_PetAge.Name = "lbl_PetAge";
            lbl_PetAge.Size = new Size(51, 15);
            lbl_PetAge.TabIndex = 6;
            lbl_PetAge.Text = "Pet Age:";
            lbl_PetAge.Click += lbl_PetAge_Click;
            // 
            // lblShowTime
            // 
            lblShowTime.AutoSize = true;
            lblShowTime.Location = new Point(469, 20);
            lblShowTime.Name = "lblShowTime";
            lblShowTime.Size = new Size(40, 15);
            lblShowTime.TabIndex = 7;
            lblShowTime.Text = "Time: ";
            // 
            // btn_FeedingTimes
            // 
            btn_FeedingTimes.AutoSize = true;
            btn_FeedingTimes.Location = new Point(497, 86);
            btn_FeedingTimes.Name = "btn_FeedingTimes";
            btn_FeedingTimes.Size = new Size(160, 28);
            btn_FeedingTimes.TabIndex = 10;
            btn_FeedingTimes.Text = "Click To See Feeding Times";
            btn_FeedingTimes.UseVisualStyleBackColor = true;
            btn_FeedingTimes.Click += btn_FeedingTimes_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(469, 358);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 11;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // PetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Save);
            Controls.Add(btn_FeedingTimes);
            Controls.Add(lblShowTime);
            Controls.Add(lbl_PetAge);
            Controls.Add(lbl_petname);
            Controls.Add(lbl_status);
            Controls.Add(Btn_PetMe);
            Controls.Add(Btn_Feed);
            Controls.Add(PetPicture);
            Name = "PetForm";
            Text = "PetForm";
            Load += PetForm_Load;
            ((System.ComponentModel.ISupportInitialize)PetPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox PetPicture;
        private Button Btn_Feed;
        private Button Btn_PetMe;
        public Label lbl_status;
        public Label lbl_petname;
        public Label lbl_PetAge;
        private Label lblShowTime;
        private Button btn_FeedingTimes;
        private Button btn_Save;
    }
}
