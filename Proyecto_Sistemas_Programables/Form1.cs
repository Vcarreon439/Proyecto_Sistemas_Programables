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
        string stateString="";

        bool vent = false;


        public frmPrincipal()
        {
            InitializeComponent();
        }

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
                serialPort1.PortName = cboPorts.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.Open();
                serialPort1.Write("x");
                serialPort1.Write("1");
                Console.WriteLine(serialPort1.ReadTo("#"));
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine(stateString);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string cadena = serialPort1.ReadTo("\n");
                string[] aaa = cadena.Split(' ');

                if (aaa.Count()<3)
                {

                }
                else
                {
                    Invoke(new MethodInvoker(() => {

                        //PIRComponent(bool.Parse(aaa[0].Remove(0)));

                        lblLevel.Text = aaa[0].Replace('@', ' ');
                        lblSensFoto.Text = aaa[1];
                        lblSenseSoil.Text = aaa[2];
                        lblSenseRain.Text = aaa[3];
                        lblSenseGas.Text = aaa[4];
                    }));

                    Thread.Sleep(500);
                }
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Flujo alterno");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PIRComponent(bool val)
        {
            if (val)
                icnPctPIR.IconColor = Color.Red;
            else
                icnPctPIR.IconColor = Color.Black;
        }


        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        //Apagar
        private void PicBoxVentiladorOn_Click(object sender, EventArgs e)
        {
            PicBoxVentiladorOn.Visible = false;
            PicBoxVentiladorOff.Visible = true;

            serialPort1.Write("s");
        }

        //Prender
        private void PicBoxVentiladorOff_Click(object sender, EventArgs e)
        {
            PicBoxVentiladorOn.Visible = true;
            PicBoxVentiladorOff.Visible = false;
            serialPort1.Write("r");
            vent = true;
        }

        private void PicBoxVentanaCerrada_Click(object sender, EventArgs e)
        {
            PicBoxVentanaAbierta.Visible = true;
            PicBoxVentanaCerrada.Visible = false;
        }

        private void PicBoxVentanaAbierta_Click(object sender, EventArgs e)
        {
            PicBoxVentanaAbierta.Visible = false;
            PicBoxVentanaCerrada.Visible = true;
        }

        private void PicBoxPuertaAbierta_Click(object sender, EventArgs e)
        {
            PicBoxPuertaAbierta.Visible = false;
            PicBoxPuertaCerrada.Visible = true;
            serialPort1.Write("m");
        }

        private void PicBoxPuertaCerrada_Click(object sender, EventArgs e)
        {
            PicBoxPuertaAbierta.Visible = true;
            PicBoxPuertaCerrada.Visible = false;
            serialPort1.Write("l");
        }

        private void PicBoxLedEncendido_Click(object sender, EventArgs e)
        {
            PicBoxFocoApagado.Visible = true;
            PicBoxLedEncendido.Visible = false;

            serialPort1.Write("b");
        }

        private void PicBoxFocoApagado_Click(object sender, EventArgs e)
        {
            PicBoxFocoApagado.Visible = false;
            PicBoxLedEncendido.Visible = true;

            serialPort1.Write("a");
        }

        private void PicBoxFocoApagadoAmarillo_Click(object sender, EventArgs e)
        {
            PicBoxFocoApagadoAmarillo.Visible = false;
            PicBoxEncendidoAmarillo.Visible = true;
            serialPort1.Write("p");
        }

        private void PicBoxEncendidoAmarillo_Click(object sender, EventArgs e)
        {
            PicBoxFocoApagadoAmarillo.Visible = true;
            PicBoxEncendidoAmarillo.Visible = false;
            serialPort1.Write("q");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            vent = true;
            PicBoxVentiladorOff_Click(sender, e);
            serialPort1.Write("r");
        }

        private void btnIzqVent_Click_1(object sender, EventArgs e)
        {
            vent = true;
            PicBoxVentiladorOn.Visible = true;
            PicBoxVentiladorOff.Visible = false;
            serialPort1.Write("z");
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            vent = false;
            PicBoxVentiladorOn_Click(sender, e);
            serialPort1.Write("s");
        }

        private void trcBrBlanco_Scroll(object sender, EventArgs e)
        {
        }

        private void trcBrAmarillo_Scroll(object sender, EventArgs e)
        {
            if (trcBrAmarillo.Value<=0)
            {
                PicBoxFocoApagadoAmarillo.Visible = true;
                PicBoxEncendidoAmarillo.Visible = false;
            }
            else
            {
                PicBoxFocoApagadoAmarillo.Visible = false;
                PicBoxEncendidoAmarillo.Visible = true;
            }

            serialPort1.Write("v");
            Console.WriteLine(trcBrAmarillo.Value * ((int)(255 / 10)));
            serialPort1.Write($"{trcBrAmarillo.Value*((int)(255/10))}#");
        }

        private void btnAbrirConexion_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void btnCerrarConexion_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void cboPorts_Enter(object sender, EventArgs e)
        {

        }
    }
}
