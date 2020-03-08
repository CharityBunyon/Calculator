using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculator!");
            Console.WriteLine("To get started, enter a series of numbers separated by a comma. Here's an example: 1,2,3. No spaces, please.");
            var userinput = Console.ReadLine();
            string[] numbers = userinput.Split(",");
            var output = 0;

            foreach (var num in numbers)
            {
                var sum = int.Parse(num);
                if (output == 0)
                {
                    output = sum;
                }
                else
                {
                    output *= sum;
                }
                //Console.WriteLine(num);
            }
            Console.WriteLine($"The final result is: {output}");
            Console.ReadLine();
        }
    }
}

//1. Printed instructions out for the user
//2. Created a variable called userInput that is going to store the input of the user when Console.ReadLine is called.
//3. I used the string split method in which I intend to split the user's input by the commas they use with should give me the numbers and I'll store them in an array called numbers
//4. Created a variable called output to be set to 0.
//5. I looped over each number(string) in my numbers array. 
//6. I converted the numbers in the array by using the int.Parse method, in which I passed each number.
//7. I created a conditional that checks to see if the output is equal to 0 then the sum is 0. Else if the output is not zero, which it shouldn't be.
//8. Else if the output is going to multiple the numbers that are stored in our sum variable.
//9. I wrote out the printed the numbers to make sure the user input was correct.
//10. Asked the app to print the output and called Console.Readline();

