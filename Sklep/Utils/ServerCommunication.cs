﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Sklep.Utils
{
    internal class ServerCommunication
    {
        public static dynamic ScanProduct(string barcode)
        {
            var messageObject = new { command = "scanProduct", data = new { barcode, } };

            return JsonConvert.DeserializeObject(SendRequest(messageObject));
        }

        public static dynamic FinalizeCart(Dictionary<string, decimal> cart)
        {
            var messageObject = new { command = "finalizeCart", data = cart };

            return JsonConvert.DeserializeObject(SendRequest(messageObject));
        }

        private static string SendRequest(object requestJSON)
        {
            string address = SettingsManager.current.serverIP;
            int port = SettingsManager.current.serverPort;
            using (TcpClient client = new TcpClient(address, port))
            {
                string message = JsonConvert.SerializeObject(requestJSON);
                byte[] data = Encoding.UTF8.GetBytes(message);

                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                data = new byte[32000];

                int bytes = stream.Read(data, 0, data.Length);
                client.Close();
                return Encoding.UTF8.GetString(data, 0, bytes);
            }
        }
    }
}
