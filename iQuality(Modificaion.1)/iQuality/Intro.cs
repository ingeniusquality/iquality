using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iQuality
{
    public partial class Intro : Form
    {
        public int i = 0;
        public Intro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 50;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
                label1.ForeColor = Color.Red;
            if (i % 3 == 0)
                label1.ForeColor = Color.Yellow;
            if (i % 4 == 0)
                label1.ForeColor = Color.Green;
            if (i % 5 == 0)
                label1.ForeColor = Color.Blue;
            label1.Text = Convert.ToString(i) + "%";
            if (i == 101)
            {
                timer1.Stop();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
