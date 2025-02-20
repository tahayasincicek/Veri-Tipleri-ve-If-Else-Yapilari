// See https://aka.ms/new-console-template for more information
Console.Write("Enter your password:");
string password = Console.ReadLine();

bool checkLength= password.Length >= 8;
bool checkUpper = password.Any(char.IsUpper);
bool checkSpecial = password.Any(ch => "@#$%".Contains(ch));

if (checkLength && checkUpper && checkSpecial)
{
    Console.WriteLine("Your password is strong");
}
else
{
    Console.WriteLine("Your password is not strong");

    if (!checkLength)
        Console.WriteLine("Password must be at least 8 characters long.");

    if (!checkUpper)
        Console.WriteLine("Password must contain at least 1 uppercase letter.");

    if (!checkSpecial)
        Console.WriteLine("Password must contain at least 1 special character (@, #, $, %).");
}
   