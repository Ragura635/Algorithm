using System.Text;

int input = int.Parse(Console.ReadLine());
        
        StringBuilder sb = new StringBuilder();

        long answer = (long)Math.Pow(input - 1, 2); 
        
        sb.Append(answer + "\n");

        for (int i = 2; i <= input; i++)
        {
            sb.Append(i + " 1\n");
        }
        
        Console.Write(sb);