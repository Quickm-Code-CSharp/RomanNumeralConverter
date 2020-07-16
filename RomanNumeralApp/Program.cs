using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanNumeral converter = new RomanNumeral();
            bool isExitKey = false;

            Console.Write("Enter roman number or Q: ");
            do
            {
                string entry = Console.ReadLine();
                Console.WriteLine(Environment.NewLine);

                isExitKey = (entry.ToUpper().Equals("Q"));
                if (!isExitKey)
                {
                    int value = converter.Convert(entry);

                    Console.WriteLine("Roman number: {0}  Integer value: {1}", entry, value);
                    Console.Write("Enter roman number or Q: ");
                }

            } while (!isExitKey);
        }
    }
}
