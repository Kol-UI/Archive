package CodeTemplates;

public class Graph_RecursiveDFS {
    // Graph DFS (recursive)
    // For the graph templates, assume the nodes are numbered from 0 to n - 1 and the graph is given as an adjacency list.
    // Depending on the problem, you may need to convert the input into an equivalent adjacency list before using the templates.
    Set<Integer> seen = new HashSet<>();

    public int fn(int[][] graph) {
        seen.add(START_NODE);
        return dfs(START_NODE, graph);
    }

    public int dfs(int node, int[][] graph) {
        int ans = 0;
        // do some logic
        for (int neighbor: graph[node]) {
            if (!seen.contains(neighbor)) {
                seen.add(neighbor);
                ans += dfs(neighbor, graph);
            }
        }

        return ans;
    }
}
