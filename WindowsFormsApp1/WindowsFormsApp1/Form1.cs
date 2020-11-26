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
        Bitmap bitmap;
        Graphics graph;
        int fieldCell = 0;
        int[] xPositions = {750, 667, 601, 535, 469, 403, 337, 271, 205, 139, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 139, 205, 271, 337, 403, 469, 535, 601, 667, 750, 750, 750, 750, 750, 750, 750, 750, 750, 750 };
        int[] yPositions = {750, 750, 750, 750, 750, 750, 750, 750, 750, 750, 750, 667, 601, 535, 469, 403, 337, 271, 205, 139, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 139, 205, 271, 337, 403, 469, 535, 601, 667 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
            FormInfo.userPoints = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            graph.Clear(Color.Transparent);
            pictureBox1.BackgroundImage = Image.FromFile("monopolyField.jpg");
            int dice1 = Convert.ToInt32(rnd.Next(1, 7)), dice2 = Convert.ToInt32(rnd.Next(1, 7));
            fieldCell += dice1 + dice2;
            dices.Text = $"Значения на костях: {dice1}, {dice2}.";
            graph.FillEllipse(new SolidBrush(Color.Green), xPositions[fieldCell % 40], yPositions[fieldCell % 40], 10, 10);
            pictureBox1.Invalidate();
            if (fieldCell > 40)
            {
                fieldCell -= 40;
                FormInfo.userPoints += 100;
                MessageBox.Show("Вы прошли поле 'Старт' и получаете 100 очков.");
            }
            if (fieldCell == 2 || fieldCell == 4 || fieldCell == 7 || fieldCell == 12 || fieldCell == 17 || fieldCell == 22 || fieldCell == 28 || fieldCell == 33 || fieldCell == 36 || fieldCell == 38)
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
                FormInfo.userPoints += a;
            }
            else if (fieldCell == 40)
            {
                fieldCell -= 40;
                FormInfo.userPoints += 100;
                MessageBox.Show("Вы попали на поле 'Старт' и получаете 100 очков.");
            }
            else if (fieldCell == 10 || fieldCell == 20 || fieldCell == 30)
            {
                MessageBox.Show("Поздравляем! Вам выпала пустая клетка.");
            }
            else
            {
                if (fieldCell == 5 || fieldCell == 15 || fieldCell == 25 || fieldCell == 35)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            score.Text = $"У вас {FormInfo.userPoints} очков.";
            if (FormInfo.userPoints >= 1000)
            {
                MessageBox.Show("Поздравляем, вы выиграли.");
                timer1.Enabled = false;
            }
            else if (FormInfo.userPoints <= 0)
            {
                MessageBox.Show("К сожалению вы проиграли.");
                timer1.Enabled = false;
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            if (FormInfo.startOfGame)
            {
                MessageBox.Show("Вы начали нашу игру. \n" + rules);
                graph.FillEllipse(new SolidBrush(Color.Green), 750, 750, 10, 10);
                pictureBox1.Invalidate();
                FormInfo.startOfGame = false;
                button1.Visible = true;
                start.Visible = false;

            }
        }
    }
}
