int input = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        int buildingCount = 0;

        for (int i = 0; i < input; i++)
        {
            string[] inputStr = Console.ReadLine().Split();
            int height = int.Parse(inputStr[1]);

            while (stack.Count > 0 && stack.Peek() > height)
            {
                stack.Pop();
                buildingCount++;
            }

            if (stack.Count == 0 || stack.Peek() < height)
            {
                if (height != 0) stack.Push(height);
            }
        }

        buildingCount += stack.Count;

        Console.WriteLine(buildingCount);