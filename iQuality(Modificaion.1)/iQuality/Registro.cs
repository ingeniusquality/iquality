using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace iQuality
{
    public partial class Registro : Form
    {
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;

        public Registro()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cbxDispositivos.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivos.Text = cbxDispositivos.Items[0].ToString();

        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }

            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);

            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }

        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            EspacioCamara.Image = Imagen;

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void BtnCamara_Click(object sender, EventArgs e)
        {
            if (BtnCamara.Text == "Iniciar")
            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    BtnCamara.Text = "Detener";
                    cbxDispositivos.Enabled = false;
                }
                else
                    MessageBox.Show("No se encuentra el dispositivo");
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    BtnCamara.Text = "Iniciar";
                    cbxDispositivos.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BDiQuality anadir = new BDiQuality();
            anadir.crearconexion();
            string add = "insert into usuario(user, password, pregunta_clave, respuesta_clave) values("+ "'" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text+ "','" + textBox4.Text +"');";
            MySqlCommand addUser = new MySqlCommand(add);
            addUser.Connection = anadir.getConexion();
            addUser.ExecuteNonQuery();
            anadir.cerrarconexion();
            MessageBox.Show("Se ha registrado correctamente.", "Registro existoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
