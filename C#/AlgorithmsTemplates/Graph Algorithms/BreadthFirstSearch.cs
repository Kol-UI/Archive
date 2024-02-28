
//  Breadth-First Search
// BFS

// /!\
// Use BFS if we need to find the shortest distance from a node in the unweighted graph.
// Use DFS in path-finding algorithms to find paths between nodes.
// /!\

// In a BFS, you first explore all the nodes one step away, then all the nodes two steps away, etc...
// First line, then Second, then third etc...
// Until end reached
// Reminder DFS (=/= BFS) : visit all the children in a single branch before moving to other branch.

// Advantages:
// A BFS will find the shortest path between the starting point and any other reachable node. A depth-first search will not necessarily find the shortest path.

// Disadvantages:
// A BFS on a binary tree generally requires more memory than a DFS.

public class Graph<T>
{
    // The Graph Class contains the adjacency list and has a couple of helpers to add nodes and edges
    public Graph(){}
    public Graph(IEnumerable<T> vertices, IEnumerable<Tuple<T,T>> edges)
    {
        foreach(var vertex in vertices)
            AddVertex(vertex);

        foreach(var edge in edges)
            AddEdge(edge);
    }

    public Dictionary<T, HashSet<T>> AdjacencyList { get; } = new Dictionary<T, HashSet<T>>();

    public void AddVertex(T vertex)
    {
        AdjacencyList[vertex] = new HashSet<T>();
    }

    public void AddEdge(Tuple<T,T> edge)
    {
        if (AdjacencyList.ContainsKey(edge.Item1) && AdjacencyList.ContainsKey(edge.Item2))
        {
            AdjacencyList[edge.Item1].Add(edge.Item2);
            AdjacencyList[edge.Item2].Add(edge.Item1);
        }
    }
}

public class Algorithms
{
    static void Exemple()
    {
        int[] tree = new int[]();
        tree[1] = new List { 2, 3, 4 };
        tree[2] = new List { 5 };
        tree[3] = new List { 6, 7 };
        tree[4] = new List { 8 };
        tree[5] = new List { 9 };
        tree[6] = new List { 10 };
        HashSet itemCovered = new HashSet();
        Queue queue = new Queue();
        queue.Enqueue(tree.ElementAt(0).Key);
        while (queue.Count > 0)
        {
            var element = queue.Dequeue();
            if (itemCovered.Contains(Convert.ToInt32(element)))
                continue;
            else
                itemCovered.Add(Convert.ToInt32(element));
            Console.WriteLine(element);
            List neighbours;
            tree.TryGetValue(Convert.ToInt32(element), out neighbours);
            if (neighbours == null)
                continue;
            foreach (var item1 in neighbours)
            {
                queue.Enqueue(item1);
            }
        }
    }
}
