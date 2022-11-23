using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management;
using System.Text;
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
    }
}
