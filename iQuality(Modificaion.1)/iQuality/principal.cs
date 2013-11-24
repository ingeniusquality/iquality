using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace iQuality
{
    public partial class principal : Form
    {
        public int i = 0;
        public principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDiQuality search = new BDiQuality();
            search.crearconexion();
            string search3 = "select * from usuario where user='"+textBox1.Text+"';";
            MySqlCommand buscacliente = new MySqlCommand(search3, search.getConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(buscacliente);
            DataSet tht = new DataSet();
            buscacliente.Connection = search.getConexion();
            cmc.Fill(tht, "usuario");
            dataGridView1.DataSource = tht.Tables["usuario"].DefaultView;
            if (dataGridView1.RowCount >1 && textBox2.Text == Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value))
            {
                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = 30;
                pictureBox3.Visible = true;
                label3.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i % 2 == 0)
                label3.ForeColor = Color.Red;
            if (i % 3 == 0)
                label3.ForeColor = Color.Yellow;
            if (i % 4 == 0)
                label3.ForeColor = Color.Green;
            if (i % 5 == 0)
                label3.ForeColor = Color.Blue;
            label3.Text = Convert.ToString(i) + "%";
            if (i == 101)
            {
                timer1.Stop();
                Menu juegos = new Menu();
                this.Hide();
                juegos.ShowDialog();
                this.Show();
                pictureBox3.Visible = false;
                label3.Visible = false;
                i = 0;
                button1.Enabled = false;
                pictureBox2.Load("bton2.png");
                button1.BackgroundImage = pictureBox2.Image;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                button1.Focus();
            button1.Enabled = true;
            pictureBox2.Load("bton.png");
            button1.BackgroundImage = pictureBox2.Image;
        }

        private void principal_Load(object sender, EventArgs e)
        {
            pictureBox2.Load("bton.png");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Ayuda olvidadizo = new Ayuda();
            this.Hide();
            olvidadizo.ShowDialog();
            this.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro cuenta = new Registro();
            this.Hide();
            cuenta.ShowDialog();
            this.Show();
        }
    }
}
