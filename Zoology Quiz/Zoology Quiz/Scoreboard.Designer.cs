namespace Zoology_Quiz
{
    partial class Scoreboard
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
            this.Panel_Scoreboard = new System.Windows.Forms.Panel();
            this.Button_PlayQuiz_Quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Show_Scoreboard = new System.Windows.Forms.Label();
            this.Button_Scoreboard_Back = new System.Windows.Forms.Button();
            this.Button_Scoreboard_Quit = new System.Windows.Forms.Button();
            this.Panel_Scoreboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Scoreboard
            // 
            this.Panel_Scoreboard.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel_Scoreboard.Controls.Add(this.Button_PlayQuiz_Quit);
            this.Panel_Scoreboard.Controls.Add(this.label1);
            this.Panel_Scoreboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Scoreboard.Location = new System.Drawing.Point(0, 0);
            this.Panel_Scoreboard.Name = "Panel_Scoreboard";
            this.Panel_Scoreboard.Size = new System.Drawing.Size(468, 46);
            this.Panel_Scoreboard.TabIndex = 0;
            // 
            // Button_PlayQuiz_Quit
            // 
            this.Button_PlayQuiz_Quit.FlatAppearance.BorderSize = 0;
            this.Button_PlayQuiz_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_PlayQuiz_Quit.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_PlayQuiz_Quit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Button_PlayQuiz_Quit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button_PlayQuiz_Quit.Location = new System.Drawing.Point(432, 0);
            this.Button_PlayQuiz_Quit.Name = "Button_PlayQuiz_Quit";
            this.Button_PlayQuiz_Quit.Size = new System.Drawing.Size(36, 29);
            this.Button_PlayQuiz_Quit.TabIndex = 9;
            this.Button_PlayQuiz_Quit.Text = "X";
            this.Button_PlayQuiz_Quit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ScoreBoard";
            // 
            // Label_Show_Scoreboard
            // 
            this.Label_Show_Scoreboard.Location = new System.Drawing.Point(32, 87);
            this.Label_Show_Scoreboard.Name = "Label_Show_Scoreboard";
            this.Label_Show_Scoreboard.Size = new System.Drawing.Size(404, 216);
            this.Label_Show_Scoreboard.TabIndex = 1;
            this.Label_Show_Scoreboard.Text = "label2";
            // 
            // Button_Scoreboard_Back
            // 
            this.Button_Scoreboard_Back.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button_Scoreboard_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Scoreboard_Back.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Scoreboard_Back.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Scoreboard_Back.Location = new System.Drawing.Point(56, 334);
            this.Button_Scoreboard_Back.Name = "Button_Scoreboard_Back";
            this.Button_Scoreboard_Back.Size = new System.Drawing.Size(134, 41);
            this.Button_Scoreboard_Back.TabIndex = 3;
            this.Button_Scoreboard_Back.Text = "Main Menu";
            this.Button_Scoreboard_Back.UseVisualStyleBackColor = false;
            this.Button_Scoreboard_Back.Click += new System.EventHandler(this.Button_Scoreboard_Back_Click);
            // 
            // Button_Scoreboard_Quit
            // 
            this.Button_Scoreboard_Quit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button_Scoreboard_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Scoreboard_Quit.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Scoreboard_Quit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Scoreboard_Quit.Location = new System.Drawing.Point(266, 334);
            this.Button_Scoreboard_Quit.Name = "Button_Scoreboard_Quit";
            this.Button_Scoreboard_Quit.Size = new System.Drawing.Size(134, 41);
            this.Button_Scoreboard_Quit.TabIndex = 4;
            this.Button_Scoreboard_Quit.Text = "Quit";
            this.Button_Scoreboard_Quit.UseVisualStyleBackColor = false;
            this.Button_Scoreboard_Quit.Click += new System.EventHandler(this.Button_Scoreboard_Quit_Click);
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 403);
            this.ControlBox = false;
            this.Controls.Add(this.Button_Scoreboard_Quit);
            this.Controls.Add(this.Button_Scoreboard_Back);
            this.Controls.Add(this.Label_Show_Scoreboard);
            this.Controls.Add(this.Panel_Scoreboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scoreboard";
            this.Text = "Scoreboard";
            this.Panel_Scoreboard.ResumeLayout(false);
            this.Panel_Scoreboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Panel_Scoreboard;
        private Label label1;
        private Label Label_Show_Scoreboard;
        private Button Button_Scoreboard_Back;
        private Button Button_Scoreboard_Quit;
        private Button Button_PlayQuiz_Quit;
    }
}