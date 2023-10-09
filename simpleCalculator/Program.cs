using System;

class Program
{
    public static void Main(string[] args)
    {
        //Description of the application
        Console.WriteLine("Welcome to the console calculator!");

      
        Console.Write("Enter the first number: ");
        //Asking the user to input the number and reading the number
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the mathematical operation ( +, -, *, /): ");
        //Reading user input
        char op = char.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        double result = 0.0;

        switch (op)

        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Divisionby zero is not valid");
                }
                break;

            default: 
                Console.WriteLine("Invalid input!");
                break;
        }

        //Showing both the numbers and the end result here.
        Console.WriteLine($"Result: {num1} {op} {num2} = {result}");

        //This is to exit the calculator from the console.
        Console.WriteLine("press any key to exit");
        Console.ReadKey();

    }

}
        