using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Input
    {
        public double InputNumber()
        {
            bool isConverted = true;
            double givenNumber;
            while (true)
            {
                //Console.WriteLine("Enter the value");
                String value = Console.ReadLine();
                isConverted = double.TryParse(value, out givenNumber);

                if (!isConverted)
                {
                    Console.WriteLine("The input must be numeric");
                    continue;
                }
                break;
            }
            

            return givenNumber;
        }
    }
}
