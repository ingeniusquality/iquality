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
    public partial class Menu : Form
    {
        public int i = 0,i1=0,i2=0,i3=0,i4=0,i5=0,i6=0,i7=0,posicion;
        public int mouse,mouse1,mouse2,mouse3,mouse4,mouse5,mouse6,mouse7;
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Sonidos cambio = new Sonidos();
            cambio.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Pegatina mostrar = new Pegatina();
            mostrar.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Secuencia intru = new Secuencia();
            intru.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pegatina figuras = new Pegatina();
            figuras.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            mouse = 0;
            button1.BackgroundImage = Image.FromFile(@"(..\..\11.png");
            timer1.Enabled = true;
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mouse == 0)
            {
                i++;
                pictureBox2.Left += i;
                if (i >= 16)
                    timer1.Stop();
            }
            if (mouse == 1)
            {
                pictureBox2.Left -= i;
                if (i <= 0)
                {
                    timer1.Stop();
                }
                i--;
            }
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            mouse1 = 1;
            timer5.Enabled = true;
            timer5.Interval = 100;
            timer5.Start();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            mouse = 1;
            button1.BackgroundImage = Image.FromFile(@"(..\..\1.png");
            timer1.Enabled = true;
            timer1.Interval = 100;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rompecabezas puzzle = new Rompecabezas();
            puzzle.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            WindowsMediaPlayer musica_fondo = new WindowsMediaPlayer();
            musica_fondo.URL = "fondo.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Secuencia music = new Secuencia();
            music.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sonidos mostrar = new Sonidos();
            mostrar.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (mouse2 == 0)
            {
                i1++;
                pictureBox3.Left += i1;
                if (i1 >= 16)
                    timer2.Stop();
            }
            if (mouse2 == 1)
            {
                pictureBox3.Left -= i1;
                if (i1 <= 0)
                    timer2.Stop();
                i1--;
            }
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            mouse2 = 0;
            timer2.Enabled = true;
            timer2.Interval = 100;
            timer2.Start();
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            mouse2 = 1;
            timer2.Enabled = true;
            timer2.Interval = 100;
            timer2.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (mouse3 == 0)
            {
                i2++;
                pictureBox5.Top -= i2;
                if (i2 >= 11)
                    timer3.Stop();
            }
            if (mouse3 == 1)
            {
                pictureBox5.Top += i2;
                if (i2 <= 0)
                    timer3.Stop();
                i2--;
            }
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            mouse3 = 0;
            timer3.Enabled = true;
            timer3.Interval = 100;
            timer3.Start();
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            mouse3 = 1;
            timer3.Enabled = true;
            timer3.Interval = 100;
            timer3.Start();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            mouse4 = 0;
            timer4.Enabled = true;
            timer4.Interval = 100;
            timer4.Start();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            mouse4 = 1;
            timer4.Enabled = true;
            timer4.Interval = 100;
            timer4.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (mouse4 == 0)
            {
                i3++;
                pictureBox4.Top -= i3;
                if (i3 >= 12)
                    timer4.Stop();
            }
            if (mouse4 == 1)
            {
                pictureBox4.Top += i3;
                if (i3 <= 0)
                    timer4.Stop();
                i3--;
            }
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            mouse1 = 0;
            timer5.Enabled = true;
            timer5.Interval = 100;
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (mouse1 == 0)
            {
                i4++;
                pictureBox7.Top += i4;
                if (i4 >= 11)
                    timer5.Stop();
            }
            if (mouse1 == 1)
            {
                pictureBox7.Top -= i4;
                if (i4 <= 0)
                    timer5.Stop();
                i4--;
            }
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            mouse5 = 0;
            timer6.Enabled = true;
            timer6.Interval = 100;
            timer6.Start();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            mouse5 = 1;
            timer6.Enabled = true;
            timer6.Interval = 100;
            timer6.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (mouse5 == 0)
            {
                i5++;
                pictureBox8.Left -= i5;
                if (i5 >= 16)
                      timer6.Stop();
            }
            if (mouse5 == 1)
            {
                pictureBox8.Left += i5;
                if (i5 <= 0)
                    timer6.Stop();
                i5--;
            }
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            mouse6 = 0;
            timer7.Enabled = true;
            timer7.Interval = 100;
            timer7.Start();
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            mouse6 = 1;
            timer7.Enabled = true;
            timer7.Interval = 100;
            timer7.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (mouse6 == 0)
            {
                i6++;
                pictureBox9.Left += i6;
                if (i6 >= 16)
                    timer7.Stop();
            }
            if (mouse6 == 1)
            {
                pictureBox9.Left -= i6;
                if (i6 <= 0)
                    timer7.Stop();
                i6--;
            }
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            mouse7 = 0;
            timer8.Enabled = true;
            timer8.Interval = 100;
            timer8.Start();
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            mouse7 = 1;
            timer8.Enabled = true;
            timer8.Interval = 100;
            timer8.Start();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (mouse7 == 0)
            {
                i7++;
                pictureBox6.Top += i7;
                if (i7 >= 11)
                    timer8.Stop();
            }
            if (mouse7 == 1)
            {
                pictureBox6.Top -= i7;
                if (i7 <= 0)
                    timer8.Stop();
                i7--;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Comparar_imagenes diferecias = new Comparar_imagenes();
            diferecias.Show();
        }

    }
}
