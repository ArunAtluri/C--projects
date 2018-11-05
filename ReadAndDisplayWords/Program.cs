using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadAndDisplayWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the option Manual or File");

            String input = Console.ReadLine().ToLower();

            if (input.Equals("manual"))
            {
                Console.WriteLine("Enter the list of words separated by comma");

                String inputStr = Console.ReadLine() ?? String.Empty;

                String[] inputWords = inputStr.Split(',');

                foreach (string word in inputWords)
                {
                    Console.WriteLine(word);
                }

                File.WriteAllLines("InputFile.txt", inputWords);
            }
            else if (input.Equals("file"))
            {
                Console.WriteLine("Enter the file path");
                String inputFile = Console.ReadLine() ?? String.Empty;

                String[] fileArr = File.ReadAllLines(inputFile);

                foreach (string line in fileArr)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Invalid input provided.");
            }
            
            
        }
    }
}
