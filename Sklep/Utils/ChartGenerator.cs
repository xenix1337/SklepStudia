using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Utils
{
    internal class ChartGenerator
    {
        public static Bitmap GenerateFromJSON(int width, int height, string json)
        {
            string url = "https://quickchart.io/chart?width=" + width.ToString() + "&height=" + height.ToString() + "&chart=" + json;
            using (WebClient client = new WebClient())
            {
                byte[] imageData = client.DownloadData(url);
                using (MemoryStream memoryStream = new MemoryStream(imageData))
                {
                    return new Bitmap(memoryStream);
                }
            }
        }
    }
}
