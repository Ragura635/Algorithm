int input = int.Parse(Console.ReadLine());
for (int i = 1; i <= input; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}