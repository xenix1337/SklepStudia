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
    public partial class ListProductCategoriesWindow : Form
    {
        private DatabaseContext db;
        private bool changes = false;

        public ListProductCategoriesWindow()
        {
            InitializeComponent();
        }

        private void ListProductCategoriesWindow_Load(object sender, EventArgs e)
        {
            db = new DatabaseContext();
            db.Categories.Load();

            DataGridViewColumn[] columns =
            {
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "ID",
                    DataPropertyName = "ID",
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Nazwa",
                    DataPropertyName = "Name"
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "VAT",
                    DataPropertyName = "VAT"
                },
                new DataGridViewCheckBoxColumn()
                {
                    HeaderText = "Tylko dla pełnoletnich?",
                    DataPropertyName = "AdultOnly"
                }
            };

            productDataGridView.AutoGenerateColumns = false;
            productDataGridView.Columns.Clear();
            productDataGridView.DataSource = db.Categories.Local.ToBindingList();

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

        private void ListProductCategoriesWindow_FormClosing(object sender, FormClosingEventArgs e)
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
