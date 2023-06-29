﻿using Microsoft.EntityFrameworkCore;
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
        private DatabaseContext db;
        private static readonly Color defaultBackgroundColor = SystemColors.Window;
        private static readonly Color invalidBackgroundColor = Color.FromArgb(255, 66, 66);
        private bool[] validField = new bool[4];
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
            db = new DatabaseContext();
            scannerPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Program.barcodeScanner.pictureBoxes.Push(scannerPictureBox);
            Program.barcodeScanner.CodeScanned += BarcodeScanner_CodeScanned;
            changeTypeComboBox.DataSource = Enum.GetValues(typeof(ChangeType));

        }
        private void BarcodeScanner_CodeScanned(object sender, string code)
        {
            kodKreskowyProduktuTextBox.Invoke((Delegate)(() =>
            {
                if (kodKreskowyProduktuTextBox.Text == "")
                    kodKreskowyProduktuTextBox.Text = code;
                else
                    kodKreskowyProduktuTextBox.Text = code;
            }));
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                InventoryChange newInventoryChange = new InventoryChange
                {
                    PositionId = db.Products.Single(p => p.Barcode == kodKreskowyProduktuTextBox.Text).PositionId,
                    Type = changeTypeComboBox.SelectedItem.ToString(),
                    Amount = (int)iloscNumericUpDown.Value,
                    Date = DateTime.Now.ToUniversalTime(),
                };

                if (newInventoryChange.PositionId == null)
                {
                    MessageBox.Show("Nie znaleziono produktu o podanym kodzie kreskowym", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.InventoryPositions.Single(p => p.Id == newInventoryChange.PositionId).Amount += (int)iloscNumericUpDown.Value;
                db.InventoryChanges.Add(newInventoryChange);
                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
