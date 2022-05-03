using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoology_Quiz
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Label_Main_5_Click(object sender, EventArgs e)
        {

        }

        private void Button_Main_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Username_Main_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
          
        }

        private void Button_Play_Quiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayQuiz f2 = new PlayQuiz();
            f2.ShowDialog();
            this.Close();
        }

        private void Button_Scoreboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scoreboard f3 = new Scoreboard();
            f3.ShowDialog();
            this.Close();
        }
    }
}
