using System.Collections;

Stack<long> stack = new Stack<long>();
        
        string inputStr = Console.ReadLine();
        long[] input = inputStr.Split(' ').Select(long.Parse).ToArray();
        long sharkCount = input[0];
        long maxEatCount =  input[1];
        long size = input[2];
        
        string sharksStr = Console.ReadLine();
        long[] sharks = sharksStr.Split(' ').Select(long.Parse).OrderBy(x => x).ToArray();

        long index = 0;

        while (index < sharkCount)
        {
            if (size > sharks[index])
            {
                stack.Push(sharks[index]);
                index++;
            }
            else
            {
                if (stack.Count == 0) break;
                if (maxEatCount == 0) break;

                size += stack.Pop();
                maxEatCount--;
            }
        }
        
        while (maxEatCount > 0 && stack.Count > 0)
        {
            size += stack.Pop();
            maxEatCount--;
        }

        Console.Write(size);