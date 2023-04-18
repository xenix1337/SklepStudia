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

namespace Sklep
{
    public partial class MainWindow : Form
    {
        List<ReceiptPosition> receiptPositionList = new List<ReceiptPosition>();
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
            foreach (var element in receiptPositionList)
            {
                sum += element.priceDecimal;
            }
            sumOfProductPricesLabel.Text = sum.ToString() + " PLN";
        }
        private void addProductToList(string scannedBarcode)
        {
            if (scannedBarcode == "") return;

            var position = receiptPositionList.Find(p => p.barcode == scannedBarcode);
            if (position != null)
            {
                position.Invoke(new MethodInvoker(delegate
                {
                    cashRegisterBeep.Play();
                    position.Amount++;
                    updateSum();
                }));
                return;
            }

            using (var context = new DatabaseContext())
            {
                var product = context.Products.SingleOrDefault(p => p.Barcode == scannedBarcode) ?? 
                              context.ProductGroups.SingleOrDefault(p => p.GroupBarcode == scannedBarcode).Product;

                if (product == null)
                {
                    errorSound.Play();
                    statusStripLabel.Text = "Nieznany produkt!";
                    return;
                }

                listOfProducts.Invoke(new MethodInvoker(delegate
                {
                    cashRegisterBeep.Play();
                    receiptPositionList.Add(new ReceiptPosition(product));
                    receiptPositionList.Last().id = receiptPositionList.Count - 1;
                    receiptPositionList.Last().RemoveButtonClick += ReceiptPosition_RemoveButtonClick;
                    listOfProducts.Controls.Add(receiptPositionList.Last());
                    updateSum();
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
