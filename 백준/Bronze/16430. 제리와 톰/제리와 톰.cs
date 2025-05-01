using System.Text;
string input = Console.ReadLine();
StringBuilder sb = new StringBuilder();
sb.Append(input[2] - input[0]);
sb.Append(" ");
sb.Append(input[2]);
Console.Write(sb);