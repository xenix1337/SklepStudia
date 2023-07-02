using Microsoft.EntityFrameworkCore;
using Sklep.Database;
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
    public partial class ListProductsWindow : Form
    {
        private DatabaseContext db;
        private bool changes = false;

        public ListProductsWindow()
        {
            InitializeComponent();
        }

        private void ListProductsWindow_Load(object sender, EventArgs e)
        {
            db = new DatabaseContext();
            db.Products.Load();
            db.Categories.Load();

            DataGridViewColumn[] columns =
            {
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Kod kreskowy",
                    DataPropertyName = "Barcode",
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Nazwa krótka",
                    DataPropertyName = "ShortName"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Nazwa",
                    DataPropertyName = "LongName",
                    Width = 200
                },
                new DataGridViewTextBoxColumn() { HeaderText = "Cena", DataPropertyName = "Price" },
                new DataGridViewComboBoxColumn()
                {
                    HeaderText = "Kategoria",
                    DataSource = db.Categories.Local.ToBindingList(),
                    ValueMember = "Id",
                    DisplayMember = "Name",
                    DataPropertyName = "CategoryID",
                    Width = 200
                }
            };

            productDataGridView.AutoGenerateColumns = false;
            productDataGridView.Columns.Clear();
            productDataGridView.DataSource = db.Products.Local.ToBindingList();

            foreach (var column in columns)
            {
                productDataGridView.Columns.Add(column);
            }
        }

        private void productDataGridView_CellValueChanged(
            object sender,
            DataGridViewCellEventArgs e
        )
        {
            changes = true;
        }

        private void ListProductsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!changes)
                return;

            var result = MessageBox.Show(
                "Czy chcesz zapisać zmiany?",
                "Niezapisane zmiany",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
                db.SaveChanges();
            else if (result == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
