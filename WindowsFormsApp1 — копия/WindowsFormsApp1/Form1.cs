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
    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        public static string rules = File.ReadAllText("rules.txt");
        public static Color[] colors = { Color.Green, Color.Red, Color.Blue, Color.Purple};
        Bitmap bitmap;
        Graphics graph;
        int[] xPositions = {750, 667, 601, 535, 469, 403, 337, 271, 205, 139, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 139, 205, 271, 337, 403, 469, 535, 601, 667, 750, 750, 750, 750, 750, 750, 750, 750, 750, 750 };
        int[] yPositions = {750, 750, 750, 750, 750, 750, 750, 750, 750, 750, 750, 667, 601, 535, 469, 403, 337, 271, 205, 139, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 139, 205, 271, 337, 403, 469, 535, 601, 667 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sssstart.Image = WindowsFormsApp1.Properties.Resources.monopolyField;
            currentPlayer.Image = WindowsFormsApp1.Properties.Resources.monopolyField;
            dices.Image = WindowsFormsApp1.Properties.Resources.monopolyField;
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            for (int i = 0; i < FormInfo.numberOfPlayers; i++)
            {
                FormInfo.userPoints[i] = 200;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormInfo.cubik)
            {
                graph.Clear(Color.Transparent);
                pictureBox1.BackgroundImage = Image.FromFile("monopolyField.jpg");
                int dice1 = Convert.ToInt32(rnd.Next(1, 7)), dice2 = Convert.ToInt32(rnd.Next(1, 7));
                FormInfo.fieldCell[FormInfo.number] += dice1 + dice2;
                dices.Text = $"Значения на костях: {dice1}, {dice2}.";
                for (int i = 0; i < FormInfo.numberOfPlayers; i++)
                {
                    graph.FillEllipse(new SolidBrush(colors[i]), xPositions[FormInfo.fieldCell[i] % 40], yPositions[FormInfo.fieldCell[i] % 40], 30, 30);
                }
                pictureBox1.Invalidate();
                if (FormInfo.fieldCell[FormInfo.number] > 40)
                {
                    FormInfo.fieldCell[FormInfo.number] -= 40;
                    FormInfo.userPoints[FormInfo.number] += 100;
                    MessageBox.Show("Вы прошли поле 'Старт' и получаете 100 очков.");
                }
                if (FormInfo.fieldCell[FormInfo.number] == 2 || FormInfo.fieldCell[FormInfo.number] == 4 || FormInfo.fieldCell[FormInfo.number] == 7 || FormInfo.fieldCell[FormInfo.number] == 12 || FormInfo.fieldCell[FormInfo.number] == 17 || FormInfo.fieldCell[FormInfo.number] == 22 || FormInfo.fieldCell[FormInfo.number] == 28 || FormInfo.fieldCell[FormInfo.number] == 33 || FormInfo.fieldCell[FormInfo.number] == 36 || FormInfo.fieldCell[FormInfo.number] == 38)
                {
                    int a = Convert.ToInt32(rnd.Next(-50, 51));
                    if (a >= 0)
                    {
                        MessageBox.Show($"Вы получаете {a} очков.");
                    }
                    else
                    {
                        MessageBox.Show($"Вы теряете {-a} очков.");
                    }
                    FormInfo.userPoints[FormInfo.number] += a;
                    FormInfo.number++;
                    if (FormInfo.number >= FormInfo.numberOfPlayers)
                    {
                        FormInfo.number %= FormInfo.numberOfPlayers;
                    }
                }
                else if (FormInfo.fieldCell[FormInfo.number] == 40)
                {
                    FormInfo.fieldCell[FormInfo.number] -= 40;
                    MessageBox.Show("Вы попали на поле 'Старт' и получаете 100 очков.");
                    FormInfo.userPoints[FormInfo.number] += 100;
                    FormInfo.number++;
                    if (FormInfo.number >= FormInfo.numberOfPlayers)
                    {
                        FormInfo.number %= FormInfo.numberOfPlayers;
                    }
                }
                else if (FormInfo.fieldCell[FormInfo.number] == 10 || FormInfo.fieldCell[FormInfo.number] == 20 || FormInfo.fieldCell[FormInfo.number] == 30)
                {
                    MessageBox.Show("Поздравляем! Вам выпала пустая клетка.");
                    FormInfo.number++;
                    if (FormInfo.number >= FormInfo.numberOfPlayers)
                    {
                        FormInfo.number %= FormInfo.numberOfPlayers;
                    }
                }
                else
                {
                    if (FormInfo.fieldCell[FormInfo.number] == 5 || FormInfo.fieldCell[FormInfo.number] == 15 || FormInfo.fieldCell[FormInfo.number] == 25 || FormInfo.fieldCell[FormInfo.number] == 35)
                    {
                        FormInfo.questionClass = false;
                    }
                    else
                    {
                        FormInfo.questionClass = true;
                    }
                    Form2 form2 = new Form2();
                    form2.Show();
                    form2.Owner = this;
                    form2.Focus();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!FormInfo.startOfGame)
            {
                currentPlayer.Text = $"Сейчас играет {FormInfo.number + 1}-й игрок.";
                string pointsInfo = "";
                for (int i = 0; i < FormInfo.numberOfPlayers; i++)
                {
                    pointsInfo += $"{i + 1}-й игрок - {FormInfo.userPoints[i]} очков.\n";
                }
                scoreInfo.Text = pointsInfo;
                bool stop = false;
                foreach (int elem in FormInfo.userPoints)
                {
                    if (elem >= 1000 || elem <= 0)
                    {
                        stop = true;
                    }
                }
                if (stop)
                {
                    List<int> index = new List<int>();
                    index.Add(0);
                    timer1.Enabled = false;
                    for (int j = 1; j < FormInfo.numberOfPlayers; j++)
                    {
                        if (FormInfo.userPoints[j] > FormInfo.userPoints[index[0]])
                        {
                            index.Clear();
                            index.Add(j);
                        }
                        else if (FormInfo.userPoints[j] >= FormInfo.userPoints[index[0]])
                        {
                            index.Add(j);
                        }
                    }
                    string str = "";
                    for (int j = 0; j < index.Count() - 1; j++) {
                        str += (index[j] + 1) + "-й, ";
                    }
                    str += (index[index.Count() - 1] + 1) + "-й ";
                    string i = "";
                    if (index.Count() > 1)
                    {
                        i = "и";
                    }
                    MessageBox.Show($"Выиграл{i} {str}игрок, набравшие {FormInfo.userPoints[index[0]]} очков. Поздравляем!");
                    Environment.Exit(0);
                }
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FormInfo.numberOfPlayers; i++)
            {
                graph.FillEllipse(new SolidBrush(colors[i]), 750, 750, 30, 30);
            }
            pictureBox1.Invalidate();
            button1.Visible = true;
            start.Visible = false;
            currentPlayer.Visible = true;
            scoreInfo.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (FormInfo.startOfGame)
            {
                MessageBox.Show("Вы начали нашу игру. \n" + rules);
                Form2 form2 = new Form2();
                form2.Show();
                form2.Owner = this;
                form2.Focus();
                this.Hide();
                start.Visible = true;
                sssstart.Visible = false;
                end.Visible = true;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}