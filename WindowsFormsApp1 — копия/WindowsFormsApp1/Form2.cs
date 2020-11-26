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
            FormInfo.cubik = false;
            flowLayoutPanel1.BackColor = Color.Transparent;
            if (FormInfo.startOfGame)
            {
                question.Text = "Введите количество игроков от 2 до 4";
            }
            else if (FormInfo.questionClass)
            {
                question.Text = readQuestions4Class[number4Class];
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
            if (FormInfo.startOfGame)
            {
                if (answer.Text == "2" || answer.Text == "4" || answer.Text == "3")
                {
                    FormInfo.numberOfPlayers = Convert.ToInt32(answer.Text);
                    FormInfo.userPoints = new int[FormInfo.numberOfPlayers];
                    for (int i = 0; i < FormInfo.numberOfPlayers; i++)
                    {
                        FormInfo.userPoints[i] = 200;

                    }
                    FormInfo.fieldCell = new int[FormInfo.numberOfPlayers];
                    for (int i = 0; i < FormInfo.numberOfPlayers; i++)
                    {
                        FormInfo.fieldCell[i] = 0;
                    }
                    FormInfo.startOfGame = false;
                }
                else
                {
                    MessageBox.Show("Вы ввели неправильное число. Начните игру заново.");
                    Environment.Exit(0);
                }
            }
            else if (FormInfo.questionClass)
            {
                if (answer.Text == readAnswer4Class[number4Class - 1])
                {
                    MessageBox.Show("Вы ввели правильный ответ. Вы получаете 20 баллов.");
                    FormInfo.userPoints[FormInfo.number] += 20;
                }
                else
                {
                    FormInfo.userPoints[FormInfo.number] -= 20;
                    MessageBox.Show($"Вы ввели неправильный ответ. Правильный ответ - {readAnswer4Class[number4Class - 1]}. Вы теряете 20 баллов.");
                }
                FormInfo.number++;
                if (FormInfo.number >= FormInfo.numberOfPlayers)
                {
                    FormInfo.number %= FormInfo.numberOfPlayers;
                }
            }
            else
            {
                if (answer.Text == readAnswer5Class[number5Class - 1])
                {

                    MessageBox.Show("Вы ввели правильный ответ. Вы получаете 40 баллов.");
                    FormInfo.userPoints[FormInfo.number] += 40;
                }
                else
                {
                    FormInfo.userPoints[FormInfo.number] -= 40;
                    MessageBox.Show($"Вы ввели неправильный ответ. Правильный ответ - {readAnswer5Class[number5Class - 1]}. Вы теряете 40 баллов.");
                }
                FormInfo.number++;
                if (FormInfo.number >= FormInfo.numberOfPlayers)
                {
                    FormInfo.number %= FormInfo.numberOfPlayers;
                }
            }
            FormInfo.cubik = true;
            this.Owner.Show();
            this.Owner.Focus();
            this.Hide();
        }
    }
}
