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

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPuertos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CargarPuertos()
        {
            try
            {
                Dispositivos_COM = new Dictionary<string, string>();
                cboPorts.Items.Clear();

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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var decripcion = Dispositivos_COM[$"{cboPorts.Text}"];
                lblPortDesc.Text = decripcion.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                Console.WriteLine("Conexion Exitosa");
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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

                        lblLevel.Text = aaa[0].Replace('@', ' ');

                        if (lblLevel.Text.Substring(1, 1) == "0")
                            PIRComponent(false);
                        else
                            PIRComponent(true);

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
                icnPctPIR.IconColor = Color.FromArgb(192, 192, 255);
        }


        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        //Apagar
        private void PicBoxVentiladorOn_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxVentiladorOn.Visible = false;
                PicBoxVentiladorOff.Visible = true;
                serialPort1.Write("s");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Prender
        private void PicBoxVentiladorOff_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxVentiladorOn.Visible = true;
                PicBoxVentiladorOff.Visible = false;
                serialPort1.Write("r");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxVentanaCerrada_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxVentanaAbierta.Visible = true;
                PicBoxVentanaCerrada.Visible = false;
                serialPort1.Write("n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxVentanaAbierta_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxVentanaAbierta.Visible = false;
                PicBoxVentanaCerrada.Visible = true;
                serialPort1.Write("o");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxPuertaAbierta_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxPuertaAbierta.Visible = false;
                PicBoxPuertaCerrada.Visible = true;
                trcBrPuerta.Value = 0;
                serialPort1.Write("m");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxPuertaCerrada_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxPuertaAbierta.Visible = true;
                PicBoxPuertaCerrada.Visible = false;
                trcBrPuerta.Value = trcBrPuerta.Maximum;
                serialPort1.Write("l");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxLedEncendido_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxFocoApagado.Visible = true;
                PicBoxLedEncendido.Visible = false;
                serialPort1.Write("b");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxFocoApagado_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxFocoApagado.Visible = false;
                PicBoxLedEncendido.Visible = true;
                serialPort1.Write("a");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxFocoApagadoAmarillo_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxFocoApagadoAmarillo.Visible = false;
                PicBoxEncendidoAmarillo.Visible = true;
                trcBrAmarillo.Value = trcBrAmarillo.Maximum;
                serialPort1.Write("p");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxEncendidoAmarillo_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxFocoApagadoAmarillo.Visible = true;
                PicBoxEncendidoAmarillo.Visible = false;
                trcBrAmarillo.Value = 0;
                serialPort1.Write("q");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxVentiladorOff_Click(sender, e);
                serialPort1.Write("r");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnIzqVent_Click_1(object sender, EventArgs e)
        {
            try
            {
                PicBoxVentiladorOn.Visible = true;
                PicBoxVentiladorOff.Visible = false;
                serialPort1.Write("z");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxVentiladorOn_Click(sender, e);
                serialPort1.Write("s");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAbrirConexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPorts.Text=="")
                {
                    MessageBox.Show("Porfavor seleccione un puerto");
                }

                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = cboPorts.Text;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();
                    MessageBox.Show("Conexion exitosa!", "Atencion", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"El puerto {cboPorts.Text} ya se encuentra abierto");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCerrarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
                else
                    MessageBox.Show($"El puerto {cboPorts.Text} ya se encuentra cerrado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxBarra_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void btnGasDetection_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("k");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("11");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSoilDetection_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("h");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnCumpleaños_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxAlarmaOFF.Visible = false;
                PicBoxAlarmaOn.Visible = true;
                serialPort1.Write("e");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnAlerta_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxAlarmaOFF.Visible = true;
                PicBoxAlarmaOn.Visible = false;
                serialPort1.Write("g");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private void btnBienvenido_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxAlarmaOFF.Visible = false;
                PicBoxAlarmaOn.Visible = true;
                serialPort1.Write("f");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxAlarmaOFF_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxAlarmaOFF.Visible = false;
                PicBoxAlarmaOn.Visible = true;
                serialPort1.Write("3");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxAlarmaOn_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxAlarmaOFF.Visible = true;
                PicBoxAlarmaOn.Visible = false;
                serialPort1.Write("g");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxReleOff_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxReleOff.Visible = false;
                PicBoxReleOn.Visible = true;
                serialPort1.Write("c");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxReleOn_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxReleOff.Visible = true;
                PicBoxReleOn.Visible = false;
                serialPort1.Write("d");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxVentiladorOnPWM_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxVentiladorOnPWM.Visible = false;
                PicBoxVentiladorOffPWM.Visible = true;
                trcBarVentilador.Value = 0;
                PicBoxVentiladorOn.Visible = false;
                PicBoxVentiladorOff.Visible = true;
                serialPort1.Write("s");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void PicBoxVentiladorOffPWM_Click(object sender, EventArgs e)
        {
            try
            {
                PicBoxVentiladorOnPWM.Visible = true;
                PicBoxVentiladorOffPWM.Visible = false;
                trcBarVentilador.Value = trcBarVentilador.Maximum;
                PicBoxVentiladorOn.Visible = true;
                PicBoxVentiladorOff.Visible = false;
                serialPort1.Write("r");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        private void btnContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("5");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void trcBrAmarillo_Scroll(object sender, EventArgs e)
        {
            try
            {
                if (trcBrAmarillo.Value <= 0)
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
                serialPort1.Write($"{trcBrAmarillo.Value * ((int)(255 / 10))}#");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void trcBarVentilador_Scroll(object sender, EventArgs e)
        {
            try
            {
                if (trcBarVentilador.Value <= 0)
                {
                    PicBoxVentiladorOffPWM.Visible = true;
                    PicBoxVentiladorOnPWM.Visible = false;
                    PicBoxVentiladorOn.Visible = false;
                    PicBoxVentiladorOff.Visible = true;
                }
                else
                {
                    PicBoxVentiladorOffPWM.Visible = false;
                    PicBoxVentiladorOnPWM.Visible = true;
                    PicBoxVentiladorOn.Visible = true;
                    PicBoxVentiladorOff.Visible = false;

                }

                serialPort1.Write("w");
                Console.WriteLine(trcBarVentilador.Value * ((int)(255 / 10)));
                serialPort1.Write($"{trcBarVentilador.Value * ((int)(255 / 10))}#");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void trcBrPuerta_Scroll(object sender, EventArgs e)
        {
            try
            {
                if (trcBarVentilador.Value <= 0)
                {
                    PicBoxPuertaAbierta.Visible = true;
                    PicBoxPuertaCerrada.Visible = false;
                }
                else
                {
                    PicBoxPuertaAbierta.Visible = false;
                    PicBoxPuertaCerrada.Visible = true;
                }

                serialPort1.Write("t");
                Console.WriteLine(trcBrPuerta.Value * ((int)(180 / 10)));
                serialPort1.Write($"{trcBrPuerta.Value * ((int)(180 / 10))}#");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cboPorts_Enter(object sender, EventArgs e)
        {
            CargarPuertos();
        }

        private void PicBoxBarra_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void PicBoxBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
    }
}
