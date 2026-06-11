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
            Btn_JoinRoom = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Btn_CreateRoom
            // 
            Btn_CreateRoom.Location = new Point(274, 57);
            Btn_CreateRoom.Name = "Btn_CreateRoom";
            Btn_CreateRoom.Size = new Size(283, 23);
            Btn_CreateRoom.TabIndex = 0;
            Btn_CreateRoom.Text = "Create Room";
            Btn_CreateRoom.UseVisualStyleBackColor = true;
            Btn_CreateRoom.Click += Btn_CreateRoom_Click;
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
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 160);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 278);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(448, 160);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(340, 278);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // MeetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Btn_JoinRoom);
            Controls.Add(Btn_CreateRoom);
            Name = "MeetupForm";
            Text = "MeetupForm";
            Load += MeetupForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Button Btn_CreateRoom;
        public Button Btn_JoinRoom;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}