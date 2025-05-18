class Program
{
    static List<int>[] node;
    static bool[] visited;
    static int depth;
    static int[] minDepth;
    static int penguinBlock;
    
    static void Main(string[] args)
    {
        //1 https://chatgpt.com/c/68299ad5-de6c-8003-a7d1-67932a234672
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        string[] inputs;
        
        inputs = sr.ReadLine().Split(' ');
        int blocks = int.Parse(inputs[0]);
        node = new List<int>[blocks + 1];
        for (int i = 0; i <= blocks; i++)
        {
            node[i] = new List<int>();
        }
        visited = new bool[blocks + 1];
        
        int roots = int.Parse(inputs[1]);
        minDepth = new int[roots];
        
        penguinBlock = int.Parse(inputs[2]);
        
        for (int i = 0; i < blocks - 1; i++)
        {
            inputs = sr.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
        
            node[a].Add(b);
            node[b].Add(a);
        }

        for (int i = 0; i < roots; i++)
        {
            Array.Fill(visited, false);
            depth = 0;
            DFS(i + 1, 0);
            minDepth[i] = depth;
        }
        
        Array.Sort(minDepth);
        
        sw.WriteLine(blocks - minDepth[0] - minDepth[1] -1);
        sw.Flush();
    }
    
    static bool DFS(int now, int nowDepth)
    {
        visited[now] = true;

        if (now == penguinBlock)
        {
            depth = nowDepth;
            return true;
        }

        foreach (int next in node[now])
        {
            if (!visited[next])
            {
                if (DFS(next, nowDepth + 1)) return true;
            }
        }

        return false;
    }
}