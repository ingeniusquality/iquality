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
    public partial class Comparar_imagenes : Form
    {
        public string opcion;
        public int tiempo = 60;
        public int puntaje = 0;
        public Comparar_imagenes()
        {
            InitializeComponent();
        }

        private void Comparar_imagenes_Load(object sender, EventArgs e)
        {
            Random numero = new Random();
            int numeroran = numero.Next(1, 3);
            if (numeroran == 1)
            {
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
                button24.Enabled = false;
                button25.Enabled = false;
                button26.Enabled = false;
                button27.Enabled = false;
                button28.Enabled = false;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
            }
            opcion = "juego " + numeroran + ".jpg";
            switch(numeroran)
            {
                case 1: this.BackgroundImage = iQuality.Properties.Resources.buho;
                    break;
                case 2: this.BackgroundImage = iQuality.Properties.Resources.aguila;
                    break;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            button17.Enabled = false;
            button18.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button17.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            button17.Enabled = false;
            button18.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button17.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
            button19.Enabled = false;
            button20.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button19.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
            button19.Enabled = false;
            button20.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button19.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;
            button21.Enabled = false;
            button22.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button21.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;
            button21.Enabled = false;
            button22.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button21.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = false;
            button23.Enabled = false;
            button24.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button23.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;
            button24.Enabled = false;
            button23.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button24.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
            button25.Enabled = false;
            button26.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button25.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
            button25.Enabled = false;
            button26.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button25.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Enabled = false;
            button27.Enabled = false;
            button28.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button27.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button28.Enabled = false;
            button27.Enabled = false;
            button28.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button27.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            button7.Enabled = false;
            button16.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button7.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button8.Enabled = false;
            button15.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button8.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button4.Enabled = false;
            button14.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button4.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            button3.Enabled = false;
            button13.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button3.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            button2.Enabled = false;
            button12.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button2.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button6.Enabled = false;
            button11.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button6.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button5.Enabled = false;
            button10.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button5.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button1.Enabled = false;
            button9.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button1.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            button8.Enabled = false;
            button15.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button8.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            button7.Enabled = false;
            button16.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button7.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            button6.Enabled = false;
            button11.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button6.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button5.Enabled = false;
            button10.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button5.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            button4.Enabled = false;
            button14.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button4.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            button3.Enabled = false;
            button13.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button3.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            button2.Enabled = false;
            button12.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button2.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            button1.Enabled = false;
            button9.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            button1.BackgroundImage = iQuality.Properties.Resources.Circulo_36;
            MessageBox.Show("10 PUNTOS");
            puntaje = puntaje + 10;
            ganaste();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = tiempo.ToString();
            if (tiempo == 0)
            {
                timer1.Stop();
                perdiste();
            }
            tiempo--;
        }
        void ganaste()
        {
            if (puntaje == 80)
            {
                MessageBox.Show("Ganaste Felicidades");
                this.Close();
            }
        }
        void perdiste()
        {
            MessageBox.Show("Perdiste Suerte para la Otra");
            this.Close();
        }
    }
}
