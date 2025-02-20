// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number");
int number3 = Convert.ToInt32(Console.ReadLine());


int biggest;
if (number1>number2 && number1 > number3)
{
    biggest = number1;
    Console.WriteLine("The biggest number is: " + biggest);
}

else if (number2 > number1 && number2 > number3)
{
    biggest = number2;
    Console.WriteLine("The biggest number is: " + biggest);
}
else if (number3 > number1 && number3 > number1)
{
    biggest = number3;
    Console.WriteLine("The biggest number is: " + biggest);
}
