using System;


namespace Calculator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Input input = new Input();
            //var firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 1st number");
            double firstNumber = input.InputNumber();

            Console.WriteLine("Enter the 2nd number");
            double secondNumber = input.InputNumber();
            
            Console.WriteLine("Enter the operation");
            var operation = Console.ReadLine().ToLower();

            double result = 0;

            if (operation.Equals("multiply") || operation.Equals("*"))
            {
                result = (firstNumber) * (secondNumber);
                Console.WriteLine("The result is " + result);
            }
            else if(operation.Equals("addition") || operation.Equals("+"))
            {
                result = (firstNumber) + (secondNumber);
                Console.WriteLine("The result is " + result);
            }
            else if (operation.Equals("subract") || operation.Equals("-"))
            {
                result = (firstNumber) - (secondNumber);
                Console.WriteLine("The result is " + result);
            }
            else if (operation.Equals("division") || operation.Equals("/"))
            {
                result = (firstNumber) / (secondNumber);
                Console.WriteLine("The result is " + result);
            }
            else if (operation.Equals("modulo") || operation.Equals("%"))
            {
                result = (firstNumber) % (secondNumber);
                Console.WriteLine("The result is " + result);
            }
            else
            {
                Console.WriteLine("The result is unknown, invalid operation.");
            }
         
        }
    }
}
