// See https://aka.ms/new-console-template for more information




Console.WriteLine("Enter a number please");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine("Number is positive");
    Console.ReadLine();
}
else if (number < 0)
{
    Console.WriteLine("Number is negative");
    Console.ReadLine();
}

else
{
    Console.WriteLine("Number is zero");
    Console.ReadLine();
}
