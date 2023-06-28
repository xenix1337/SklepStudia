using Microsoft.EntityFrameworkCore;
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
    public partial class ListInventoryWindow : Form
    {
        private DatabaseContext db;
        public ListInventoryWindow()
        {
            InitializeComponent();
        }

        private void ListInventoryWindow_Load(object sender, EventArgs e)
        {
            db = new DatabaseContext();

            DataGridViewColumn[] columns = {
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Produkt",
                    DataPropertyName = "Product",
                    Width = 200
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Regał",
                    DataPropertyName = "Rack",
                    Width = 200
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Półka",
                    ReadOnly = true,
                    DataPropertyName = "Shelf",
                    Width = 200
                },
                new DataGridViewTextBoxColumn()
                {
                    HeaderText = "Ilość",
                    DataPropertyName = "Amount",
                }
            };
            var query = (from InventoryPosition in db.InventoryPositions
                join Product in db.Products
                on InventoryPosition.Id equals Product.PositionId
                select new
                {
                    Product = Product.LongName,
                    Rack = InventoryPosition.Rack,
                    Shelf = InventoryPosition.Shelf,
                    Amount = InventoryPosition.Amount,
                }).ToList();

            inventoryDataGridView.AutoGenerateColumns = false;
            inventoryDataGridView.Columns.Clear();
            inventoryDataGridView.DataSource = query;

            foreach (var column in columns)
            {
                inventoryDataGridView.Columns.Add(column);
            }
        }
    }
}
