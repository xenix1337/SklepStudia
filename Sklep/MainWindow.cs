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
using AForge.Imaging.Filters;
using Sklep.Database.Models;

namespace Sklep
{
    public partial class MainWindow : Form
    {
        Dictionary<string, ReceiptPosition> receiptPositionList = new Dictionary<string, ReceiptPosition>();
        SoundPlayer cashRegisterBeep = new SoundPlayer(AudioResources.Cash_register_beep);
        SoundPlayer errorSound = new SoundPlayer(AudioResources.error_sound_effect);
        
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
            addProductToList(code);

        }
        private void updateSum()
        {
            decimal sum = 0;
            foreach (var element in receiptPositionList.Values)
            {
                sum += element.priceDecimal;
            }
            sumOfProductPricesLabel.Text = sum.ToString() + " PLN";
        }
        private void addProductToList(string scannedBarcode)
        {
            if (scannedBarcode == "") return;

            string productString = ServerCommunication.ScanProduct(scannedBarcode);
            if (productString == "")
            {
                errorSound.Play();
                statusStripLabel.Text = "Nieznany produkt!";
                return;
            }

            var productData = productString.Split('\n');
            Product product = new Product();
            product.ShortName = productData[1];
            product.LongName = productData[2];
            product.Barcode = productData[3];
            product.Price = double.Parse(productData[4]);
            bool adultOnly = bool.Parse(productData[5]);
            decimal amount = decimal.Parse(productData[6]);
            //TODO: if(adultOnly == true && !adultChecked) { warning(); }

            ReceiptPosition position;
            if (receiptPositionList.TryGetValue(product.Barcode, out position))
            {
                position.Invoke(new MethodInvoker(delegate
                {
                    cashRegisterBeep.Play();
                    position.Amount += amount;
                    updateSum();
                }));
                return;
            }

            listOfProducts.Invoke(new MethodInvoker(delegate
            {
                cashRegisterBeep.Play();
                var recepitPosition = new ReceiptPosition(product);
                recepitPosition.Amount = amount;
                recepitPosition.RemoveButtonClick += ReceiptPosition_RemoveButtonClick;
                receiptPositionList.Add(product.Barcode, recepitPosition);
                listOfProducts.Controls.Add(recepitPosition);
                updateSum();
            }));

        }

        private void ReceiptPosition_RemoveButtonClick(object sender, string barcode)
        {
            listOfProducts.Controls.Remove(receiptPositionList[barcode]);
            receiptPositionList.Remove(barcode);
            updateSum();
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

        private void zarejestrujGrupęProduktówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new NewProductGroupWindow();
            w.ShowDialog();
        }

        private void listaGrupProduktówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new ListProductGroupsWindow();
            w.ShowDialog();
        }

        private void AddProductButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addProductToList(barCodeTextBox.Text);
            }
        }
    }
}
