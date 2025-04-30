while (true)
{
    string input =  Console.ReadLine();
    int sum = input[0] - '0' + input[2] - '0';

    if (sum == 0) break;
    Console.WriteLine(sum);
}