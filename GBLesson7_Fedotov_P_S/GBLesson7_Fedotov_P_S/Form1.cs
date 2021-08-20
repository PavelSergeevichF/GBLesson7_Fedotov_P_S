using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GBLesson7_Fedotov_P_S
{
    public partial class Form1 : Form
    {
        GuessNumberSystem guessNumberSystem = new GuessNumberSystem();
        public Form1()
        {
            InitializeComponent();
        }


        private void Send_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                (
                guessNumberSystem.GetNumUser(textBox1.Text)
                );
            
        }
    }
}
