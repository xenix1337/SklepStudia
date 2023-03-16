using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep.Utils
{
    public static class EANValidator
    {
        public static bool validateBarcode(string code)
        {
            if (code.Length != 13 || int.TryParse(code, out _))
            {
                return false;
            }

            int sum = 0;

            for (int i = 0; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    sum += code[i] - '0';
                }
                else
                {
                    sum += (code[i] - '0') * 3;
                }
            }

            int checkDigit = (10 - (sum % 10)) % 10;

            return checkDigit == code[12] - '0';
        }
    }
}
