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
    public partial class Guess : Form
    {
        private readonly Random random = new();
        private int computerNumber;
        private int userNumber;
        private int counter;

        public Guess()
        {
            InitializeComponent();
            NewGame();
        }

        private void CheckWin()
        {
            if (computerNumber == userNumber)
            {
                MessageBox.Show("Вы успешно завершили игру", "Угадай число!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Угадай число!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NewGame();
                }
                else
                {
                    Close();
                }
            }
            else if (computerNumber > userNumber)
            {
                lb_Guess_Result.Text = "Ваше число меньше загаданного";
            }
            else if (computerNumber < userNumber)
            {
                lb_Guess_Result.Text = "Ваше число больше загаданного";
            }
        }

        private void NewGame()
        {
            counter = 0;
            computerNumber = random.Next(100);
        }

        private void UpdateGameState(TextBox tbx_Guess_UserAnswer)
        {
            counter++;
            if (!int.TryParse(tbx_Guess_UserAnswer.Text.ToString(), out userNumber)) MessageBox.Show("Вы ввели не число, пожалуйста введите число.");
            lb_Guess_Counter.Text = $"Вы сделали попыток: {counter}";
        }

        private void btn_Send_Answer_Click(object sender, EventArgs e)
        {
            UpdateGameState(tbx_Guess_UserAnswer);
            CheckWin();
            tbx_Guess_UserAnswer.Text = null;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbx_Guess_UserAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateGameState(tbx_Guess_UserAnswer);
                CheckWin();
                tbx_Guess_UserAnswer.Text = null;
            }
        }
    }
}
