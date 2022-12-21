// See https://aka.ms/new-console-template for more information
Int64 number, sum = 0;
Console.Write("Enter any number: ");
number = Convert.ToInt64(Console.ReadLine()!);
while (number > 0)
{
sum += number % 10;
number /= 10;
}
Console.WriteLine ("Sum of digits is " + sum);