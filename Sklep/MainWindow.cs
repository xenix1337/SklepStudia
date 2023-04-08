using Sklep.Database;
using Sklep.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data;
//using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Media;
using System.IO;

namespace Sklep
{
    public partial class MainWindow : Form
    {
        BarcodeScanner barcodeScanner = new BarcodeScanner();
        private DatabaseContext db;
        List<ReceiptPosition> receiptPositionList = new List<ReceiptPosition>();


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
            db = new DatabaseContext();
            db.Products.Load();
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
            playCashRegisterBeep();
            addProductToList(code);
         
        }
        private void addProductToList(string scannedBarcode)
        {
            if (scannedBarcode != "")
            {
                var query = db.Products.SingleOrDefault(p => p.Barcode == scannedBarcode);
                if (query != null)
                {
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
                                Location = new System.Drawing.Point(4, 4 + receiptPositionList.Count * 32),
                                Size = new System.Drawing.Size(440, 24),
                            });
                            receiptPositionList.Last().RemoveButtonClick += ReceiptPosition_RemoveButtonClick;
                            listOfProducts.Controls.Add(receiptPositionList.Last());
                        }
                    }));
                }
            }
        }

        private void ReceiptPosition_RemoveButtonClick(object sender, int parentId)
        {
            listOfProducts.Controls.Remove(receiptPositionList[parentId]);
            receiptPositionList.Remove(receiptPositionList[parentId]);
            for (int i = parentId; i < receiptPositionList.Count; i++)
            {
                receiptPositionList[i].id = i;
                receiptPositionList[i].Location = new System.Drawing.Point(4, 4 + i * 32);
            }
        }
        private void playCashRegisterBeep()
        {
            SoundPlayer simpleSound = new SoundPlayer(AudioResources.Cash_register_beep);
            simpleSound.Play();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            barcodeScanner.stopScanning();
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


    }
}
