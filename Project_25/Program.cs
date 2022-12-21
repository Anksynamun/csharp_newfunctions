// See https://aka.ms/new-console-template for more information
Int64 a, b, i, p = 1;
Console.Write("Enter any number: ");
a = Int64.Parse(Console.ReadLine()!);
Console.Write("Enter power number: ");
b = Int64.Parse(Console.ReadLine()!);
for (i = 1; i <= b; i++)
{
    p = p * a;
}
Console.WriteLine("Powered number is: " + p);