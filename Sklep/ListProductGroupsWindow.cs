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
    public partial class ListProductGroupsWindow : Form
    {
        private DatabaseContext db;
        private bool changes = false;

        public ListProductGroupsWindow()
        {
            InitializeComponent();
        }

        private void ListProductGroupsWindow_Load(object sender, EventArgs e)
        {
            db = new DatabaseContext();
            db.ProductGroups.Include("Product").Load();

            DataGridViewColumn[] columns = {
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Kod kreskowy grupy",
                    DataPropertyName = "GroupBarcode",
                    Width = 200
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Kod kreskowy produktu",
                    DataPropertyName = "Product.Barcode",
                    Width = 200
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Ilość",
                    DataPropertyName = "Amount",
                }
            };

            productDataGridView.AutoGenerateColumns = false;
            productDataGridView.Columns.Clear();
            productDataGridView.DataSource = db.ProductGroups.Local.ToBindingList();

            foreach (var column in columns)
            {
                productDataGridView.Columns.Add(column);
            }
        }
        private void productDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            changes = true;
        }

        private void ListProductsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!changes) return;

            var result = MessageBox.Show("Czy chcesz zapisać zmiany?", "Niezapisane zmiany", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) db.SaveChanges();
            else if (result == DialogResult.Cancel) e.Cancel = true;
        }
    }
}
