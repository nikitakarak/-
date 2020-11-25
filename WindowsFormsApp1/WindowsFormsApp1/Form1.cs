using System;
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
        Bitmap bitmap;
        Graphics graph;
        int i = 0;
        int[] xPositions = {750, 667, 601, 535, 469, 403, 337, 271, 205, 139, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 139, 205, 271, 337, 403, 469, 535, 601, 667, 750, 750, 750, 750, 750, 750, 750, 750, 750, 750 };
        int[] yPositions = {750, 750, 750, 750, 750, 750, 750, 750, 750, 750, 750, 667, 601, 535, 469, 403, 337, 271, 205, 139, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 50, 139, 205, 271, 337, 403, 469, 535, 601, 667 };
        public Form1()
        {
            InitializeComponent();
            this.Width = 820;
            this.Height = 843;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graph = Graphics.FromImage(bitmap);
            pictureBox1.Image = bitmap;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            graph.FillEllipse(new SolidBrush(Color.Green), 750, 750, 10, 10);
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            label1.Text = xPositions[i % 40] + " " + yPositions[i % 40];
            graph.FillEllipse(new SolidBrush(Color.Green), xPositions[i % 40], yPositions[i % 40], 10, 10);
            pictureBox1.Invalidate();
        }
    }
}
