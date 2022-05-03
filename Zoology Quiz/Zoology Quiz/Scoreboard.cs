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
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void Button_Scoreboard_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Scoreboard_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f2 = new Main();
            f2.ShowDialog();
            this.Close();
        }
    }
}
