using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public static Random rnd = new Random();
        static string[] readQuestions4Class = File.ReadAllLines("questions.txt");
        static string[] readAnswer4Class = File.ReadAllLines("answers.txt");
        static string[] readQuestions5Class = File.ReadAllLines("questions5.txt");
        static string[] readAnswer5Class = File.ReadAllLines("answers5.txt");
        int number4Class = Convert.ToInt32(rnd.Next(0, readAnswer4Class.Length));
        int number5Class = Convert.ToInt32(rnd.Next(0, readAnswer5Class.Length));
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.BackColor = Color.Transparent;
            if (FormInfo.questionClass)
            {
                question.Text = "Для выращивания рассады школьники приготовили 250 граммов семян капусты, а семян помидоров - в 2 раза меньше, чем семян капусты. Семена разложили в пакетики, по 25 граммов в каждый. Сколько понадобилось пакетиков для семян?";
                number4Class++;
            }
            else
            {
                question.Text = readQuestions5Class[number5Class];
                number5Class++;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormInfo.questionClass)
            {
                if (answer.Text == readAnswer4Class[number4Class - 1])
                {
                    MessageBox.Show("Вы ввели правильный ответ. Вы получаете 20 баллов.");
                    FormInfo.userPoints += 20;
                }
                else
                {
                    FormInfo.userPoints -= 10;
                    MessageBox.Show($"Вы ввели неправильный ответ. Правильный ответ - {readAnswer4Class[number4Class - 1]}. Вы теряете 10 баллов.");
                }
            }
            else
            {
                if (answer.Text == readAnswer5Class[number5Class - 1])
                {

                    MessageBox.Show("Вы ввели правильный ответ. Вы получаете 40 баллов.");
                    FormInfo.userPoints += 40;
                }
                else
                {
                    FormInfo.userPoints -= 20;
                    MessageBox.Show($"Вы ввели неправильный ответ. Правильный ответ - {readAnswer5Class[number5Class - 1]}. Вы теряете 20 баллов.");
                }
            }
            this.Owner.Focus();
            this.Hide();
        }
    }
}
