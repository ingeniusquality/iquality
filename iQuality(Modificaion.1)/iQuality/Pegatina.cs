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
    public partial class Pegatina : Form
    {
        public Random imagenes_geometricas = new Random();
        public string nombre_figura;
        public int pic = 0;
        public string[] figuras = { "circulo.png", "estrella.png", "cuadrado.png", "rectangulo.png", "triangulo.png", "hexagono.png", "pentagono.png", "octagono.png", "trapecio.png", "rombo.png" };
        public string[] figuras1 = { "circulo.png", "estrella.png", "cuadrado.png", "rectangulo.png", "triangulo.png", "hexagono.png", "pentagono.png", "octagono.png", "trapecio.png", "rombo.png" };
        public int[] num_aleatorio = new int[10];
        public int[] num_aleatorio2 = new int[10];
        public int[] num_aleatorio3 = new int[10];
        public int z = 0;
        public int i = 0;
        public Pegatina()
        {
            InitializeComponent();
        }
        private void Cargar_Imagenes()
        {
            int cont = 0;
            do
            {
                num_aleatorio[cont] = cont;
                cont++;
            } while (cont < 10);
            cont = 0;
            do
            {
                int x = imagenes_geometricas.Next(0, 10);
                if (num_aleatorio[x] != -1)
                {
                    num_aleatorio2[cont] = num_aleatorio[x];
                    num_aleatorio[x] = -1;
                    cont++;
                }
            } while (cont < 10);
            pictureBox1.ImageLocation = @"(..\..\imagenes3\" + figuras[num_aleatorio2[0]];
            pictureBox2.ImageLocation = @"(..\..\imagenes3\" + figuras[num_aleatorio2[1]];
            pictureBox3.ImageLocation = @"(..\..\imagenes3\" + figuras[num_aleatorio2[2]];
            pictureBox4.ImageLocation = @"(..\..\imagenes3\" + figuras[num_aleatorio2[3]];
            pictureBox5.ImageLocation = @"(..\..\imagenes3\" + figuras[num_aleatorio2[4]];
            pictureBox6.ImageLocation = @"(..\..\imagenes3\" + figuras[num_aleatorio2[5]];
            pictureBox7.ImageLocation = @"(..\..\imagenes3\" + figuras[num_aleatorio2[6]];
            pictureBox8.ImageLocation = @"(..\..\imagenes3\" + figuras[num_aleatorio2[7]];
            pictureBox9.ImageLocation = @"(..\..\imagenes3\" + figuras[num_aleatorio2[8]];
            pictureBox10.ImageLocation = @"(..\..\imagenes3\" + figuras[num_aleatorio2[9]];
        }
        private void Cargar_Imagenes2()
        {
            int cont2 = 0;
            do
            {
                num_aleatorio[cont2] = cont2;
                cont2++;
            } while (cont2 < 10);
            cont2 = 0;
            do
            {
                int y = imagenes_geometricas.Next(0, 10);
                if (num_aleatorio[y] != -1)
                {
                    num_aleatorio3[cont2] = num_aleatorio[y];
                    num_aleatorio[y] = -1;
                    cont2++;
                }
            } while (cont2 < 10);
            pictureBox11.ImageLocation = @"(..\..\imagenes4\" + figuras1[num_aleatorio3[0]];
            pictureBox12.ImageLocation = @"(..\..\imagenes4\" + figuras1[num_aleatorio3[1]];
            pictureBox13.ImageLocation = @"(..\..\imagenes4\" + figuras1[num_aleatorio3[2]];
            pictureBox14.ImageLocation = @"(..\..\imagenes4\" + figuras1[num_aleatorio3[3]];
            pictureBox15.ImageLocation = @"(..\..\imagenes4\" + figuras1[num_aleatorio3[4]];
            pictureBox16.ImageLocation = @"(..\..\imagenes4\" + figuras1[num_aleatorio3[5]];
            pictureBox17.ImageLocation = @"(..\..\imagenes4\" + figuras1[num_aleatorio3[6]];
            pictureBox18.ImageLocation = @"(..\..\imagenes4\" + figuras1[num_aleatorio3[7]];
            pictureBox19.ImageLocation = @"(..\..\imagenes4\" + figuras1[num_aleatorio3[8]];
            pictureBox20.ImageLocation = @"(..\..\imagenes4\" + figuras1[num_aleatorio3[9]];
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            nombre_figura = figuras[num_aleatorio2[0]];
            pic = 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nombre_figura = figuras[num_aleatorio2[1]];
            pic = 2;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            nombre_figura = figuras[num_aleatorio2[2]];
            pic = 3;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            nombre_figura = figuras[num_aleatorio2[3]];
            pic = 4;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            nombre_figura = figuras[num_aleatorio2[4]];
            pic = 5;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            nombre_figura = figuras[num_aleatorio2[5]];
            pic = 6;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            nombre_figura = figuras[num_aleatorio2[9]];
            pic = 10;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            nombre_figura = figuras[num_aleatorio2[8]];
            pic = 9;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            nombre_figura = figuras[num_aleatorio2[6]];
            pic = 7;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            nombre_figura = figuras[num_aleatorio2[7]];
            pic = 8;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (figuras1[num_aleatorio3[0]] == nombre_figura)
            {
                z++;
                switch (pic)
                {
                    case 1:
                        pictureBox1.Location = pictureBox11.Location;
                        break;
                    case 2:
                        pictureBox2.Location = pictureBox11.Location;
                        break;
                    case 3:
                        pictureBox3.Location = pictureBox11.Location;
                        break;
                    case 4:
                        pictureBox4.Location = pictureBox11.Location;
                        break;
                    case 5:
                        pictureBox5.Location = pictureBox11.Location;
                        break;
                    case 6:
                        pictureBox6.Location = pictureBox11.Location;
                        break;
                    case 7:
                        pictureBox7.Location = pictureBox11.Location;
                        break;
                    case 8:
                        pictureBox8.Location = pictureBox11.Location;
                        break;
                    case 9:
                        pictureBox9.Location = pictureBox11.Location;
                        break;
                    case 10:
                        pictureBox10.Location = pictureBox11.Location;
                        break;
                }

            }
            else
            {
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tTE EQUIVOCASTE";
            }
            if (z == 10 && i < 120)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.SkyBlue;
                label2.Text = "\n\tFelicidades\n Puntaje: " + z;
            }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (figuras1[num_aleatorio3[1]] == nombre_figura)
            {
                z++;
                switch (pic)
                {
                    case 1:
                        pictureBox1.Location = pictureBox12.Location;
                        break;
                    case 2:
                        pictureBox2.Location = pictureBox12.Location;
                        break;
                    case 3:
                        pictureBox3.Location = pictureBox12.Location;
                        break;
                    case 4:
                        pictureBox4.Location = pictureBox12.Location;
                        break;
                    case 5:
                        pictureBox5.Location = pictureBox12.Location;
                        break;
                    case 6:
                        pictureBox6.Location = pictureBox12.Location;
                        break;
                    case 7:
                        pictureBox7.Location = pictureBox12.Location;
                        break;
                    case 8:
                        pictureBox8.Location = pictureBox12.Location;
                        break;
                    case 9:
                        pictureBox9.Location = pictureBox12.Location;
                        break;
                    case 10:
                        pictureBox10.Location = pictureBox12.Location;
                        break;
                }
            }
            else
            {
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tTE EQUIVOCASTE";
            }
            if (z == 10 && i < 120)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.SkyBlue;
                label2.Text = "\n\tFelicidades\n Puntaje: " + z;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (figuras1[num_aleatorio3[2]] == nombre_figura)
            {
                z++;
                switch (pic)
                {
                    case 1:
                        pictureBox1.Location = pictureBox13.Location;
                        break;
                    case 2:
                        pictureBox2.Location = pictureBox13.Location;
                        break;
                    case 3:
                        pictureBox3.Location = pictureBox13.Location;
                        break;
                    case 4:
                        pictureBox4.Location = pictureBox13.Location;
                        break;
                    case 5:
                        pictureBox5.Location = pictureBox13.Location;
                        break;
                    case 6:
                        pictureBox6.Location = pictureBox13.Location;
                        break;
                    case 7:
                        pictureBox7.Location = pictureBox13.Location;
                        break;
                    case 8:
                        pictureBox8.Location = pictureBox13.Location;
                        break;
                    case 9:
                        pictureBox9.Location = pictureBox13.Location;
                        break;
                    case 10:
                        pictureBox10.Location = pictureBox13.Location;
                        break;
                }
            }
            else
            {
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tTE EQUIVOCASTE";
            }
            if (z == 10 && i < 120)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.SkyBlue;
                label2.Text = "\n\tFelicidades\n Puntaje: " + z;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (figuras1[num_aleatorio3[3]] == nombre_figura)
            {
                z++;
                switch (pic)
                {
                    case 1:
                        pictureBox1.Location = pictureBox14.Location;
                        break;
                    case 2:
                        pictureBox2.Location = pictureBox14.Location;
                        break;
                    case 3:
                        pictureBox3.Location = pictureBox14.Location;
                        break;
                    case 4:
                        pictureBox4.Location = pictureBox14.Location;
                        break;
                    case 5:
                        pictureBox5.Location = pictureBox14.Location;
                        break;
                    case 6:
                        pictureBox6.Location = pictureBox14.Location;
                        break;
                    case 7:
                        pictureBox7.Location = pictureBox14.Location;
                        break;
                    case 8:
                        pictureBox8.Location = pictureBox14.Location;
                        break;
                    case 9:
                        pictureBox9.Location = pictureBox14.Location;
                        break;
                    case 10:
                        pictureBox10.Location = pictureBox14.Location;
                        break;
                }
            }
            else
            {
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tTE EQUIVOCASTE";
            }
            if (z == 10 && i < 120)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.SkyBlue;
                label2.Text = "\n\tFelicidades\n Puntaje: " + z;
            }

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (figuras1[num_aleatorio3[4]] == nombre_figura)
            {
                z++;
                switch (pic)
                {
                    case 1:
                        pictureBox1.Location = pictureBox15.Location;
                        break;
                    case 2:
                        pictureBox2.Location = pictureBox15.Location;
                        break;
                    case 3:
                        pictureBox3.Location = pictureBox15.Location;
                        break;
                    case 4:
                        pictureBox4.Location = pictureBox15.Location;
                        break;
                    case 5:
                        pictureBox5.Location = pictureBox15.Location;
                        break;
                    case 6:
                        pictureBox6.Location = pictureBox15.Location;
                        break;
                    case 7:
                        pictureBox7.Location = pictureBox15.Location;
                        break;
                    case 8:
                        pictureBox8.Location = pictureBox15.Location;
                        break;
                    case 9:
                        pictureBox9.Location = pictureBox15.Location;
                        break;
                    case 10:
                        pictureBox10.Location = pictureBox15.Location;
                        break;
                }
            }
            else
            {
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tTE EQUIVOCASTE";
            }
            if (z == 10 && i < 120)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.SkyBlue;
                label2.Text = "\n\tFelicidades\n Puntaje: " + z;
            }

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (figuras1[num_aleatorio3[5]] == nombre_figura)
            {
                z++;
                switch (pic)
                {
                    case 1:
                        pictureBox1.Location = pictureBox16.Location;
                        break;
                    case 2:
                        pictureBox2.Location = pictureBox16.Location;
                        break;
                    case 3:
                        pictureBox3.Location = pictureBox16.Location;
                        break;
                    case 4:
                        pictureBox4.Location = pictureBox16.Location;
                        break;
                    case 5:
                        pictureBox5.Location = pictureBox16.Location;
                        break;
                    case 6:
                        pictureBox6.Location = pictureBox16.Location;
                        break;
                    case 7:
                        pictureBox7.Location = pictureBox16.Location;
                        break;
                    case 8:
                        pictureBox8.Location = pictureBox16.Location;
                        break;
                    case 9:
                        pictureBox9.Location = pictureBox16.Location;
                        break;
                    case 10:
                        pictureBox10.Location = pictureBox16.Location;
                        break;
                }
            }
            else
            {
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tTE EQUIVOCASTE";
            }
            if (z == 10 && i < 120)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.SkyBlue;
                label2.Text = "\n\tFelicidades\n Puntaje: " + z;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (figuras1[num_aleatorio3[6]] == nombre_figura)
            {
                z++;
                switch (pic)
                {
                    case 1:
                        pictureBox1.Location = pictureBox17.Location;
                        break;
                    case 2:
                        pictureBox2.Location = pictureBox17.Location;
                        break;
                    case 3:
                        pictureBox3.Location = pictureBox17.Location;
                        break;
                    case 4:
                        pictureBox4.Location = pictureBox17.Location;
                        break;
                    case 5:
                        pictureBox5.Location = pictureBox17.Location;
                        break;
                    case 6:
                        pictureBox6.Location = pictureBox17.Location;
                        break;
                    case 7:
                        pictureBox7.Location = pictureBox17.Location;
                        break;
                    case 8:
                        pictureBox8.Location = pictureBox17.Location;
                        break;
                    case 9:
                        pictureBox9.Location = pictureBox17.Location;
                        break;
                    case 10:
                        pictureBox10.Location = pictureBox17.Location;
                        break;
                }
            }
            else
            {
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tTE EQUIVOCASTE";
            }
            if (z == 10 && i < 120)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.SkyBlue;
                label2.Text = "\n\tFelicidades\n Puntaje: " + z;
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (figuras1[num_aleatorio3[7]] == nombre_figura)
            {
                z++;
                switch (pic)
                {
                    case 1:
                        pictureBox1.Location = pictureBox18.Location;
                        break;
                    case 2:
                        pictureBox2.Location = pictureBox18.Location;
                        break;
                    case 3:
                        pictureBox3.Location = pictureBox18.Location;
                        break;
                    case 4:
                        pictureBox4.Location = pictureBox18.Location;
                        break;
                    case 5:
                        pictureBox5.Location = pictureBox18.Location;
                        break;
                    case 6:
                        pictureBox6.Location = pictureBox18.Location;
                        break;
                    case 7:
                        pictureBox7.Location = pictureBox18.Location;
                        break;
                    case 8:
                        pictureBox8.Location = pictureBox18.Location;
                        break;
                    case 9:
                        pictureBox9.Location = pictureBox18.Location;
                        break;
                    case 10:
                        pictureBox10.Location = pictureBox18.Location;
                        break;
                }
            }
            else
            {
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tTE EQUIVOCASTE";
            }
            if (z == 10 && i < 120)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.SkyBlue;
                label2.Text = "\n\tFelicidades\n Puntaje: " + z;
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (figuras1[num_aleatorio3[8]] == nombre_figura)
            {
                z++;
                switch (pic)
                {
                    case 1:
                        pictureBox1.Location = pictureBox19.Location;
                        break;
                    case 2:
                        pictureBox2.Location = pictureBox19.Location;
                        break;
                    case 3:
                        pictureBox3.Location = pictureBox19.Location;
                        break;
                    case 4:
                        pictureBox4.Location = pictureBox19.Location;
                        break;
                    case 5:
                        pictureBox5.Location = pictureBox19.Location;
                        break;
                    case 6:
                        pictureBox6.Location = pictureBox19.Location;
                        break;
                    case 7:
                        pictureBox7.Location = pictureBox19.Location;
                        break;
                    case 8:
                        pictureBox8.Location = pictureBox19.Location;
                        break;
                    case 9:
                        pictureBox9.Location = pictureBox19.Location;
                        break;
                    case 10:
                        pictureBox10.Location = pictureBox19.Location;
                        break;
                }
            }
            else
            {
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tTE EQUIVOCASTE";
            }
            if (z == 10 && i < 120)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Black;
                label2.Text = "\n\tFelicidades\n Puntaje: " + z;
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (figuras1[num_aleatorio3[9]] == nombre_figura)
            {
                z++;
                switch (pic)
                {
                    case 1:
                        pictureBox1.Location = pictureBox20.Location;
                        break;
                    case 2:
                        pictureBox2.Location = pictureBox20.Location;
                        break;
                    case 3:
                        pictureBox3.Location = pictureBox20.Location;
                        break;
                    case 4:
                        pictureBox4.Location = pictureBox20.Location;
                        break;
                    case 5:
                        pictureBox5.Location = pictureBox20.Location;
                        break;
                    case 6:
                        pictureBox6.Location = pictureBox20.Location;
                        break;
                    case 7:
                        pictureBox7.Location = pictureBox20.Location;
                        break;
                    case 8:
                        pictureBox8.Location = pictureBox20.Location;
                        break;
                    case 9:
                        pictureBox9.Location = pictureBox20.Location;
                        break;
                    case 10:
                        pictureBox10.Location = pictureBox20.Location;
                        break;
                }
            }
            else
            {
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tTE EQUIVOCASTE";
            }
            if (z == 10 && i<120)
            {
                timer1.Stop();
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.SkyBlue;
                label2.Text = "\n\tFelicidades\n Puntaje: " + z;
            }
        }

        private void Pegatina_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 300;
            Cargar_Imagenes();
            Cargar_Imagenes2();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
                label3.ForeColor = Color.Black;
            if (i % 3 == 0)
                label3.ForeColor = Color.Blue;
            if (i % 4 == 0)
                label1.ForeColor = Color.Black;
            if (i % 5 == 0)
                label3.ForeColor = Color.Blue;
            if (i % 6 == 0)
                label3.ForeColor = Color.Black;
            label3.Text = Convert.ToString(i) + "%";
            if (i == 120)
            {
                timer1.Stop();
                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
                pictureBox6.Enabled = false;
                pictureBox7.Enabled = false;
                pictureBox8.Enabled = false;
                pictureBox9.Enabled = false;
                pictureBox10.Enabled = false;
                pictureBox11.Enabled = false;
                pictureBox12.Enabled = false;
                pictureBox13.Enabled = false;
                pictureBox14.Enabled = false;
                pictureBox15.Enabled = false;
                pictureBox16.Enabled = false;
                pictureBox17.Enabled = false;
                pictureBox18.Enabled = false;
                pictureBox19.Enabled = false;
                pictureBox20.Enabled = false;
                pictureBox1.Enabled = false;
                label2.Visible = true;
                label2.Font = new Font("Arial", 16);
                label2.Font = new System.Drawing.Font(label1.Font, FontStyle.Italic);
                label2.ForeColor = Color.Red;
                label2.Text = "\n\tPerdiste Juego Finalizado";
            }
        }

    }
}
