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
    public partial class ListOfChangesWindow : Form
    {
        private DatabaseContext db;
        public ListOfChangesWindow()
        {
            InitializeComponent();
        }
        private void ListOfChangesWindow_Load(object sender, EventArgs e)
        {
            db = new DatabaseContext();

            DataGridViewColumn[] columns = {
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "ID",
                    DataPropertyName = "Id",
                    Width = 200
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Produkt",
                    DataPropertyName = "Product",
                    Width = 200
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Zdarzenie",
                    ReadOnly = true,
                    DataPropertyName = "Type",
                    Width = 200
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Ilość",
                    DataPropertyName = "Amount",
                    Width = 200

                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Data",
                    DataPropertyName = "Date",
                }
            };

            var query = (from InventoryPosition in db.InventoryPositions
                         join Product in db.Products on InventoryPosition.Id equals Product.PositionId
                         join Change in db.InventoryChanges on Product.PositionId equals Change.PositionId
                         select new
                         {
                             Id = Change.Id,
                             Product = Product.LongName,
                             Type = Change.Type,
                             Amount = Change.Amount,
                             Date = Change.Date,
                         }).ToList();

            changesDataGridView.AutoGenerateColumns = false;
            changesDataGridView.Columns.Clear();
            changesDataGridView.DataSource = query;

            foreach (var column in columns)
            {
                changesDataGridView.Columns.Add(column);
            }
        }
    }
}

