using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Imaging;
using AForge.Math;
using AForge.Video.DirectShow;
using Sklep.Database;
using Sklep.Utils;
using ZXing;
using AForge.Imaging.Filters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sklep
{
    public partial class MainWindow : Form
    {
        BarcodeScanner barcodeScanner = new BarcodeScanner();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zarejestrujNowyProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new NewProductWindow();
            DialogResult result = w.ShowDialog();
            if (result == DialogResult.OK) statusStripLabel.Text = "Zarejestrowano nowy produkt w bazie";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();
            db.Connect(DatabaseConnectionSettings.FromEnv());
            barcodeScanner.pictureBox = pictureBox1;
            barcodeScanner.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            barcodeScanner.CodeScanned += BarcodeScanner_CodeScanned;
            barcodeScanner.startScanning();
            statusStripLabel.Text = "Gotowy";
        }

        private void BarcodeScanner_CodeScanned(object sender, string code)
        {
            barCodeTextBox.Invoke(new MethodInvoker(delegate ()
            {           
                barCodeTextBox.Text = code;
            }));
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            barcodeScanner.stopScanning();
        }
    }
}
