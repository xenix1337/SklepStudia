using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Sklep.Database;
using Sklep.Database.Models;
using Sklep.Utils;

namespace Sklep
{
    public partial class NewProductWindow : Form
    {
        private static readonly Color defaultBackgroundColor = SystemColors.Window;
        private static readonly Color invalidBackgroundColor = Color.FromArgb(255, 66, 66);
        private bool[] validField = new bool[4];

        public NewProductWindow()
        {
            InitializeComponent();
        }

        private void NewProductWindow_Load(object sender, EventArgs e)
        {
            LoadSuppliersList();
            LoadCategoriesList();
            ValidateBarcode();
            ValidateShortName();
            ValidateLongName();
            ValidatePrice();

            scannerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Program.barcodeScanner.pictureBoxes.Push(scannerPictureBox);
            Program.barcodeScanner.CodeScanned += BarcodeScanner_CodeScanned;
        }

        private void BarcodeScanner_CodeScanned(object sender, string code)
        {
            kodKreskowyTextBox.Invoke(() =>
            {
                kodKreskowyTextBox.Text = code;
            });
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {

            InventoryPosition newPosition = new InventoryPosition
            {
                Amount = AmountNumericUpDown.Value,
                Rack = (int)rackNumericUpDown.Value,
                Shelf = (int)shelfNumericUpDown.Value,
            };
            InventoryChange newInventoryChange = new InventoryChange
            {
                Position = newPosition,
                Amount = AmountNumericUpDown.Value,
                Date = DateTime.Now.ToUniversalTime(),
                Type = "Dostawa"
            };
            Product newProduct = new Product
            {
                Position = newPosition,
                Barcode = kodKreskowyTextBox.Text,
                ShortName = nazwaKrotkaTextBox.Text,
                LongName = nazwaDlugaTextBox.Text,
                Price = double.Parse(cenaTextBox.Text),
                CategoryId = (kategoriaComboBox.SelectedItem as ProductCategory)?.Id
            };


            using (var db = new DatabaseContext())
            {
                db.InventoryPositions.Add(newPosition);
                db.InventoryChanges.Add(newInventoryChange);
                db.Products.Add(newProduct);
                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void LoadSuppliersList()
        {
            //TODO: Wczytaj dostawców
        }

        private void LoadCategoriesList()
        {
            kategoriaComboBox.Items.Clear();
            kategoriaComboBox.Items.Add("");
            kategoriaComboBox.SelectedIndex = 0;

            using (var db = new DatabaseContext())
            {
                foreach (var category in db.Categories)
                {
                    kategoriaComboBox.Items.Add(category);
                }
            }
        }

        private void ValidateBarcode()
        {
            bool valid = true;
            if (!EANValidator.validateBarcode(kodKreskowyTextBox.Text))
                valid = false;

            kodKreskowyTextBox.BackColor = valid ? defaultBackgroundColor : invalidBackgroundColor;
            validField[0] = valid;
            UpdateButtonEnabled();
        }

        private void kodKreskowyTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateBarcode();
        }

        private void ValidateShortName()
        {
            bool valid = true;
            if (nazwaKrotkaTextBox.Text.Length <= 0)
                valid = false;

            nazwaKrotkaTextBox.BackColor = valid ? defaultBackgroundColor : invalidBackgroundColor;
            validField[1] = valid;
            UpdateButtonEnabled();
        }

        private void nazwaKrotkaTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateShortName();
        }

        private void ValidateLongName()
        {
            bool valid = true;
            if (nazwaDlugaTextBox.Text.Length <= 0)
                valid = false;

            nazwaDlugaTextBox.BackColor = valid ? defaultBackgroundColor : invalidBackgroundColor;
            validField[2] = valid;
            UpdateButtonEnabled();
        }

        private void nazwaDlugaTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateLongName();
        }

        private void ValidatePrice()
        {
            bool valid = true;
            double price = 0;
            if (!double.TryParse(cenaTextBox.Text, out price))
                valid = false;
            if (price < 0)
                valid = false;
            if (Math.Abs(Math.Round(price * 100) - price * 100) > double.Epsilon * 10)
                valid = false;

            cenaTextBox.BackColor = valid ? defaultBackgroundColor : invalidBackgroundColor;
            validField[3] = valid;
            UpdateButtonEnabled();
        }

        private void cenaTextBox_TextChanged(object sender, EventArgs e)
        {
            int i = cenaTextBox.SelectionStart;
            cenaTextBox.Text = cenaTextBox.Text.Replace('.', ',');
            cenaTextBox.Select(i, 0);
            ValidatePrice();
        }

        void UpdateButtonEnabled()
        {
            if (validField[0] && validField[1] && validField[2] && validField[3])
            {
                addProductButton.Enabled = true;
            }
            else
            {
                addProductButton.Enabled = false;
            }
        }

        private void NewProductWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.barcodeScanner.CodeScanned -= BarcodeScanner_CodeScanned;
            Program.barcodeScanner.pictureBoxes.Pop();
        }
    }
}
