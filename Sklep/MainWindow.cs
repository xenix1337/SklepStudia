using Sklep.Database;
using Sklep.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Media;
using System.IO;
using System.Drawing;

namespace Sklep
{
    public partial class MainWindow : Form
    {
        List<ReceiptPosition> receiptPositionList = new List<ReceiptPosition>();
        SoundPlayer cashRegisterBeep = new SoundPlayer(AudioResources.Cash_register_beep);
        
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
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            Program.barcodeScanner = new BarcodeScanner();
            Program.barcodeScanner.pictureBoxes.Push(pictureBox1);
            Program.barcodeScanner.CodeScanned += BarcodeScanner_CodeScanned;
            Program.barcodeScanner.startScanning();
            statusStripLabel.Text = "Gotowy";
        }

        private void BarcodeScanner_CodeScanned(object sender, string code)
        {
            barCodeTextBox.Invoke(new MethodInvoker(delegate ()
            {
                barCodeTextBox.Text = code;
            }));
            cashRegisterBeep.Play();
            addProductToList(code);

        }
        private void addProductToList(string scannedBarcode)
        {
            if (scannedBarcode == "") return;

            using (var context = new DatabaseContext())
            {
                var query = context.Products.SingleOrDefault(p => p.Barcode == scannedBarcode);

                if (query == null) return;

                listOfProducts.Invoke(new MethodInvoker(delegate
                {
                    var position = receiptPositionList.Find(p => p.barcode == scannedBarcode);

                    if (position != null)
                    {
                        position.Amount++;
                    }
                    else
                    {
                        receiptPositionList.Add(new ReceiptPosition()
                        {
                            id = receiptPositionList.Count,
                            barcode = query.Barcode,
                            ProductLongName = query.LongName,
                            PricePerUnit = Convert.ToDecimal(query.Price),
                            Amount = 1,
                            Size = new Size(440, 24),
                        });
                        receiptPositionList.Last().RemoveButtonClick += ReceiptPosition_RemoveButtonClick;
                        listOfProducts.Controls.Add(receiptPositionList.Last());
                    }
                }));
            }
        }

        private void ReceiptPosition_RemoveButtonClick(object sender, int parentId)
        {
            listOfProducts.Controls.Remove(receiptPositionList[parentId]);
            receiptPositionList.Remove(receiptPositionList[parentId]);
            for (int i = parentId; i < receiptPositionList.Count; i++)
            {
                receiptPositionList[i].id = i;
            }
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.barcodeScanner.stopScanning();
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            addProductToList(barCodeTextBox.Text);
        }
        private void listaProduktówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new ListProductsWindow();
            w.ShowDialog();
        }

        private void AddProductButton_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addProductToList(barCodeTextBox.Text);
            }
        }
    }
}
