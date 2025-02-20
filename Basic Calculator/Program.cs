// See https://aka.ms/new-console-template for more information


Console.WriteLine("Select a process please");
Console.WriteLine("1-Addition");
Console.WriteLine("2-Subtraction");
Console.WriteLine("3-Multiplication");
Console.WriteLine("4-Division");

string process = Console.ReadLine();


Console.WriteLine("Enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int number2 = Convert.ToInt32(Console.ReadLine());

switch (process)
{
    case "1":
        Console.WriteLine("Result: " + (number1 + number2));
        Console.ReadLine();
     break;

    case "2":
        Console.WriteLine("Result: " + (number1 - number2));
        Console.ReadLine();
        break;

    case "3":
        Console.WriteLine("Result: " + (number1 * number2));
        Console.ReadLine();
        break;

    case "4":
        Console.WriteLine("Result: " + (number1 / number2));
        Console.ReadLine();
        break;

    default:
        Console.WriteLine("Please enter valid number");
        Console.ReadLine();
        break;
}
Console.ReadLine();