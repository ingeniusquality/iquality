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
    public partial class Secuencia : Form
    {
        public int cont_ori = 0, cont_play = 0,i,cont_sec=0;
        public WindowsMediaPlayer reproductor = new WindowsMediaPlayer();
        public Random seguidor_aleatorio = new Random();
        public string[] sonidos = { "musica/piano.mp3", "musica/flauta.mp3", "musica/trompeta.mp3", "musica/bateria.mp3", "musica/pandero.mp3", "musica/violin.mp3", "musica/arpa.mp3", "musica/guitarra.mp3", "musica/saxofon.mp3" };
        public string[] instrumentos2 = {"piano2.png","flauta2.png","trompeta2.png","bateria2.png","pandero2.png","violin2.png","arpa2.png","guitarra2.png","saxofon2.png" };
        public string[] instrumentos = { "piano.png", "flauta.png", "trompeta.png", "bateria.png", "pandero.png", "violin.png", "arpa.png", "guitarra.png", "saxofon.png" };
        public int[] secuencia_original = new int[20];
        public int[] secuencia_jugador = new int[20];
        public int seguidor;
        public int[] num_aleatorio = new int[9];
        public int[] num_aleatorio2 = new int[9];
        public Secuencia()
        {
            InitializeComponent();
        }

        private void Secuencia_Load(object sender, EventArgs e)
        {

            Cargar_Imagenes();
        }

        private void Cargar_Imagenes()
        {
            Random instrumento = new Random();
            int cont = 0;
            do
            {
                num_aleatorio[cont] = cont;
                cont++;
            } while (cont < 9);
            cont = 0;
            do
            {
                int x = instrumento.Next(0, 9);
                if (num_aleatorio[x] != -1)
                {
                    num_aleatorio2[cont] = num_aleatorio[x];
                    num_aleatorio[x] = -1;
                    cont++;
                }
            } while (cont < 9);
            pictureBox1.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[0]];
            pictureBox2.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[1]];
            pictureBox3.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[2]];
            pictureBox4.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[3]];
            pictureBox5.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[4]];
            pictureBox6.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[5]];
            pictureBox7.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[6]];
            pictureBox8.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[7]];
            pictureBox9.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[8]];
            //pictureBox1.Size = new System.Drawing.Size(60, 40);
            //pictureBox1.Size = new System.Drawing.Size(100, 107);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seguidor=seguidor_aleatorio.Next(0, 9);
            //secuencia_original[0] = seguidor;
            timer1.Enabled = true;
            timer1.Interval = 3000;
            //cont_ori++;
            switch (seguidor)
            {
                case 0: pictureBox1.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[0]];
                        reproductor.URL = sonidos[num_aleatorio2[0]];
                        secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                case 1: pictureBox2.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[1]];
                        reproductor.URL = sonidos[num_aleatorio2[1]];
                        secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                case 2: pictureBox3.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[2]];
                        reproductor.URL = sonidos[num_aleatorio2[2]];
                        secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                case 3: pictureBox4.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[3]];
                        reproductor.URL = sonidos[num_aleatorio2[3]];
                        secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                case 4: pictureBox5.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[4]];
                        reproductor.URL = sonidos[num_aleatorio2[4]];
                        secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                case 5: pictureBox6.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[5]];
                        reproductor.URL = sonidos[num_aleatorio2[5]];
                        secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                case 6: pictureBox7.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[6]];
                        reproductor.URL = sonidos[num_aleatorio2[6]];
                        secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                case 7: pictureBox8.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[7]];
                        reproductor.URL = sonidos[num_aleatorio2[7]];
                        secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                case 8: pictureBox9.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[8]];
                        reproductor.URL = sonidos[num_aleatorio2[8]];
                        secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[0]];
            pictureBox2.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[1]];
            pictureBox3.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[2]];
            pictureBox4.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[3]];
            pictureBox5.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[4]];
            pictureBox6.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[5]];
            pictureBox7.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[6]];
            pictureBox8.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[7]];
            pictureBox9.ImageLocation = @"(..\..\musica\" + instrumentos[num_aleatorio2[8]];
            timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cont_sec <= cont_ori)
            {
                secuencia_jugador[cont_sec] = 0;
                if (secuencia_original[cont_sec] != secuencia_jugador[cont_sec])
                {
                    MessageBox.Show("Mal, Juego terminado");
                    this.Close();
                }
            }
            if (cont_sec == cont_ori)
            {
                if (cont_ori == 19)
                    MessageBox.Show("Lo haz conseguido");
                else
                {
                    MessageBox.Show("Bien, ahora un poco mas dificil");
                    cont_ori++;
                    i = 0;
                    timer2.Interval = 3000;
                    timer2.Start();
                    cont_play++;
                    cont_sec = 0;
                }
            }
            else
                cont_sec++;
        }
        private void random()
        {
            seguidor = seguidor_aleatorio.Next(0, 9);
            //secuencia_original[cont_ori] = seguidor;
            timer1.Enabled = true;
            timer1.Interval = 3000;
            //cont_ori++;
            switch (seguidor)
            {
                case 0: pictureBox1.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[0]];
                    reproductor.URL = sonidos[num_aleatorio2[0]];
                    secuencia_original[cont_ori] = seguidor;
                    timer1.Start();
                    break;
                case 1: pictureBox2.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[1]];
                    reproductor.URL = sonidos[num_aleatorio2[1]];
                    secuencia_original[cont_ori] = seguidor;
                    timer1.Start();
                    break;
                case 2: pictureBox3.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[2]];
                    reproductor.URL = sonidos[num_aleatorio2[2]];
                    secuencia_original[cont_ori] = seguidor;
                    timer1.Start();
                    break;
                case 3: pictureBox4.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[3]];
                    reproductor.URL = sonidos[num_aleatorio2[3]];
                    secuencia_original[cont_ori] = seguidor;
                    timer1.Start();
                    break;
                case 4: pictureBox5.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[4]];
                    reproductor.URL = sonidos[num_aleatorio2[4]];
                    secuencia_original[cont_ori] = seguidor;
                    timer1.Start();
                    break;
                case 5: pictureBox6.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[5]];
                    reproductor.URL = sonidos[num_aleatorio2[5]];
                    secuencia_original[cont_ori] = seguidor;
                    timer1.Start();
                    break;
                case 6: pictureBox7.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[6]];
                    reproductor.URL = sonidos[num_aleatorio2[6]];
                    secuencia_original[cont_ori] = seguidor;
                    timer1.Start();
                    break;
                case 7: pictureBox8.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[7]];
                    reproductor.URL = sonidos[num_aleatorio2[7]];
                    secuencia_original[cont_ori] = seguidor;
                    timer1.Start();
                    break;
                case 8: pictureBox9.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[8]];
                    reproductor.URL = sonidos[num_aleatorio2[8]];
                    secuencia_original[cont_ori] = seguidor;
                    timer1.Start();
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (cont_sec <= cont_ori)
            {
                secuencia_jugador[cont_sec] = 1;
                if (secuencia_original[cont_sec] != secuencia_jugador[cont_sec])
                {
                    MessageBox.Show("Mal, Juego terminado");
                    this.Close();
                }
            }
            if (cont_sec == cont_ori)
            {
                if (cont_ori == 19)
                    MessageBox.Show("Lo haz conseguido");
                else
                {
                    MessageBox.Show("Bien, ahora un poco mas dificil");
                    cont_ori++;
                    i = 0;
                    timer2.Interval = 3000;
                    timer2.Start();
                    cont_play++;
                    cont_sec = 0;
                }
            }
            else
                cont_sec++;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (cont_sec <= cont_ori)
            {
                secuencia_jugador[cont_sec] = 2;
                if (secuencia_original[cont_sec] != secuencia_jugador[cont_sec])
                {
                    MessageBox.Show("Mal, Juego terminado");
                    this.Close();
                }
            }
            if (cont_sec == cont_ori)
            {
                if (cont_ori == 19)
                    MessageBox.Show("Lo haz conseguido");
                else
                {
                    MessageBox.Show("Bien, ahora un poco mas dificil");
                    cont_ori++;
                    i = 0;
                    timer2.Interval = 3000;
                    timer2.Start();
                    cont_play++;
                    cont_sec = 0;
                }
            }
            else
                cont_sec++;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (cont_sec <= cont_ori)
            {
                secuencia_jugador[cont_sec] = 3;
                if (secuencia_original[cont_sec] != secuencia_jugador[cont_sec])
                {
                    MessageBox.Show("Mal, Juego terminado");
                    this.Close();
                }
            }
            if (cont_sec == cont_ori)
            {
                if (cont_ori == 19)
                    MessageBox.Show("Lo haz conseguido");
                else
                {
                    MessageBox.Show("Bien, ahora un poco mas dificil");
                    cont_ori++;
                    i = 0;
                    timer2.Interval = 3000;
                    timer2.Start();
                    cont_play++;
                    cont_sec = 0;
                }
            }
            else
                cont_sec++;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (cont_sec <= cont_ori)
            {
                secuencia_jugador[cont_sec] = 4;
                if (secuencia_original[cont_sec] != secuencia_jugador[cont_sec])
                {
                    MessageBox.Show("Mal, Juego terminado");
                    this.Close();
                }
            }
            if (cont_sec == cont_ori)
            {
                if (cont_ori == 19)
                    MessageBox.Show("Lo haz conseguido");
                else
                {
                    MessageBox.Show("Bien, ahora un poco mas dificil");
                    cont_ori++;
                    i = 0;
                    timer2.Interval = 3000;
                    timer2.Start();
                    cont_play++;
                    cont_sec = 0;
                }
            }
            else
                cont_sec++;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (cont_sec <= cont_ori)
            {
                secuencia_jugador[cont_sec] = 5;
                if (secuencia_original[cont_sec] != secuencia_jugador[cont_sec])
                {
                    MessageBox.Show("Mal, Juego terminado");
                    this.Close();
                }
            }
            if (cont_sec == cont_ori)
            {
                if (cont_ori == 19)
                    MessageBox.Show("Lo haz conseguido");
                else
                {
                    MessageBox.Show("Bien, ahora un poco mas dificil");
                    cont_ori++;
                    i = 0;
                    timer2.Interval = 3000;
                    timer2.Start();
                    cont_play++;
                    cont_sec = 0;
                }
            }
            else
                cont_sec++;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (cont_sec <= cont_ori)
            {
                secuencia_jugador[cont_sec] = 6;
                if (secuencia_original[cont_sec] != secuencia_jugador[cont_sec])
                {
                    MessageBox.Show("Mal, Juego terminado");
                    this.Close();
                }
            }
            if (cont_sec == cont_ori)
            {
                if (cont_ori == 19)
                    MessageBox.Show("Lo haz conseguido");
                else
                {
                    MessageBox.Show("Bien, ahora un poco mas dificil");
                    cont_ori++;
                    i = 0;
                    timer2.Interval = 3000;
                    timer2.Start();
                    cont_play++;
                    cont_sec = 0;
                }
            }
            else
                cont_sec++;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (cont_sec <= cont_ori)
            {
                secuencia_jugador[cont_sec] = 7;
                if (secuencia_original[cont_sec] != secuencia_jugador[cont_sec])
                {
                    MessageBox.Show("Mal, Juego terminado");
                    this.Close();
                }
            }
            if (cont_sec == cont_ori)
            {
                if (cont_ori == 19)
                    MessageBox.Show("Lo haz conseguido");
                else
                {
                    MessageBox.Show("Bien, ahora un poco mas dificil");
                    cont_ori++;
                    i = 0;
                    timer2.Interval = 3000;
                    timer2.Start();
                    cont_play++;
                    cont_sec = 0;
                }
            }
            else
                cont_sec++;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (cont_sec <= cont_ori)
            {
                secuencia_jugador[cont_sec] = 8;
                if (secuencia_original[cont_sec] != secuencia_jugador[cont_sec])
                {
                    MessageBox.Show("Mal, Juego terminado");
                    this.Close();
                }
            }
            if (cont_sec == cont_ori)
            {
                if (cont_ori == 19)
                    MessageBox.Show("Lo haz conseguido");
                else
                {
                    MessageBox.Show("Bien, ahora un poco mas dificil");
                    cont_ori++;
                    i = 0;
                    timer2.Interval = 3000;
                    timer2.Start();
                    cont_play++;
                    cont_sec = 0;
                }
            }
            else
                cont_sec++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (i < cont_ori)
                switch (secuencia_original[i])
                {
                    case 0: pictureBox1.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[0]];
                        reproductor.URL = sonidos[num_aleatorio2[0]];
                        //secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                    case 1: pictureBox2.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[1]];
                        reproductor.URL = sonidos[num_aleatorio2[1]];
                        //secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                    case 2: pictureBox3.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[2]];
                        reproductor.URL = sonidos[num_aleatorio2[2]];
                        //secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                    case 3: pictureBox4.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[3]];
                        reproductor.URL = sonidos[num_aleatorio2[3]];
                        //secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                    case 4: pictureBox5.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[4]];
                        reproductor.URL = sonidos[num_aleatorio2[4]];
                        //secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                    case 5: pictureBox6.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[5]];
                        reproductor.URL = sonidos[num_aleatorio2[5]];
                        //secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                    case 6: pictureBox7.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[6]];
                        reproductor.URL = sonidos[num_aleatorio2[6]];
                        //secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                    case 7: pictureBox8.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[7]];
                        reproductor.URL = sonidos[num_aleatorio2[7]];
                        //secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                    case 8: pictureBox9.ImageLocation = @"(..\..\musica\" + instrumentos2[num_aleatorio2[8]];
                        reproductor.URL = sonidos[num_aleatorio2[8]];
                        //secuencia_original[cont_ori] = seguidor;
                        timer1.Start();
                        break;
                }
            else
            {
                random();
                timer2.Stop();
            }
            i++;
        }
    }
}
