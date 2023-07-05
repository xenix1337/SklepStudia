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
using ZXing.QrCode.Internal;
using System.Diagnostics;

namespace Sklep
{
    public partial class MainWindow : Form
    {
        private Dictionary<string, ReceiptPositionControl> receiptPositionList =
            new Dictionary<string, ReceiptPositionControl>();
        public Dictionary<string, decimal> cartList = new Dictionary<string, decimal>();
        SoundPlayer cashRegisterBeep = new SoundPlayer(AudioResources.Cash_register_beep);
        SoundPlayer errorSound = new SoundPlayer(AudioResources.error_sound_effect);
        public decimal sum = 0;
        bool checkedIfAdult = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void zarejestrujNowyProduktToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new NewProductWindow();
            DialogResult result = w.ShowDialog();
            if (result == DialogResult.OK)
                statusStripLabel.Text = "Zarejestrowano nowy produkt w bazie";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            SettingsManager.Load();

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
                if (!CanFocus) return;

                barCodeTextBox.Text = code;
                addProductToList(code);
            }));
        }

        public void updateSum()
        {
            sum = 0;
            foreach (var element in receiptPositionList.Values)
            {
                sum += element.priceDecimal;
            }
            sumOfProductPricesLabel.Text = sum.ToString("0.00") + " PLN";
        }

        private void addProductToList(string scannedBarcode)
        {
            if (scannedBarcode == "")
                return;

            dynamic productObject = ServerCommunication.ScanProduct(scannedBarcode);

            if (productObject["result"] != "OK")
            {
                errorSound.Play();
                statusStripLabel.Text = "Nieznany produkt!";
                return;
            }

            Product product = new Product();
            product.ShortName = productObject["data"]["ShortName"];
            product.LongName = productObject["data"]["LongName"];
            product.Barcode = productObject["data"]["Barcode"];
            product.Price = productObject["data"]["Price"];
            bool adultOnly = productObject["data"]["AdultOnly"];
            decimal amount = productObject["data"]["Amount"];
            if (adultOnly == true && !checkedIfAdult)
            {
                var customerAdult = MessageBox.Show(
                    "Czy klient ukończył 18 rok życia?",
                    "Produkt tylko dla pełnoletnich!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                Program.barcodeScanner.lastScanTime = DateTime.Now;
                if (customerAdult == DialogResult.Yes)
                    checkedIfAdult = true;
                else
                {
                    MessageBox.Show(
                        "Odmowa sprzedaży, odłóż towar",
                        "Odmowa sprzedaży",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
            }

            ReceiptPositionControl position;
            if (receiptPositionList.TryGetValue(product.Barcode, out position))
            {
                position.Invoke(
                    new MethodInvoker(
                        delegate
                        {
                            cashRegisterBeep.Play();
                            position.Amount += amount;
                            updateSum();
                        }
                    )
                );
                cartList[product.Barcode] += 1;
                return;
            }

            listOfProducts.Invoke(
                new MethodInvoker(
                    delegate
                    {
                        cashRegisterBeep.Play();
                        var recepitPosition = new ReceiptPositionControl(product);
                        recepitPosition.Amount = amount;
                        recepitPosition.RemoveButtonClick += ReceiptPosition_RemoveButtonClick;
                        recepitPosition.NumericUpDownValueChanged += ReceiptPosition_NumericUpDownValueChanged;
                        receiptPositionList.Add(product.Barcode, recepitPosition);
                        listOfProducts.Controls.Add(recepitPosition);
                        updateSum();
                    }
                )
            );
            cartList.Add(product.Barcode, 1);
        }

        public void clearCart()
        {
            listOfProducts.Controls.Clear();
            receiptPositionList.Clear();
            cartList.Clear();
            updateSum();
            checkedIfAdult = false;
        }

        private void ReceiptPosition_NumericUpDownValueChanged(object sender, EventArgs e)
        {
            updateSum();
        }
        private void ReceiptPosition_RemoveButtonClick(object sender, string barcode)
        {
            listOfProducts.Controls.Remove(receiptPositionList[barcode]);
            receiptPositionList.Remove(barcode);
            cartList.Remove(barcode);
            checkedIfAdult = false;
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

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new SettingsWindow();
            w.ShowDialog();
        }

        private void AddProductButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addProductToList(barCodeTextBox.Text);
            }
        }

        private void finalizationButton_Click(object sender, EventArgs e)
        {
            if (receiptPositionList.Count == 0)
            {
                return;
            }
            var w = new FinalizationDialogForm(this);
            w.ShowDialog();
            if (w.DialogResult == DialogResult.Cancel) return;
            dynamic finalizationResponse = ServerCommunication.FinalizeCart(cartList);
            if (finalizationResponse.result == "OK")
            {
                MessageBox.Show(
                    ReceiptPrinter.PrintReceipt(cartList, (string)finalizationResponse.receiptId),
                    "Paragon"
                );
                clearCart();
            }
            else
            {
                MessageBox.Show("W trakcie finalizacji zakupów wystąpił błąd!");
            }
        }

        private void stanMagazynuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new ListInventoryWindow();
            w.ShowDialog();
        }

        private void historiaZmianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new ListOfChangesWindow();
            w.ShowDialog();
        }

        private void changeStateToolStipMenuItem_Click(object sender, EventArgs e)
        {
            var w = new InventoryChangeWindow();
            w.ShowDialog();
        }

        private void listaKategoriiProduktówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new ListProductCategoriesWindow();
            w.ShowDialog();
        }
    }
}
