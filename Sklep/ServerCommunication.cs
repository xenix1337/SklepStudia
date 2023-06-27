using Newtonsoft.Json;
using System.Net.Sockets;
using System.Text;

namespace Sklep
{
    internal class ServerCommunication
    {
        public static dynamic ScanProduct(string barcode)
        {
            var messageObject = new
            {
                command = "scanProduct",
                data = new
                {
                    barcode = barcode,
                }
            };

            return JsonConvert.DeserializeObject(SendRequest(messageObject));
        }

        public static dynamic FinalizeCart(object cart)
        {
            var messageObject = new
            {
                command = "finalizeCart",
                data = cart
            };

            return JsonConvert.DeserializeObject(SendRequest(messageObject));
        }

        private static string SendRequest(object requestJSON)
        {
            int port = 2137;
            using (TcpClient client = new TcpClient("localhost", port))
            {
                string message = JsonConvert.SerializeObject(requestJSON);
                byte[] data = Encoding.ASCII.GetBytes(message);

                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new byte[4096];

                int bytes = stream.Read(data, 0, data.Length);
                return Encoding.ASCII.GetString(data, 0, bytes);
            }
        }
    }
}
