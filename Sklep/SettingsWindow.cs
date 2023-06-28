using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            Settings s = SettingsManager.current;
            naglowekTextBox.Text = s.receiptHeader;
            stopkaTextBox.Text = s.receiptFooter;
            ipTextBox.Text = s.serverIP;
            portTextBox.Text = s.serverPort.ToString();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            Settings s = SettingsManager.current;
            s.receiptHeader = naglowekTextBox.Text;
            s.receiptFooter = stopkaTextBox.Text;
            s.serverIP = ipTextBox.Text;
            s.serverPort = int.Parse(portTextBox.Text);

            SettingsManager.Save();
            Close();
        }
    }
}
