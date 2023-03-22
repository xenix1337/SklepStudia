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
        public ListProductsWindow()
        {
            InitializeComponent();
        }

        private void ListProductsWindow_Load(object sender, EventArgs e)
        {

            using (var db = new DatabaseContext())
            {
                productDataGridView.AutoGenerateColumns = false;
                productDataGridView.Columns.Clear();

                db.Products.Load();
                db.Categories.Load();
                productDataGridView.DataSource = db.Products.Local.ToBindingList();

                DataGridViewTextBoxColumn[] columns = {
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
                    new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "Cena",
                        DataPropertyName = "Price"
                    },
                    new DataGridViewTextBoxColumn()
                    {
                        HeaderText = "Kategoria",
                        DataPropertyName = "Category",
                        Width = 200
                    }
                };
                foreach (var column in columns)
                {
                    productDataGridView.Columns.Add(column);
                }
            }
        }
    }
}
