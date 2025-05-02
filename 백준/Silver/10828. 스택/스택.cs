using System.Collections;

Stack stack = new Stack();
        
        int orderCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < orderCount; i++)
        {
            string order =  Console.ReadLine();
            string[] orderData = order.Split(' ');

            switch (orderData[0])
            {
                case "push":
                    stack.Push(int.Parse(orderData[1]));
                    break;
                case "pop":
                    Console.WriteLine((stack.Count > 0)? stack.Pop() : -1 );
                    break;
                case "size":
                    Console.WriteLine(stack.Count);
                    break;
                case "empty":
                    Console.WriteLine((stack.Count > 0)? 0 : 1 );
                    break;
                case "top":
                    Console.WriteLine((stack.Count > 0)? stack.Peek() : -1 );
                    break;
            }
        }