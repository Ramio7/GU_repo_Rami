using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Main : Form
    {

        private Random random = new Random();
        private int computerNumber;
        private int userNumber;

        public Main()
        {
            
            InitializeComponent();

            userNumber = 0;
            UpdateGameState(userNumber, random.Next(50));

        }

        private void UpdateGameState(int userNumber)
        {
            lbUserNumber.Text = $"Текущее число: {userNumber}";
        }

        private void UpdateGameState(int userNumber, int computerNumber)
        {
            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            lbComputerNumber.Text = $"Получите число: {computerNumber}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            UpdateGameState(userNumber, random.Next(50));
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //userNumber = userNumber + 1;
            UpdateGameState(++userNumber);
            CheckWin();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
           // userNumber = userNumber * 2;
            UpdateGameState(userNumber *= 2);
            CheckWin();
        }

        private void CheckWin()
        {
            if (computerNumber == userNumber)
            {
                MessageBox.Show("Вы успешно завершили игру", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userNumber = 0;
                    UpdateGameState(userNumber, random.Next(50));
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
