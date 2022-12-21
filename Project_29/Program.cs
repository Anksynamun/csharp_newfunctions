// See https://aka.ms/new-console-template for more information
int Min = -10;
int Max = 10;
int i;
int[] array = new int[8];
Random randNum = new Random();
for (i = 0; i < array.Length; i++)
{
    array[i] = randNum.Next(Min, Max);
}
Array.ForEach(array, Console.WriteLine);