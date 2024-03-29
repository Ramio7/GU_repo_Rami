﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseEditor
{
    public partial class Main : Form
    {
        private TrueFalse database;

        public Main()
        {
            InitializeComponent();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog(); 
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(dlg.FileName);
                database.Add("Замля круглая?", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(dlg.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            database.Save();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            if (database == null)
            {
                tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
            else
            {
                Console.WriteLine("Сначала создайте новый файл с помощью меню file/New");
                Application.Restart();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                database.Add($"#{database.Count + 1}", true);
                nudNumber.Maximum = database.Count;
                nudNumber.Value = database.Count;
            }
            else
            {
                Console.WriteLine("Сначала создайте новый файл с помощью меню file/New");
                Application.Restart();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                database.Remove((int)nudNumber.Value - 1);
                nudNumber.Maximum--;
                nudNumber.Value--;
            }
            else
            {
                Console.WriteLine("Сначала создайте новый файл с помощью меню file/New");
                Application.Restart();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
            }
            else
            {
                Console.WriteLine("Сначала создайте новый файл с помощью меню file/New");
                Application.Restart();
            }
        }

        private void aboutThaAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Application.ProductName}, {Application.ProductVersion}\n" +
                $"Создатель: GeekBrains\n" +
                $"Доработал: Рахимкулов Рамиль\n" +
                $"© GeekBrains, 2022","О приложении");
        }
    }
}
