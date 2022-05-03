namespace Zoology_Quiz
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Left_Panel = new System.Windows.Forms.Panel();
            this.Label_2 = new System.Windows.Forms.Label();
            this.Label_4 = new System.Windows.Forms.Label();
            this.PictureBox_Login = new System.Windows.Forms.PictureBox();
            this.Picture_Login = new System.Windows.Forms.PictureBox();
            this.Label_3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Login_Quit = new System.Windows.Forms.Button();
            this.Textbox_Username = new System.Windows.Forms.TextBox();
            this.Left_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Left_Panel.Controls.Add(this.Label_2);
            this.Left_Panel.Controls.Add(this.Label_4);
            this.Left_Panel.Controls.Add(this.PictureBox_Login);
            resources.ApplyResources(this.Left_Panel, "Left_Panel");
            this.Left_Panel.Name = "Left_Panel";
            // 
            // Label_2
            // 
            resources.ApplyResources(this.Label_2, "Label_2");
            this.Label_2.Name = "Label_2";
            // 
            // Label_4
            // 
            resources.ApplyResources(this.Label_4, "Label_4");
            this.Label_4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_4.Name = "Label_4";
            // 
            // PictureBox_Login
            // 
            this.PictureBox_Login.Image = global::Zoology_Quiz.Properties.Resources.Zoo;
            resources.ApplyResources(this.PictureBox_Login, "PictureBox_Login");
            this.PictureBox_Login.Name = "PictureBox_Login";
            this.PictureBox_Login.TabStop = false;
            // 
            // Picture_Login
            // 
            this.Picture_Login.Image = global::Zoology_Quiz.Properties.Resources.Login_user;
            resources.ApplyResources(this.Picture_Login, "Picture_Login");
            this.Picture_Login.Name = "Picture_Login";
            this.Picture_Login.TabStop = false;
            // 
            // Label_3
            // 
            resources.ApplyResources(this.Label_3, "Label_3");
            this.Label_3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_3.Name = "Label_3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.Button_Start, "Button_Start");
            this.Button_Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Button_Login_Quit
            // 
            this.Button_Login_Quit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Button_Login_Quit, "Button_Login_Quit");
            this.Button_Login_Quit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Button_Login_Quit.Name = "Button_Login_Quit";
            this.Button_Login_Quit.UseVisualStyleBackColor = true;
            this.Button_Login_Quit.Click += new System.EventHandler(this.Button_Login_Quit_Click);
            // 
            // Textbox_Username
            // 
            resources.ApplyResources(this.Textbox_Username, "Textbox_Username");
            this.Textbox_Username.Name = "Textbox_Username";
            this.Textbox_Username.TextChanged += new System.EventHandler(this.Textbox_Username_TextChanged);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Textbox_Username);
            this.Controls.Add(this.Button_Login_Quit);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_3);
            this.Controls.Add(this.Picture_Login);
            this.Controls.Add(this.Left_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Left_Panel.ResumeLayout(false);
            this.Left_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel Left_Panel;
        private Label Label_4;
        private PictureBox PictureBox_Login;
        private Label Label_2;
        private PictureBox Picture_Login;
        private Label Label_3;
        private Label label1;
        private Button Button_Start;
        private Button Button_Login_Quit;
        private TextBox Textbox_Username;
    }
}