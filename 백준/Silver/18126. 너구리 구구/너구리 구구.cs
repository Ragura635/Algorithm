class Program
{
    static List<(int next, long distance)>[] room;
    static bool[] visited;
    static long maxDistance = 0;
    
    static void Main(string[] args)
    {
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        int n = int.Parse(sr.ReadLine());
        
        if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }
        
        room = new List<(int, long)>[n + 1];
        visited = new bool[n + 1];
        
        for (int i = 1; i <= n; i++) room[i] = new List<(int, long)>();
        
        for (int i = 0; i < n - 1; i++)
        {
            string[] inputs = sr.ReadLine().Split(' ');
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            int c = int.Parse(inputs[2]);
        
            room[a].Add((b, c));
            room[b].Add((a, c));
        }
        
        DFS(1, 0);
        
        var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
        sw.WriteLine(maxDistance);
        sw.Flush();
    }

    static void DFS(int now, long sumDistance)
    {
        visited[now] = true;
        maxDistance = Math.Max(maxDistance, sumDistance);
        
        foreach (var tuple in room[now])
        {
            int next = tuple.Item1;
            long distance = tuple.Item2;
            if (!visited[next])
            {
                DFS(next, sumDistance + distance);
            }
        }
    }
}