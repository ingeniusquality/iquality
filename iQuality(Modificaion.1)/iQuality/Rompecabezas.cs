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
    public partial class Rompecabezas : Form
    {
        public int[] matriz = new int[9];
        int img = 0;

        public Rompecabezas()
        {
            InitializeComponent();
        }

        private void image()
        {

            int val = 0;
            Random rand = new Random();
            img = rand.Next(1, 3);
            val = rand.Next(1, 9);
            for (int i = 0; i < 9; i++)
            {
                if (val >= 10)
                {
                    val = 1;
                }
                matriz[i] = val;
                val++;
            }
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[0]) + ".png");
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[1]) + ".png");
            pictureBox3.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[2]) + ".png");
            pictureBox4.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[3]) + ".png");
            pictureBox5.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[4]) + ".png");
            pictureBox6.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[5]) + ".png");
            pictureBox7.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[6]) + ".png");
            pictureBox8.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[7]) + ".png");
            pictureBox9.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[8]) + ".png");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int aux;
            if (matriz[1] == 9)
            {
                aux = matriz[0];
                matriz[0] = matriz[1];
                matriz[1] = aux;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[0]) + ".png");
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[1]) + ".png");
            }
            else if (matriz[3] == 9)
            {
                aux = matriz[0];
                matriz[0] = matriz[3];
                matriz[3] = aux;
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[0]) + ".png");
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[3]) + ".png");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int aux;
            if (matriz[0] == 9)
            {
                aux = matriz[1];
                matriz[1] = matriz[0];
                matriz[0] = aux;
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[1]) + ".png");
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[0]) + ".png");
            }
            else if (matriz[2] == 9)
            {
                aux = matriz[1];
                matriz[1] = matriz[2];
                matriz[2] = aux;
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[1]) + ".png");
                pictureBox3.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[2]) + ".png");
            }
            else if (matriz[4] == 9)
            {
                aux = matriz[1];
                matriz[1] = matriz[4];
                matriz[4] = aux;
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[1]) + ".png");
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[4]) + ".png");
            }
        }

        private void Rompecabezas_Load(object sender, EventArgs e)
        {
            image();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int aux;
            if (matriz[1] == 9)
            {
                aux = matriz[2];
                matriz[2] = matriz[1];
                matriz[1] = aux;
                pictureBox3.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[2]) + ".png");
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[1]) + ".png");
            }
            else if (matriz[5] == 9)
            {
                aux = matriz[2];
                matriz[2] = matriz[5];
                matriz[5] = aux;
                pictureBox3.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[2]) + ".png");
                pictureBox6.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[5]) + ".png");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int aux;
            if (matriz[0] == 9)
            {
                aux = matriz[3];
                matriz[3] = matriz[0];
                matriz[0] = aux;
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[3]) + ".png");
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[0]) + ".png");
            }
            else if (matriz[4] == 9)
            {
                aux = matriz[3];
                matriz[3] = matriz[4];
                matriz[4] = aux;
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[3]) + ".png");
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[4]) + ".png");
            }
            else if (matriz[6] == 9)
            {
                aux = matriz[3];
                matriz[3] = matriz[6];
                matriz[6] = aux;
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[3]) + ".png");
                pictureBox7.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[6]) + ".png");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int aux;
            if (matriz[1] == 9)
            {
                aux = matriz[4];
                matriz[4] = matriz[1];
                matriz[1] = aux;
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[4]) + ".png");
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[1]) + ".png");
            }
            else if (matriz[3] == 9)
            {
                aux = matriz[4];
                matriz[4] = matriz[3];
                matriz[3] = aux;
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[4]) + ".png");
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[3]) + ".png");
            }
            else if (matriz[5] == 9)
            {
                aux = matriz[4];
                matriz[4] = matriz[5];
                matriz[5] = aux;
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[4]) + ".png");
                pictureBox6.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[5]) + ".png");
            }
            else if (matriz[7] == 9)
            {
                aux = matriz[4];
                matriz[4] = matriz[7];
                matriz[7] = aux;
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[4]) + ".png");
                pictureBox8.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[7]) + ".png");
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int aux;
            if (matriz[2] == 9)
            {
                aux = matriz[5];
                matriz[5] = matriz[2];
                matriz[2] = aux;
                pictureBox6.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[5]) + ".png");
                pictureBox3.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[2]) + ".png");
            }
            else if (matriz[4] == 9)
            {
                aux = matriz[5];
                matriz[5] = matriz[4];
                matriz[4] = aux;
                pictureBox6.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[5]) + ".png");
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[4]) + ".png");
            }
            else if (matriz[8] == 9)
            {
                aux = matriz[5];
                matriz[5] = matriz[8];
                matriz[8] = aux;
                pictureBox6.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[5]) + ".png");
                pictureBox9.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[8]) + ".png");
            }
            if (matriz[0] == 1 && matriz[1] == 2 && matriz[2] == 3 && matriz[3] == 4 && matriz[4] == 5 && matriz[5] == 6 && matriz[6] == 7 && matriz[7] == 8 && matriz[8] == 9)
            {
                MessageBox.Show("Ganaste");
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int aux;
            if (matriz[3] == 9)
            {
                aux = matriz[6];
                matriz[6] = matriz[3];
                matriz[3] = aux;
                pictureBox7.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[6]) + ".png");
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[3]) + ".png");
            }
            else if (matriz[7] == 9)
            {
                aux = matriz[6];
                matriz[6] = matriz[7];
                matriz[7] = aux;
                pictureBox7.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[6]) + ".png");
                pictureBox8.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[7]) + ".png");
            }
            if (matriz[0] == 1 && matriz[1] == 2 && matriz[2] == 3 && matriz[3] == 4 && matriz[4] == 5 && matriz[5] == 6 && matriz[6] == 7 && matriz[7] == 8 && matriz[8] == 9)
            {
                MessageBox.Show("Ganaste");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            int aux = 0;
            if (matriz[4] == 9)
            {
                aux = matriz[7];
                matriz[7] = matriz[4];
                matriz[4] = aux;
                pictureBox8.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[7]) + ".png");
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[4]) + ".png");
            }
            else if (matriz[6] == 9)
            {
                aux = matriz[7];
                matriz[7] = matriz[6];
                matriz[6] = aux;
                pictureBox8.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[7]) + ".png");
                pictureBox7.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[6]) + ".png");
            }
            else if (matriz[8] == 9)
            {
                aux = matriz[7];
                matriz[7] = matriz[8];
                matriz[8] = aux;
                pictureBox8.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[7]) + ".png");
                pictureBox9.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[8]) + ".png");
            }
            if (matriz[0] == 1 && matriz[1] == 2 && matriz[2] == 3 && matriz[3] == 4 && matriz[4] == 5 && matriz[5] == 6 && matriz[6] == 7 && matriz[7] == 8 && matriz[8] == 9)
            {
                Felicidades mostrar = new Felicidades();
                mostrar.ShowDialog();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int aux;
            if (matriz[7] == 9)
            {
                aux = matriz[8];
                matriz[8] = matriz[7];
                matriz[7] = aux;
                pictureBox9.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[8]) + ".png");
                pictureBox8.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[7]) + ".png");
            }
            else if (matriz[5] == 9)
            {
                aux = matriz[8];
                matriz[8] = matriz[5];
                matriz[5] = aux;
                pictureBox9.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[8]) + ".png");
                pictureBox6.Image = Image.FromFile(Application.StartupPath + "/imagenes" + Convert.ToString(img) + "/" + Convert.ToString(matriz[5]) + ".png");
            }
            if (matriz[0] == 1 && matriz[1] == 2 && matriz[2] == 3 && matriz[3] == 4 && matriz[4] == 5 && matriz[5] == 6 && matriz[6] == 7 && matriz[7] == 8 && matriz[8] == 9)
            {
                Felicidades mostrar = new Felicidades();
                mostrar.ShowDialog();
            }
        }
    }
}
