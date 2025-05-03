using System.Collections;

int attempts = int.Parse(Console.ReadLine());
        List<string> inputs = new List<string>();
        Stack stack = new Stack();
        
        for (int i = 0; i < attempts; i++)
        {
            inputs.Add(Console.ReadLine());
        }

        foreach (var item in inputs)
        {
            int maxCount = 0;
            
            for (int i = 0; i < item.Length; i++)
            {
                switch (item[i])
                {
                    case '[':
                        stack.Push(item[i]);
                        if(maxCount < stack.Count) maxCount = stack.Count;
                        break;
                    case ']':
                        stack.Pop();
                        break;
                }
            }
            
            Console.WriteLine(Math.Pow(2, maxCount));
        }