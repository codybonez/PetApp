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
            txt_code = new TextBox();
            lbl_petName = new Label();
            label1 = new Label();
            label2 = new Label();
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
            Btn_JoinRoom.Click += Btn_JoinRoom_Click;
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
            // txt_code
            // 
            txt_code.Location = new Point(367, 86);
            txt_code.Name = "txt_code";
            txt_code.Size = new Size(100, 23);
            txt_code.TabIndex = 7;
            // 
            // lbl_petName
            // 
            lbl_petName.AutoSize = true;
            lbl_petName.Location = new Point(149, 134);
            lbl_petName.Name = "lbl_petName";
            lbl_petName.Size = new Size(38, 15);
            lbl_petName.TabIndex = 8;
            lbl_petName.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(291, 89);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 9;
            label1.Text = "Room Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 134);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // MeetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbl_petName);
            Controls.Add(txt_code);
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
            PerformLayout();
        }

        #endregion

        public Button Btn_CreateRoom;
        public Button Btn_JoinRoom;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txt_code;
        private Label lbl_petName;
        private Label label1;
        private Label label2;
    }
}