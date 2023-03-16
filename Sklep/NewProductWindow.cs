using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sklep.Models;
using Sklep.Database;

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
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            NewProductModel newProduct = new NewProductModel();
            newProduct.barcode = kodKreskowyTextBox.Text;
            newProduct.shortName = nazwaKrotkaTextBox.Text;
            newProduct.longName = nazwaDlugaTextBox.Text;
            newProduct.price = double.Parse(cenaTextBox.Text);
            newProduct.supplierID = dostawcaComboBox.SelectedIndex; // TODO: ID
            var category = ((IdNameListEntry)kategoriaComboBox.SelectedItem);
            newProduct.categoryID = category?.id;
            AddNewWindowToDatabase(newProduct);
        }

        private void LoadSuppliersList()
        {
            //TODO: Wczytaj dostawców
        }

        private void LoadCategoriesList()
        {
            kategoriaComboBox.Items.Clear();
            kategoriaComboBox.Items.Add(new IdNameListEntry(null, "[NIEOKREŚLONA]"));
            kategoriaComboBox.SelectedIndex = 0;

            var connection = DatabaseConnection.Main.Connection;
            var command = new Npgsql.NpgsqlCommand("SELECT id_kategorii, nazwa FROM kategorie_produktow;", connection);
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                kategoriaComboBox.Items.Add(new IdNameListEntry(id, name));
            }
            reader.Close();
        }

        private void AddNewWindowToDatabase(NewProductModel model)
        {
            var connection = DatabaseConnection.Main.Connection;
            var command = model.GetInsertCommand(connection);
            int result = command.ExecuteNonQuery();
            if(result <= 0)
            {
                MessageBox.Show("Błąd zapisu produktu do bazy", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ValidateBarcode()
        {
            bool valid = true;
            // TODO: Validate barcode in BarcodeValidator
            //if (!BarcodeValidator.Validate(kodKreskowyTextBox.Text)) valid = false;
            
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
            if (nazwaKrotkaTextBox.Text.Length <= 0) valid = false;

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
            if (nazwaDlugaTextBox.Text.Length <= 0) valid = false;

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
            if (!double.TryParse(cenaTextBox.Text, out price)) valid = false;
            if (price < 0) valid = false;
            if (Math.Abs(Math.Round(price * 100) - price * 100) > double.Epsilon * 10) valid = false;

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
            if(validField[0] && validField[1] && validField[2] && validField[3])
            {
                addProductButton.Enabled = true;
            } else
            {
                addProductButton.Enabled = false;
            }
        }
    }
}
