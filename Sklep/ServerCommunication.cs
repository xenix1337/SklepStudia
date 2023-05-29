using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep
{
    internal class ServerCommunication
    {
        public static string ScanProduct(string barcode)
        {
            int port = 2137;
            using TcpClient client = new TcpClient("localhost", port);
            string message = "scanProduct\n" + barcode;
            byte[] data = Encoding.ASCII.GetBytes(message);

            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
            data = new byte[2048];

            int bytes = stream.Read(data, 0, data.Length);
            return Encoding.ASCII.GetString(data, 0, bytes);
        }
    }
}
