using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sklep.Utils
{
    static class EnvLoader
    {
        public static Dictionary<string, string> LoadFromFile(string filename)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(filename);
            foreach(string line in lines)
            {
                string key = line.Split('=')[0];
                string value = line.Split('=')[1];
                result.Add(key, value);
            }
            return result;
        }
    }
}
