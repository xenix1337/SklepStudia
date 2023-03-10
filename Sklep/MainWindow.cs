using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sklep.Database;

namespace Sklep
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // TODO: Remove this sample code as it's just for tests
            DatabaseConnection db = new DatabaseConnection();
            db.Connect(DatabaseConnectionSettings.FromEnv());
        }
    }
}
