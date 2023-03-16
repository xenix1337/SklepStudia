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

            // TODO: Remove this sample code as it's just for tests
            DatabaseConnection db = new DatabaseConnection();
            db.Connect(DatabaseConnectionSettings.FromEnv());
            barcodeScanner.pictureBox = pictureBox1;
            barcodeScanner.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            barcodeScanner.CodeScanned += BarcodeScanner_CodeScanned;
            barcodeScanner.startScanning();

        }

        private void BarcodeScanner_CodeScanned(object sender, string code)
        {
            EANValidator validator = new EANValidator();
            if (validator.validateBarcode(code))
            {
                barCodeTextBox.Invoke(new MethodInvoker(delegate ()
                {
                    barCodeTextBox.Text = code;
                }));
            }
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(barCodeTextBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            barcodeScanner.stopScanning();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
