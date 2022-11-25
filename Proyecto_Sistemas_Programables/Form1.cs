﻿using System;
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

        int m, mx, my;

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
                Console.WriteLine("Conexion Exitosa");
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

            serialPort1.Write("n");
        }

        private void PicBoxVentanaAbierta_Click(object sender, EventArgs e)
        {
            PicBoxVentanaAbierta.Visible = false;
            PicBoxVentanaCerrada.Visible = true;

            serialPort1.Write("o");
        }

        private void PicBoxPuertaAbierta_Click(object sender, EventArgs e)
        {
            PicBoxPuertaAbierta.Visible = false;
            PicBoxPuertaCerrada.Visible = true;
            trcBrPuerta.Value = 0;
            serialPort1.Write("m");
        }

        private void PicBoxPuertaCerrada_Click(object sender, EventArgs e)
        {
            PicBoxPuertaAbierta.Visible = true;
            PicBoxPuertaCerrada.Visible = false;
            trcBrPuerta.Value = trcBrPuerta.Maximum;

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
            trcBrAmarillo.Value = trcBrAmarillo.Maximum;
            serialPort1.Write("p");
        }

        private void PicBoxEncendidoAmarillo_Click(object sender, EventArgs e)
        {
            PicBoxFocoApagadoAmarillo.Visible = true;
            PicBoxEncendidoAmarillo.Visible = false;
            trcBrAmarillo.Value = 0;
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

        private void btnAbrirConexion_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
            }
            else
            {
                MessageBox.Show($"El puerto {cboPorts.Text} ya se encuentra abierto");
            }
        }

        private void btnCerrarConexion_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            else
            {
                MessageBox.Show($"El puerto {cboPorts.Text} ya se encuentra cerrado");
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
            serialPort1.Write("k");
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            serialPort1.Write("11");
        }

        private void btnSoilDetection_Click(object sender, EventArgs e)
        {
            serialPort1.Write("h");
        }

        private void btnCumpleaños_Click(object sender, EventArgs e)
        {
            PicBoxAlarmaOFF.Visible = false;
            PicBoxAlarmaOn.Visible = true;
            serialPort1.Write("e");
        }

        private void btnAlerta_Click(object sender, EventArgs e)
        {
            PicBoxAlarmaOFF.Visible = true;
            PicBoxAlarmaOn.Visible = false;

            serialPort1.Write("g");
        }
        
        private void btnBienvenido_Click(object sender, EventArgs e)
        {
            PicBoxAlarmaOFF.Visible = false;
            PicBoxAlarmaOn.Visible = true;
            serialPort1.Write("f");
        }

        private void PicBoxAlarmaOFF_Click(object sender, EventArgs e)
        {
            PicBoxAlarmaOFF.Visible = false;
            PicBoxAlarmaOn.Visible = true;
            serialPort1.Write("3");
        }

        private void PicBoxAlarmaOn_Click(object sender, EventArgs e)
        {
            PicBoxAlarmaOFF.Visible = true;
            PicBoxAlarmaOn.Visible = false;
            serialPort1.Write("g");
        }

        private void PicBoxReleOff_Click(object sender, EventArgs e)
        {
            PicBoxReleOff.Visible = false;
            PicBoxReleOn.Visible = true;

            serialPort1.Write("c");

        }

        private void PicBoxReleOn_Click(object sender, EventArgs e)
        {
            PicBoxReleOff.Visible = true;
            PicBoxReleOn.Visible = false;

            serialPort1.Write("d");
        }

        private void PicBoxVentiladorOnPWM_Click(object sender, EventArgs e)
        {
            PicBoxVentiladorOnPWM.Visible = false;
            PicBoxVentiladorOffPWM.Visible = true;
            trcBarVentilador.Value = 0;
            PicBoxVentiladorOn.Visible = false;
            PicBoxVentiladorOff.Visible = true;
            serialPort1.Write("s");
        }

        private void PicBoxVentiladorOffPWM_Click(object sender, EventArgs e)
        {
            PicBoxVentiladorOnPWM.Visible = true;
            PicBoxVentiladorOffPWM.Visible = false;
            trcBarVentilador.Value = trcBarVentilador.Maximum;
            PicBoxVentiladorOn.Visible = true;
            PicBoxVentiladorOff.Visible = false;
            serialPort1.Write("r");
        }

        private void btnContrasena_Click(object sender, EventArgs e)
        {
            serialPort1.Write("5");
        }

        private void trcBrAmarillo_Scroll(object sender, EventArgs e)
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

        private void trcBarVentilador_Scroll(object sender, EventArgs e)
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

        private void trcBrPuerta_Scroll(object sender, EventArgs e)
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
