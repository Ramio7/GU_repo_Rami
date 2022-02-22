using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_7
{
    public partial class HW_7_MainMenu : Form
    {
        public HW_7_MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Doubler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Game1 = new Doubler();
            Game1.ShowDialog();
            this.Show();
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Game2 = new Guess();
            Game2.ShowDialog();
            this.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
