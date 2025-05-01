string input = Console.ReadLine();
bool isRight = (input[0] - '0' + input[4] - '0') == (input[8] - '0');
Console.Write(isRight? "YES" : "NO");