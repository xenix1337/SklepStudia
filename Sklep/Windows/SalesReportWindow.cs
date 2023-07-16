using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Sklep.Database;
using Sklep.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sklep
{
    public partial class SalesReportWindow : Form
    {
        public SalesReportWindow()
        {
            InitializeComponent();
        }

        private void SalesReportWindow_Load(object sender, EventArgs e)
        {
            chartPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void SalesReportWindow_SizeChanged(object sender, EventArgs e)
        {
            ReloadChart();
        }

        void ReloadChart()
        {
            string json = "{type:'bar',data:{labels:" +
                GenerateChartLabels() +
                ", datasets:[{label:'Dzienny przychód',data:" +
                GenerateChartData() +
                "}]},options: {title: {display: true,text: 'Bar Chart',},plugins: {datalabels: {anchor: 'center',align: 'center',color: 'black',font: {weight: 'normal',},},},}}";

            chartPictureBox.Image = ChartGenerator.GenerateFromJSON(chartPictureBox.Width, chartPictureBox.Height, json);
        }

        string GenerateChartLabels()
        {
            DateTime startDay = DateTime.Today.AddDays(-29);
            var dates = Enumerable.Range(0, 30).Select(offset => "'" + startDay.AddDays(offset).ToString("dd.MM.yyyy") + "'").ToArray();

            return "[" + string.Join(", ", dates) + "]";
        }

        string GenerateChartData()
        {
            using (var db = new DatabaseContext())
            {
                DateTime startDay = DateTime.Today.AddDays(-29);

                var query =
                    from date in Enumerable.Range(0, 30).Select(offset => startDay.AddDays(offset))
                    join receipt in db.Receipts on date.Date equals receipt.Date.Date into receiptsGroup
                    join receiptPosition in db.ReceiptItems on receiptsGroup.FirstOrDefault()?.Id equals receiptPosition.ReceiptId into receiptPositionsGroup
                    join product in db.Products on receiptPositionsGroup.FirstOrDefault()?.ProductId equals product.Id into productsGroup
                    let totalAmount = receiptPositionsGroup.Sum(rp => Convert.ToDouble(rp.Amount) * rp.Product.Price)
                    select totalAmount;


                var resultsArray = query.Select(d => d.ToString("0.00").Replace(",", ".")).ToArray();
                return "[" + string.Join(", ", resultsArray) + "]";
            }
        }
    }
}
