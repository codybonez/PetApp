namespace PetApp
{
    partial class MeetupForm
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
            Btn_CreateRoom = new Button();
            PetPicture = new PictureBox();
            pictureBox1 = new PictureBox();
            Btn_JoinRoom = new Button();
            ((System.ComponentModel.ISupportInitialize)PetPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Btn_CreateRoom
            // 
            Btn_CreateRoom.Location = new Point(367, 85);
            Btn_CreateRoom.Name = "Btn_CreateRoom";
            Btn_CreateRoom.Size = new Size(75, 23);
            Btn_CreateRoom.TabIndex = 0;
            Btn_CreateRoom.Text = "Create Room";
            Btn_CreateRoom.UseVisualStyleBackColor = true;
            // 
            // PetPicture
            // 
            PetPicture.Location = new Point(9, 98);
            PetPicture.Name = "PetPicture";
            PetPicture.Size = new Size(352, 340);
            PetPicture.TabIndex = 1;
            PetPicture.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(448, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 340);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Btn_JoinRoom
            // 
            Btn_JoinRoom.Location = new Point(367, 160);
            Btn_JoinRoom.Name = "Btn_JoinRoom";
            Btn_JoinRoom.Size = new Size(75, 23);
            Btn_JoinRoom.TabIndex = 3;
            Btn_JoinRoom.Text = "Join Room";
            Btn_JoinRoom.UseVisualStyleBackColor = true;
            // 
            // MeetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_JoinRoom);
            Controls.Add(pictureBox1);
            Controls.Add(PetPicture);
            Controls.Add(Btn_CreateRoom);
            Name = "MeetupForm";
            Text = "MeetupForm";
            Load += MeetupForm_Load;
            ((System.ComponentModel.ISupportInitialize)PetPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Button Btn_CreateRoom;
        public PictureBox PetPicture;
        public PictureBox pictureBox1;
        public Button Btn_JoinRoom;
    }
}