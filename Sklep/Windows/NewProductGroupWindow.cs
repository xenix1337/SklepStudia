using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Sklep.Database;
using Sklep.Database.Models;
using Sklep.Utils;

namespace Sklep
{
    public partial class NewProductGroupWindow : Form
    {
        private static readonly Color defaultBackgroundColor = SystemColors.Window;
        private static readonly Color invalidBackgroundColor = Color.FromArgb(255, 66, 66);
        private bool[] validField = new bool[2];

        public NewProductGroupWindow()
        {
            InitializeComponent();
        }

        private void NewProductWindow_Load(object sender, EventArgs e)
        {
            ValidateGroupBarcode();
            ValidateProductBarcode();

            scannerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Program.barcodeScanner.pictureBoxes.Push(scannerPictureBox);
            Program.barcodeScanner.CodeScanned += BarcodeScanner_CodeScanned;
        }

        private void BarcodeScanner_CodeScanned(object sender, string code)
        {
            kodKreskowyGrupyTextBox.Invoke(() =>
            {
                if (kodKreskowyGrupyTextBox.Text == "")
                    kodKreskowyGrupyTextBox.Text = code;
                else
                    kodKreskowyProduktuTextBox.Text = code;
            });
        }

        private void addProductGroupButton_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                ProductGroup newProductGroup = new ProductGroup
                {
                    GroupBarcode = kodKreskowyGrupyTextBox.Text,
                    Product = db.Products.Single(p => p.Barcode == kodKreskowyProduktuTextBox.Text),
                    Amount = (int)iloscNumericUpDown.Value
                };

                if (newProductGroup.Product == null)
                {
                    MessageBox.Show(
                        "Nie znaleziono produktu o podanym kodzie kreskowym",
                        "Błąd",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                db.ProductGroups.Add(newProductGroup);
                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ValidateGroupBarcode()
        {
            bool valid = true;
            if (!EANValidator.validateBarcode(kodKreskowyGrupyTextBox.Text))
                valid = false;

            kodKreskowyGrupyTextBox.BackColor = valid
                ? defaultBackgroundColor
                : invalidBackgroundColor;
            validField[0] = valid;
            UpdateButtonEnabled();
        }

        private void ValidateProductBarcode()
        {
            bool valid = true;
            if (!EANValidator.validateBarcode(kodKreskowyProduktuTextBox.Text))
                valid = false;

            kodKreskowyProduktuTextBox.BackColor = valid
                ? defaultBackgroundColor
                : invalidBackgroundColor;
            validField[1] = valid;
            UpdateButtonEnabled();
        }

        private void kodKreskowyGrupyTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateGroupBarcode();
        }

        private void kodKreskowyProduktuTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateProductBarcode();
        }

        void UpdateButtonEnabled()
        {
            if (validField.All(x => x))
            {
                addProductGroupButton.Enabled = true;
            }
            else
            {
                addProductGroupButton.Enabled = false;
            }
        }

        private void NewProductWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.barcodeScanner.CodeScanned -= BarcodeScanner_CodeScanned;
            Program.barcodeScanner.pictureBoxes.Pop();
        }
    }
}
