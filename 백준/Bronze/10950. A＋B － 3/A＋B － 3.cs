int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string input =  Console.ReadLine();
    
    Console.WriteLine(input[0] - '0' + input[2] - '0');
}