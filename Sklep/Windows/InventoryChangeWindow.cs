using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Sklep.Database;
using Sklep.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep
{
    public partial class InventoryChangeWindow : Form
    {
        private enum ChangeType
        {
            Sprzedaż,
            Dostawa,
            Kradzież,
            Inwentaryzacja
        }

        public InventoryChangeWindow()
        {
            InitializeComponent();
        }

        private void InventoryChangeForm_Load(object sender, EventArgs e)
        {
            scannerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Program.barcodeScanner.pictureBoxes.Push(scannerPictureBox);
            Program.barcodeScanner.CodeScanned += BarcodeScanner_CodeScanned;
            changeTypeComboBox.DataSource = Enum.GetValues(typeof(ChangeType));
        }

        private void BarcodeScanner_CodeScanned(object sender, string code)
        {
            kodKreskowyProduktuTextBox.Invoke(
                (Delegate)(
                    () =>
                    {
                        if (kodKreskowyProduktuTextBox.Text == "")
                            kodKreskowyProduktuTextBox.Text = code;
                        else
                            kodKreskowyProduktuTextBox.Text = code;
                    }
                )
            );
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                var query = db.Products.SingleOrDefault(
                    p => p.Barcode == kodKreskowyProduktuTextBox.Text
                );
                if (query == null)
                {
                    MessageBox.Show(
                        "Nie znaleziono produktu o podanym kodzie kreskowym",
                        "Błąd",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }
                InventoryChange newInventoryChange = new InventoryChange
                {
                    PositionId = query.PositionId,
                    Type = changeTypeComboBox.SelectedItem.ToString(),
                    Amount = (int)iloscNumericUpDown.Value,
                    Date = DateTime.Now.ToUniversalTime(),
                };
                if (newInventoryChange.Type == "Sprzedaż" || newInventoryChange.Type == "Kradzież")
                {
                    db.InventoryPositions
                        .Single(p => p.Id == newInventoryChange.PositionId)
                        .Amount -= iloscNumericUpDown.Value;
                }
                else
                {
                    db.InventoryPositions
                        .Single(p => p.Id == newInventoryChange.PositionId)
                        .Amount += iloscNumericUpDown.Value;
                }
                db.InventoryChanges.Add(newInventoryChange);
                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
