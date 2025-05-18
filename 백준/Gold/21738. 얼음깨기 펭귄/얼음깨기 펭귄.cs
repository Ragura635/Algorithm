class Program
{
    static List<int>[] node;
    static int[] dist;
    static int blocks, support, penguinBlock;
    
    static void Main(string[] args)
    {        
        //1 https://www.acmicpc.net/problem/21738 BFS버전
        var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
        var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

        string[] inputs = sr.ReadLine().Split();
        blocks = int.Parse(inputs[0]);
        node = new List<int>[blocks + 1];
        for (int i = 0; i <= blocks; i++)
        {
            node[i] = new List<int>();
        }
        support =  int.Parse(inputs[1]);
        penguinBlock = int.Parse(inputs[2]);
        
        for (int i = 0; i < blocks - 1; i++)
        {
            inputs = sr.ReadLine().Split();
            int a = int.Parse(inputs[0]);
            int b = int.Parse(inputs[1]);
            node[a].Add(b);
            node[b].Add(a);
        }
            
        BFS_EarlyExit(penguinBlock, out int d1, out int d2);
        int result = blocks - d1 - d2 - 1;
        sw.WriteLine(result);
        sw.Flush();
    }

    static void BFS_EarlyExit(int start, out int dist1, out int dist2)
    {
        Queue<int> q = new Queue<int>();
        dist = new int[blocks + 1];
        Array.Fill(dist, -1);

        q.Enqueue(start);
        dist[start] = 0;

        dist1 = dist2 = 0;
        List<int> found = new List<int>();

        while (q.Count > 0)
        {
            int now = q.Dequeue();

            // ✅ now가 지지대면 그때 거리 저장
            if (now <= support)
            {
                found.Add(dist[now]);
                if (found.Count == 2)
                {
                    found.Sort();
                    dist1 = found[0];
                    dist2 = found[1];
                    return;
                }
            }

            foreach (int next in node[now])
            {
                if (dist[next] == -1)
                {
                    dist[next] = dist[now] + 1;
                    q.Enqueue(next);
                }
            }
        }
    }
}