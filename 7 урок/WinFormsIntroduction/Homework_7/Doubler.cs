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
    public partial class Doubler : Form
    {
        private readonly Random random = new();
        private int computerNumber;
        private int userNumber;
        private int counter;

        public Doubler()
        {
            InitializeComponent();
            userNumber = 0;
            counter = 0;
            UpdateGameState(userNumber, random.Next(100));
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
                    counter = 0;
                    UpdateGameState(userNumber, random.Next(100));
                }
                else
                {
                    Close();
                }
            }
        }

        private void UpdateGameState(int userNumber)
        {
            lb_Doubler_Current.Text = $"Текущее число: {userNumber}";
            lb_Doubler_Counter.Text = $"Вы выполнили операций: {counter}";
        }

        private void UpdateGameState(int userNumber, int computerNumber)
        {
            UpdateGameState(userNumber);
            this.computerNumber = computerNumber;
            lb_Doubler_Target.Text = $"Получите число: {computerNumber}";
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            userNumber = 0;
            UpdateGameState(userNumber, random.Next(100));
        }

        private void btn_Increment_Click(object sender, EventArgs e)
        {
            counter++;
            UpdateGameState(++userNumber);
            CheckWin();
        }

        private void btn_Doubler_Click(object sender, EventArgs e)
        {
            counter++;
            UpdateGameState(userNumber *= 2);
            CheckWin();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
