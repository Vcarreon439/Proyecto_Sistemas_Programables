using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Sistemas_Programables
{
    public partial class frmPrincipal : Form
    {
        Dictionary<string, string> Dispositivos_COM = new Dictionary<string, string>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        int m, mx, my;

        private void btnIzqVent_Click(object sender, EventArgs e)
        {
           
        }

        

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarPuertos();
        }

        private void CargarPuertos()
        {
            using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
            {
                var portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());
                var portList = portnames.Select(n => ports.FirstOrDefault(s => s.Contains(n))).ToList();

                for (int i = 0; i < portList.Count; i++)
                {
                    Dispositivos_COM.Add($"{portnames[i]}", $"{portList[i]}");
                }
            }

            foreach (string item in SerialPort.GetPortNames())
            {
                cboPorts.Items.Add(item);
            }
        }

        private void cboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var decripcion = Dispositivos_COM[$"{cboPorts.Text}"];
            lblPortDesc.Text = decripcion.ToString();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {

            try
            {
                SerialPort serialPort = new SerialPort();
                serialPort.PortName = cboPorts.Text;
                serialPort.BaudRate = 9600;
                serialPort.Open();

                serialPort.Write("x");

                string a = serialPort.ReadExisting();
                Console.WriteLine(a);
                Thread.Sleep(3000);

                serialPort.Write("p");

                serialPort.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxVentiladorOff_Click(object sender, EventArgs e)
        {
            PicBoxVentiladorOn.Visible = true;
            PicBoxVentiladorOff.Visible = false;
        }

        private void PicBoxVentiladorOn_Click(object sender, EventArgs e)
        {
            PicBoxVentiladorOn.Visible = false;
            PicBoxVentiladorOff.Visible = true;
        }

        private void PicBoxPuertaCerrada_Click(object sender, EventArgs e)
        {
            PicBoxPuertaAbierta.Visible = true;
            PicBoxPuertaCerrada.Visible = false;
        }

        private void PicBoxPuertaAbierta_Click(object sender, EventArgs e)
        {
            PicBoxPuertaAbierta.Visible = false;
            PicBoxPuertaCerrada.Visible = true;
        }

        private void PicBoxVentanaCerrada_Click(object sender, EventArgs e)
        {
            PicBoxVentanaAbierta.Visible = true;
            PicBoxVentanaCerrada.Visible = false;
        }

        private void PicBoxBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void PicBoxBarra_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void PicBoxBarra_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void PicBoxFocoApagado_Click(object sender, EventArgs e)
        {
            PicBoxFocoApagado.Visible = false;
            PicBoxLedEncendido.Visible = true;
        }

        private void PicBoxLedEncendido_Click(object sender, EventArgs e)
        {
            PicBoxFocoApagado.Visible = true;
            PicBoxLedEncendido.Visible = false;
        }

        private void PicBoxFocoApagadoAmarillo_Click(object sender, EventArgs e)
        {
            PicBoxFocoApagadoAmarillo.Visible = false;
            PicBoxEncendidoAmarillo.Visible = true;
        }

        private void PicBoxEncendidoAmarillo_Click(object sender, EventArgs e)
        {
            PicBoxFocoApagadoAmarillo.Visible = true;
            PicBoxEncendidoAmarillo.Visible = false;
        }

        private void PicBoxVentanaAbierta_Click(object sender, EventArgs e)
        {
            PicBoxVentanaAbierta.Visible = false;
            PicBoxVentanaCerrada.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
