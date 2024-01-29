using System;
using System.Collections.Generic;

//   Depth-First Search
// DFS

// /!\
// Use BFS if we need to find the shortest distance from a node in the unweighted graph.
// Use DFS in path-finding algorithms to find paths between nodes.
// /!\


// The iterative version of depth-first search requires an extra Stack Data Structure to keep track of vertices to visit

// In DFS algorithm you start with a source node and go in the depth as much as possible.
// In other words you go and visit all the children in a single branch before moving to other branch.

// Depth-first search will help answer the following question:
// Given an undirected graph, G, and a starting vertex, V, what vertices can V reach? This is a question of connectivity.
// which can be very useful when mapping networks, web pages, social networks, etc.

// A Graph is an abstract data structure and can be modeled in various ways.
// Three popular ways to model a graph are
// 1) edge list 
// 2) adjacency matrix
// 3) adjacency list

// Example (adjacency list): there are 3 vertices (1, 2, 3) in the graph.
// Vertex 1 has neighbors 2 and 3,
// vertex 2 has a single neighbor, 1
// and vertex 3 also has a single neighbor, 1.
//  1
// 2 3

// The adjacency list will be a Dictionary in C#
// with the keys being the vertices & the value of each vertex being its set of neighbors.
// AdjacencyList = new Dictionary<T, HashSet<T>>();
// {1:{2, 3}, 2:{1}, 3:{1}}

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


// Here is an example of the depth-first search algorithm in C# that takes an instance of a graph
// & a starting vertex to find all vertices that can be reached by the starting vertex.
public class Algorithms
{
    public HashSet<T> DFS<T>(Graph<T> graph, T start)
    {
        // return an HashSet<T>
        // T starting point
        var visited = new HashSet<T>();

        // To make sure the depth-first search algorithm doesn't re-visit vertices,
        // The visited HashSet keeps track of vertices already visited.

        if (!graph.AdjacencyList.ContainsKey(start))
        {
            return visited;
        }
        
        // A Stack, called stack, keeps track of vertices found but not yet visited.
        var stack = new Stack<T>();
        // Initially stack contains the starting vertex.
        stack.Push(start);

        while (stack.Count > 0)
        {
            // /!\ Logic go there /!\

            // The next vertex is popped from stack.
            var vertex = stack.Pop();

            // If it has already been visited,
            // it is discarded and the next vertex is popped from stack.
            if (visited.Contains(vertex))
            {
                continue;
            }

            // If it has not been visited,
            // it is added to the set of visited vertices
            // & its unvisited neighbors are added to stack.
            visited.Add(vertex);

            foreach(var neighbor in graph.AdjacencyList[vertex])
            {
                if (!visited.Contains(neighbor))
                {
                    stack.Push(neighbor);
                }
            }
            // This continues until there are no more vertices in stack
            // & the set of vertices visited is returned.
        }
        // The set of vertices returned is all the vertices that can be reached from the starting vertex
        return visited;
    }
}

// Given the following graph,
// Use depth-first search in C# to find all vertices that can be reached from 1:
/*
    1
   2 3
  4  5 6
   7  8
      9 10
*/

public class Program
{
    public static void Main(string[] args)
    {
        var vertices = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        var edges = new[]
        {
            Tuple.Create(1,2), Tuple.Create(1,3),
            Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
            Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
            Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)
        };
        // From 1 we can go to 2 & 3: "Tuple.Create(1,2), Tuple.Create(1,3),"
        // From 2 we can go to 4: "Tuple.Create(2,4),"
        // From 3 we can go to 5 & 6: "Tuple.Create(3,5), Tuple.Create(3,6),"...

        var graph = new Graph<int>(vertices, edges);
        // Graph<int> class with its helpers
        var algorithms = new Algorithms();
        // Algorithms class with DFS<T>();

        Console.WriteLine(string.Join(", ", algorithms.DFS(graph, 1)));
        // 1, 3, 6, 5, 8, 9, 10, 7, 4, 2

        // Since all vertices can be reached by 1,
        // it is not surprising that the set of visited vertices returned will be all vertices (1 - 10).

        // Although the HashSet in C# doesn't guarantee an order,
        // the order returned appears to be the exact path followed by depth-first-search.

        // Notice that depth-first search aggresively follows a path until it can't go any futher 
        // & then backtracks a bit and continues to aggressively follow the next available path.

        // Dive Deep: 1 -> 3 -> 6 -> 5 -> 8 -> 9 -> 10, 
        // & then backtrack to 5 and dive deep again: 7 -> 4 -> 2.
    }



    // Tracing the Path

    // If we want a list of the vertices as they are visited by depth-first search,
    // Just add each vertex one-by-one to a list.
    // Here is depth-first search with an extra parameter, preVisit,
    // which allows one to pass a function that gets called each time a vertex is visited.
    public HashSet<T> DFS<T>(Graph<T> graph, T start, Action<T> preVisit = null)
    {
        var visited = new HashSet<T>();

        if (!graph.AdjacencyList.ContainsKey(start))
        {
            return visited;
        }
            
        var stack = new Stack<T>();
        stack.Push(start);

        while (stack.Count > 0)
        {
            // /!\ Logic go there /!\

            var vertex = stack.Pop();

            if (visited.Contains(vertex))
            {
                continue;
            }

            // preVisit Section
            if (preVisit != null)
            {
                preVisit(vertex);
            }

            visited.Add(vertex);

            foreach(var neighbor in graph.AdjacencyList[vertex])
            {
                if (!visited.Contains(neighbor))
                {
                    stack.Push(neighbor);
                }
            }
                
        }

        return visited;
    }

    // Modify the client a bit to initiate a new list, called path,
    // that gets updated each time a new vertex is visited.
    // As we can see, the HashSet happens to be preserving the order that each vertex was inserted,
    // But not always /!\
    // A list is guaranteed to maintain its order /!\
    public class Program
    {
        public static void Main(string[] args)
        {
            var vertices = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var edges = new[]{Tuple.Create(1,2), Tuple.Create(1,3),
                Tuple.Create(2,4), Tuple.Create(3,5), Tuple.Create(3,6),
                Tuple.Create(4,7), Tuple.Create(5,7), Tuple.Create(5,8),
                Tuple.Create(5,6), Tuple.Create(8,9), Tuple.Create(9,10)};

            var graph = new Graph<int>(vertices, edges);
            var algorithms = new Algorithms();

            var path = new List<int>();

            Console.WriteLine(string.Join(", ", algorithms.DFS(graph, 1, v => path.Add(v))));
            // 1, 3, 6, 5, 8, 9, 10, 7, 4, 2

            Console.WriteLine(string.Join(", ", path));
            // 1, 3, 6, 5, 8, 9, 10, 7, 4, 2
        }
    }
}