using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;


namespace iQuality
{
    public partial class Sonidos : Form
    {
        public int n=0;
        public Sonidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            wplayer.URL = "sonido " + n + ".mp3";
            wplayer.controls.stop();
            Random r = new Random();
            n = r.Next(1, 8);
            wplayer.URL = "sonido "+n+".mp3";
            wplayer.controls.play();
            button1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (n == 8)
            {
                MessageBox.Show("Winner");
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Loser");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (n == 1)
            {
                MessageBox.Show("Winner");
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Loser");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (n == 2)
            {
                MessageBox.Show("Winner");
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Loser");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (n == 3)
            {
                MessageBox.Show("Winner");
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Loser");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (n == 4)
            {
                MessageBox.Show("Winner");
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Loser");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (n == 5)
            {
                MessageBox.Show("Winner");
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Loser");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (n == 6)
            {
                MessageBox.Show("Winner");
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Loser");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (n == 7)
            {
                MessageBox.Show("Winner");
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Loser");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
