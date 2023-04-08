using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep
{
    public partial class ReceiptPosition : Control
    {
        public event EventHandler<int> RemoveButtonClick;

        private Label _productLongName;
        private Label _pricePerUnit;
        private decimal _pricePerUnitDecimal;
        private Label _price;
        private NumericUpDown _amount;
        public Button removeButton;
        public decimal PricePerUnit
        {
            get
            {
                return _pricePerUnitDecimal;
            }
            set
            {
                _pricePerUnit.Text = value.ToString();
                _pricePerUnitDecimal = value;
            }
        }
        public decimal Amount
        {
            get
            {
                return _amount.Value;
            }
            set
            {
                _amount.Value = value;
            }
        }
        public string ProductLongName
        {
            get
            {   
                return _productLongName.Text; 
            }
            set
            {
                _productLongName.Text = value;
            }
        }
        public int id;
        public string barcode;
      
        
        public ReceiptPosition()
        {
            InitializeComponent();
            _productLongName = new Label()
            {
                Text = "Product",
                Location = new Point(0, 4),
                Size = new Size(200, 20),
                TabIndex = 0,
                Name = "productNameLabel"
            };
            _pricePerUnit= new Label()
            {
                Text = "5,00",
                Location = new Point(210, 4),
                Size = new Size(50, 20),
                TabIndex = 1,
                Name = "pricePerUnitLabel"
            };
            _amount = new NumericUpDown()
            {
                Value = 0,
                Location = new Point(270, 0),
                Size = new Size(60, 20),
                TabIndex = 2,
                Name = "amountNumericUpDown",
                Maximum = decimal.MaxValue,
                Minimum = 0,
                DecimalPlaces = 3,
            };
            _price = new Label()
            {
                Text = "10",
                Location = new Point(340, 4),
                Size = new Size(50, 20),
                TabIndex = 3,
                Name = "priceLabel"
            };
            removeButton = new Button()
            {
                Text = "X",
                Name = "removeButton",
                ForeColor = Color.Red,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(400, 0),
                Size = new Size(20, 24),
                TabIndex = 4,
            };

            _amount.Controls[0].Visible = false;
            this.Controls.Add(_productLongName);
            this.Controls.Add(_pricePerUnit);
            this.Controls.Add(_amount);
            this.Controls.Add(_price);
            this.Controls.Add(removeButton);
            _amount.ValueChanged += NumericUpDown_ValueChanged;
            removeButton.Click += RemoveButton_Click;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            OnRemoveButtonClick(id);
        }

        void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _price.Text = (_amount.Value * PricePerUnit).ToString();
        }
        protected virtual void OnRemoveButtonClick(int parentId)
        {
            RemoveButtonClick?.Invoke(this, parentId);
        }


        [Category("Custom")]
        [Browsable(true)]
        [Description("Control for listing positions on receipt")]
        [Editor(typeof(System.Windows.Forms.Design.WindowsFormsComponentEditor), typeof(System.Drawing.Design.UITypeEditor))]

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


    }
}
