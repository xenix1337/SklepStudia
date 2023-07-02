using Sklep.Utils;
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
    public partial class FinalizationDialogForm : Form
    {
        private MainWindow mainForm = null;

        public FinalizationDialogForm()
        {
            InitializeComponent();
            numericUpDown1.Controls[0].Visible = false;
            numericUpDown1.Text = "";
        }

        public FinalizationDialogForm(Form callingForm)
        {
            mainForm = callingForm as MainWindow;
            InitializeComponent();
            numericUpDown1.Controls[0].Visible = false;
            numericUpDown1.Text = "";
        }

        private decimal calculateChange()
        {
            return decimal.Round(numericUpDown1.Value - mainForm.sum, 2);
        }

        private void InputDialogBox_Load(object sender, EventArgs e) { }

        private void acceptCashButton_Click(object sender, EventArgs e)
        {
            decimal change = calculateChange();
            if (change >= 0)
            {
                MessageBox.Show(string.Format("Do wydania {0} PLN", change));
                Close();
            }
            else
            {
                MessageBox.Show("Błąd! Kwota jest za mała!");
            }
        }

        private void exitDialogButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelCartButton_Click(object sender, EventArgs e)
        {
            mainForm.clearCart();
            Close();
        }
    }
}
