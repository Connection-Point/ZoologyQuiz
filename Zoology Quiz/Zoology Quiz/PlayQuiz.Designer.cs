namespace Zoology_Quiz
{
    partial class PlayQuiz
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
            this.Panel_PlayQuiz = new System.Windows.Forms.Panel();
            this.Button_PlayQuiz_Quit = new System.Windows.Forms.Button();
            this.Label_PlayQuiz_Top = new System.Windows.Forms.Label();
            this.Picturebox_PlayQuiz = new System.Windows.Forms.PictureBox();
            this.Button_Answer_A = new System.Windows.Forms.Button();
            this.Button_Answer_C = new System.Windows.Forms.Button();
            this.Button_Answer_B = new System.Windows.Forms.Button();
            this.Button_Answer_D = new System.Windows.Forms.Button();
            this.Panel_PlayQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_PlayQuiz)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_PlayQuiz
            // 
            this.Panel_PlayQuiz.BackColor = System.Drawing.SystemColors.Highlight;
            this.Panel_PlayQuiz.Controls.Add(this.Button_PlayQuiz_Quit);
            this.Panel_PlayQuiz.Controls.Add(this.Label_PlayQuiz_Top);
            this.Panel_PlayQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_PlayQuiz.Location = new System.Drawing.Point(0, 0);
            this.Panel_PlayQuiz.Name = "Panel_PlayQuiz";
            this.Panel_PlayQuiz.Size = new System.Drawing.Size(800, 46);
            this.Panel_PlayQuiz.TabIndex = 0;
            // 
            // Button_PlayQuiz_Quit
            // 
            this.Button_PlayQuiz_Quit.FlatAppearance.BorderSize = 0;
            this.Button_PlayQuiz_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_PlayQuiz_Quit.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_PlayQuiz_Quit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Button_PlayQuiz_Quit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Button_PlayQuiz_Quit.Location = new System.Drawing.Point(764, 0);
            this.Button_PlayQuiz_Quit.Name = "Button_PlayQuiz_Quit";
            this.Button_PlayQuiz_Quit.Size = new System.Drawing.Size(36, 29);
            this.Button_PlayQuiz_Quit.TabIndex = 8;
            this.Button_PlayQuiz_Quit.Text = "X";
            this.Button_PlayQuiz_Quit.UseVisualStyleBackColor = true;
            this.Button_PlayQuiz_Quit.Click += new System.EventHandler(this.Button_PlayQuiz_Quit_Click);
            // 
            // Label_PlayQuiz_Top
            // 
            this.Label_PlayQuiz_Top.AutoSize = true;
            this.Label_PlayQuiz_Top.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_PlayQuiz_Top.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_PlayQuiz_Top.Location = new System.Drawing.Point(7, 11);
            this.Label_PlayQuiz_Top.Name = "Label_PlayQuiz_Top";
            this.Label_PlayQuiz_Top.Size = new System.Drawing.Size(143, 23);
            this.Label_PlayQuiz_Top.TabIndex = 0;
            this.Label_PlayQuiz_Top.Text = "Question 1/20";
            // 
            // Picturebox_PlayQuiz
            // 
            this.Picturebox_PlayQuiz.Location = new System.Drawing.Point(198, 97);
            this.Picturebox_PlayQuiz.Name = "Picturebox_PlayQuiz";
            this.Picturebox_PlayQuiz.Size = new System.Drawing.Size(408, 188);
            this.Picturebox_PlayQuiz.TabIndex = 1;
            this.Picturebox_PlayQuiz.TabStop = false;
            // 
            // Button_Answer_A
            // 
            this.Button_Answer_A.Location = new System.Drawing.Point(248, 312);
            this.Button_Answer_A.Name = "Button_Answer_A";
            this.Button_Answer_A.Size = new System.Drawing.Size(105, 38);
            this.Button_Answer_A.TabIndex = 2;
            this.Button_Answer_A.UseVisualStyleBackColor = true;
            // 
            // Button_Answer_C
            // 
            this.Button_Answer_C.Location = new System.Drawing.Point(248, 379);
            this.Button_Answer_C.Name = "Button_Answer_C";
            this.Button_Answer_C.Size = new System.Drawing.Size(105, 38);
            this.Button_Answer_C.TabIndex = 3;
            this.Button_Answer_C.UseVisualStyleBackColor = true;
            // 
            // Button_Answer_B
            // 
            this.Button_Answer_B.Location = new System.Drawing.Point(470, 312);
            this.Button_Answer_B.Name = "Button_Answer_B";
            this.Button_Answer_B.Size = new System.Drawing.Size(105, 38);
            this.Button_Answer_B.TabIndex = 4;
            this.Button_Answer_B.UseVisualStyleBackColor = true;
            // 
            // Button_Answer_D
            // 
            this.Button_Answer_D.Location = new System.Drawing.Point(470, 379);
            this.Button_Answer_D.Name = "Button_Answer_D";
            this.Button_Answer_D.Size = new System.Drawing.Size(105, 38);
            this.Button_Answer_D.TabIndex = 5;
            this.Button_Answer_D.UseVisualStyleBackColor = true;
            // 
            // PlayQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Button_Answer_D);
            this.Controls.Add(this.Button_Answer_B);
            this.Controls.Add(this.Button_Answer_C);
            this.Controls.Add(this.Button_Answer_A);
            this.Controls.Add(this.Picturebox_PlayQuiz);
            this.Controls.Add(this.Panel_PlayQuiz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayQuiz";
            this.Text = "Zoology Quiz - Session";
            this.Panel_PlayQuiz.ResumeLayout(false);
            this.Panel_PlayQuiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picturebox_PlayQuiz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Panel_PlayQuiz;
        private Label Label_PlayQuiz_Top;
        private PictureBox Picturebox_PlayQuiz;
        private Button Button_Answer_A;
        private Button Button_Answer_C;
        private Button Button_Answer_B;
        private Button Button_Answer_D;
        private Button Button_PlayQuiz_Quit;
    }
}