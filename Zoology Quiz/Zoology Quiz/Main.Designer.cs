namespace Zoology_Quiz
{
    partial class Main
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
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.Button_Scoreboard = new System.Windows.Forms.Button();
            this.Button_Add_Quiz = new System.Windows.Forms.Button();
            this.Button_Play_Quiz = new System.Windows.Forms.Button();
            this.Username_Main = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Main_Quit = new System.Windows.Forms.Button();
            this.Label_Main_1 = new System.Windows.Forms.Label();
            this.Label_Main_2 = new System.Windows.Forms.Label();
            this.Label_Main_3 = new System.Windows.Forms.Label();
            this.Label_Main_4 = new System.Windows.Forms.Label();
            this.Label_Main_5 = new System.Windows.Forms.Label();
            this.Panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Main
            // 
            this.Panel_Main.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Panel_Main.Controls.Add(this.Button_Scoreboard);
            this.Panel_Main.Controls.Add(this.Button_Add_Quiz);
            this.Panel_Main.Controls.Add(this.Button_Play_Quiz);
            this.Panel_Main.Controls.Add(this.Username_Main);
            this.Panel_Main.Controls.Add(this.pictureBox1);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(200, 450);
            this.Panel_Main.TabIndex = 0;
            this.Panel_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Main_Paint);
            // 
            // Button_Scoreboard
            // 
            this.Button_Scoreboard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button_Scoreboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Scoreboard.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Scoreboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Scoreboard.Location = new System.Drawing.Point(31, 324);
            this.Button_Scoreboard.Name = "Button_Scoreboard";
            this.Button_Scoreboard.Size = new System.Drawing.Size(134, 41);
            this.Button_Scoreboard.TabIndex = 4;
            this.Button_Scoreboard.Text = "Scoreboard";
            this.Button_Scoreboard.UseVisualStyleBackColor = false;
            this.Button_Scoreboard.Click += new System.EventHandler(this.Button_Scoreboard_Click);
            // 
            // Button_Add_Quiz
            // 
            this.Button_Add_Quiz.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button_Add_Quiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Add_Quiz.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Add_Quiz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Add_Quiz.Location = new System.Drawing.Point(31, 263);
            this.Button_Add_Quiz.Name = "Button_Add_Quiz";
            this.Button_Add_Quiz.Size = new System.Drawing.Size(134, 41);
            this.Button_Add_Quiz.TabIndex = 3;
            this.Button_Add_Quiz.Text = "Add Quiz";
            this.Button_Add_Quiz.UseVisualStyleBackColor = false;
            // 
            // Button_Play_Quiz
            // 
            this.Button_Play_Quiz.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button_Play_Quiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Play_Quiz.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Play_Quiz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Play_Quiz.Location = new System.Drawing.Point(31, 204);
            this.Button_Play_Quiz.Name = "Button_Play_Quiz";
            this.Button_Play_Quiz.Size = new System.Drawing.Size(134, 41);
            this.Button_Play_Quiz.TabIndex = 2;
            this.Button_Play_Quiz.Text = "Play Quiz";
            this.Button_Play_Quiz.UseVisualStyleBackColor = false;
            this.Button_Play_Quiz.Click += new System.EventHandler(this.Button_Play_Quiz_Click);
            // 
            // Username_Main
            // 
            this.Username_Main.AutoSize = true;
            this.Username_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username_Main.Location = new System.Drawing.Point(57, 144);
            this.Username_Main.Name = "Username_Main";
            this.Username_Main.Size = new System.Drawing.Size(2, 19);
            this.Username_Main.TabIndex = 1;
            this.Username_Main.Click += new System.EventHandler(this.Username_Main_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zoology_Quiz.Properties.Resources.User_2;
            this.pictureBox1.Location = new System.Drawing.Point(40, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Button_Main_Quit
            // 
            this.Button_Main_Quit.FlatAppearance.BorderSize = 0;
            this.Button_Main_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Main_Quit.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Main_Quit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button_Main_Quit.Location = new System.Drawing.Point(765, 0);
            this.Button_Main_Quit.Name = "Button_Main_Quit";
            this.Button_Main_Quit.Size = new System.Drawing.Size(36, 29);
            this.Button_Main_Quit.TabIndex = 1;
            this.Button_Main_Quit.Text = "X";
            this.Button_Main_Quit.UseVisualStyleBackColor = true;
            this.Button_Main_Quit.Click += new System.EventHandler(this.Button_Main_Quit_Click);
            // 
            // Label_Main_1
            // 
            this.Label_Main_1.AutoSize = true;
            this.Label_Main_1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Main_1.Location = new System.Drawing.Point(257, 213);
            this.Label_Main_1.Name = "Label_Main_1";
            this.Label_Main_1.Size = new System.Drawing.Size(292, 22);
            this.Label_Main_1.TabIndex = 2;
            this.Label_Main_1.Text = "Play Quiz : Start the quiz session";
            // 
            // Label_Main_2
            // 
            this.Label_Main_2.AutoSize = true;
            this.Label_Main_2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Main_2.Location = new System.Drawing.Point(257, 272);
            this.Label_Main_2.Name = "Label_Main_2";
            this.Label_Main_2.Size = new System.Drawing.Size(480, 22);
            this.Label_Main_2.TabIndex = 3;
            this.Label_Main_2.Text = "Add Quiz : Add your own quiz to the question bank";
            // 
            // Label_Main_3
            // 
            this.Label_Main_3.AutoSize = true;
            this.Label_Main_3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Main_3.Location = new System.Drawing.Point(239, 324);
            this.Label_Main_3.Name = "Label_Main_3";
            this.Label_Main_3.Size = new System.Drawing.Size(535, 22);
            this.Label_Main_3.TabIndex = 4;
            this.Label_Main_3.Text = "Scoreboard : View the scoreboard of the quiz application";
            // 
            // Label_Main_4
            // 
            this.Label_Main_4.AutoSize = true;
            this.Label_Main_4.Font = new System.Drawing.Font("Century Gothic", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.Label_Main_4.Location = new System.Drawing.Point(446, 19);
            this.Label_Main_4.Name = "Label_Main_4";
            this.Label_Main_4.Size = new System.Drawing.Size(103, 23);
            this.Label_Main_4.TabIndex = 5;
            this.Label_Main_4.Text = "Instruction";
            // 
            // Label_Main_5
            // 
            this.Label_Main_5.AutoSize = true;
            this.Label_Main_5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Main_5.Location = new System.Drawing.Point(290, 53);
            this.Label_Main_5.Name = "Label_Main_5";
            this.Label_Main_5.Size = new System.Drawing.Size(420, 110);
            this.Label_Main_5.TabIndex = 6;
            this.Label_Main_5.Text = "This quiz session contain a total of 15 question\r\nregarding animal. A scoreboard " +
    "will be \r\ndisplayed after the quiz session and the\r\nresult will be save in the d" +
    "atabase.\r\n\r\n";
            this.Label_Main_5.Click += new System.EventHandler(this.Label_Main_5_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Label_Main_5);
            this.Controls.Add(this.Label_Main_4);
            this.Controls.Add(this.Label_Main_3);
            this.Controls.Add(this.Label_Main_2);
            this.Controls.Add(this.Label_Main_1);
            this.Controls.Add(this.Button_Main_Quit);
            this.Controls.Add(this.Panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Zoology Quiz - Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Panel_Main;
        private Button Button_Scoreboard;
        private Button Button_Add_Quiz;
        private Button Button_Play_Quiz;
        private Label Username_Main;
        private PictureBox pictureBox1;
        private Button Button_Main_Quit;
        private Label Label_Main_1;
        private Label Label_Main_2;
        private Label Label_Main_3;
        private Label Label_Main_4;
        private Label Label_Main_5;
    }
}