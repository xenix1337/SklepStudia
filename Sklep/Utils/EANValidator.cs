using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Utils
{
    public class EANValidator
    {
        public bool validate(string code)
        {
            if (code.Length != 13)
            {
                return false;
            }

            int sum = 0;

            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    sum += int.Parse(code[i].ToString());
                }
                else
                {
                    sum += int.Parse(code[i].ToString()) * 3;
                }
            }

            int checkDigit = (10 - (sum % 10)) % 10;

            return checkDigit == int.Parse(code[12].ToString());
        }
    }
}
