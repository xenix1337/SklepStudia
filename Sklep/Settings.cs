using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    internal class Settings
    {
        public string receiptHeader = "";
        public string receiptFooter = "";
        public string serverIP = "localhost";
        public int serverPort = 2137;
    }

    class SettingsManager
    {
        public static Settings current;
        private static string path = "./settings.json";

        public static void Load()
        {
            if (File.Exists(path))
            {
                string fileContent = File.ReadAllText(path);
                current = JsonConvert.DeserializeObject<Settings>(fileContent);
            }
            else
                current = new Settings();
        }

        public static void Save()
        {
            string fileContent = JsonConvert.SerializeObject(current);
            File.WriteAllText(path, fileContent);
        }
    }
}
