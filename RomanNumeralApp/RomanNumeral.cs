using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralApp
{
    class RomanNumeral
    {
        public RomanNumeral()
        {
            InitializeMap();
        }

        private void InitializeMap()
        {
            RomanMap = new Dictionary<char, int>();
            RomanMap.Add('I', 1);
            RomanMap.Add('V', 5);
            RomanMap.Add('X', 10);
            RomanMap.Add('L', 50);
            RomanMap.Add('C', 100);
            RomanMap.Add('D', 500);
            RomanMap.Add('M', 1000);
        }
        public bool CheckRomanNumber(string roman)
        {
            bool result = true;

            foreach (var ch in roman)
            {
                if (!RomanMap.ContainsKey(ch))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public int Convert(string roman)
        {
            int total       = 0;
            int last_value  = 0;
            bool valid_data = true;

            if (!CheckRomanNumber(roman) || (roman.Length == 0))
            {

                valid_data = false;

                Console.WriteLine("Invalid roman number: {0}", roman);
            }

            if (valid_data)
            {
                for (int i = roman.Length - 1; i >= 0; i--)
                {
                    int new_value = RomanMap[roman[i]];

                    // See if we should add or subtract.
                    if (new_value < last_value)
                        total -= new_value;
                    else
                    {
                        total += new_value;
                        last_value = new_value;
                    }
                }
            }

            return total;
        }

        private Dictionary<char, int> RomanMap { get; set; }
    }
}
