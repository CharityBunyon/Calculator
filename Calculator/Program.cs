using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var unicodeString = "\u263A";
            //Console.WriteLine(unicodeString);
            //Console.ReadLine();
            Console.WriteLine($"Welcome to Calculator! {unicodeString}");
            Console.WriteLine(@"Enter an one of the following operators that you would like to use today: 
                * (mulitply each number)
                ^ (square each number)
                + (add each number)
                - (subtract each number)
                / (divide each number)
                @ (average)");
            var chosenOperator = Console.ReadLine();

            Console.WriteLine("To get started, enter a series of numbers separated by a comma. Here's an example: 1,2,3. No spaces, please.");
            var userInput = Console.ReadLine();
            string[] numbers = userInput.Split(",");
            var output = 1;



            //Multiply

            if (chosenOperator.Contains('*'))
            {
                foreach (var num in numbers)
                {
                    output *= int.Parse(num);
                }
                Console.WriteLine($"The result is: {output}.");
                Console.ReadLine();
            }

            //Squares
            else if (chosenOperator.Contains('^'))
            {
                var squareOutput = "";
                foreach (var num in numbers)
                {
                    var numsToSquare = int.Parse(num);
                    var result = numsToSquare * numsToSquare;
                    squareOutput += ($"{result.ToString()},");
                }
                squareOutput = squareOutput.Remove(squareOutput.Length - 1);
                Console.WriteLine($"The result is: {squareOutput}.");
                Console.ReadLine();
            }

            //Addition
            else if (chosenOperator.Contains('+'))
            {
                var addOutput = 0;
                foreach (var num in numbers)
                {
                    addOutput += int.Parse(num);
                }
                Console.WriteLine($"The result is: {addOutput}.");
                Console.ReadLine();
            }

            //Subtraction
            else if (chosenOperator.Contains('-'))
            {
                var subOutput = 0;
                foreach (var num in numbers)
                {
                    if (subOutput == 0)
                    {
                        subOutput = int.Parse(num);
                    }
                    else
                    {
                        subOutput -= int.Parse(num);
                    }
                    Console.WriteLine($"The result is: {subOutput}.");
                    Console.ReadLine();
                }
            }

            // Division
            else if (chosenOperator.Contains('/'))
            {

                foreach (var num in numbers)
                {
                    // var divOutput = 0;
                    if (output == 0)
                    {
                        Console.WriteLine("Sorry, you can't divide my zero.");
                    }
                    else
                    {
                        output /= int.Parse($"{num}");
                    }

                    Console.WriteLine($"The result is: {output}.");
                    Console.ReadLine();
                } //Couldn't figure out why divide isn't working.
            }

            else if (chosenOperator.Contains('@'))
            {
                var sum = 0;
                foreach (var num in numbers)
                {
                    sum += int.Parse(num);
                }
                var avgOutput = Convert.ToDecimal(sum) / Convert.ToDecimal(numbers.Length);
                Console.WriteLine($"The result is: {avgOutput}.");
                Console.ReadLine();
            }
        }
    }
}


