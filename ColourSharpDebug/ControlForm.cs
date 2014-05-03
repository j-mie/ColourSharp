using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColourSharpDebug
{
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private void redSlider_Scroll(object sender, EventArgs e)
        {
            rLabel.Text = redSlider.Value.ToString();
        }

        private void greenSlider_Scroll(object sender, EventArgs e)
        {
            gLabel.Text = greenSlider.Value.ToString();
        }

        private void blueSlider_Scroll(object sender, EventArgs e)
        {
            bLabel.Text = blueSlider.Value.ToString();
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                COMPorts.Items.Add(port);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("R");
            serialPort.Write(new[] { (byte)redSlider.Value }, 0, 1);
            serialPort.Write("G");
            serialPort.Write(new[] { (byte)greenSlider.Value }, 0, 1);
            serialPort.Write("B");
            serialPort.Write(new[] { (byte)blueSlider.Value }, 0, 1);
        }

        private void COMDisconnect_Click(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void COMPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort.PortName = COMPorts.Text;
            COMConnect.Enabled = true;
            COMDisconnect.Enabled = true;
        }

        private void COMConnect_Click(object sender, EventArgs e)
        {
            serialPort.Open();
            sendButton.Enabled = true;
        }
    }
}
