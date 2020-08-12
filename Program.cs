using System;

namespace VariableCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCupsOfCoffee = 1;
            string fullName = "Naima Africa Francis";
            string today = "08 / 11 / 2020";

            Console.WriteLine(numberOfCupsOfCoffee + " " + fullName + " " + today);
            Console.WriteLine($"{numberOfCupsOfCoffee} {fullName} {today}");
            Console.WriteLine("What is your name?");

            string userName = Console.ReadLine();

            Console.Write("Nice to meet you, ");
            Console.WriteLine(userName);
            Console.WriteLine("How do you like your eggs?");

            string egg = Console.ReadLine();

            Console.Write("I will make sure your eggs are ");
            Console.WriteLine(egg);
            Console.Write("How many eggs do you want?");

            string firstNumberAsString = Console.ReadLine();

            Console.WriteLine($"You will have {firstNumberAsString} eggs.");
            Console.Write("How many pieces of bacon?");

            string secondNumberAsString = Console.ReadLine();

            Console.WriteLine($"You will have {secondNumberAsString} pieces of bacon.");

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine($"{firstOperand} plus {secondOperand} is {sum}.");
            Console.WriteLine($"{firstOperand} times {secondOperand} is {product}");

        }
    }
}
