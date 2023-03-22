using Sklep.Utils;
using System;
using System.Windows.Forms;

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

        private void listaProduktówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new ListProductsWindow();
            w.ShowDialog();
        }
    }
}
