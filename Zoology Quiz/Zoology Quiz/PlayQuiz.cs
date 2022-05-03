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
    public partial class PlayQuiz : Form
    {
        public PlayQuiz()
        {
            InitializeComponent();
        }

        private void Button_PlayQuiz_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
