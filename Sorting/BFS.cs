using System;
using System.Collections.Generic;

public class Algorithm1
{
    static void Main(string[] args)
    {
        #region BreadthFirstSearch
        BFSGraph g = new BFSGraph(4);

        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);


        g.BreadFirstSearch(2);      //starting from vertex 2
        #endregion BreadthFirstSearch

    }





    #region BreadthFirstSearch 
    //https://www.geeksforgeeks.org/breadth-first-search-or-bfs-for-a-graph/
    class BFSGraph
    {

        private int _V;  //# of vertices

        LinkedList<int>[] _adj;

        public BFSGraph(int V)
        {
            _adj = new LinkedList<int>[V];
            for (int i = 0; i < _adj.Length; i++){
                _adj[i] = new LinkedList<int>();
            }
            _V = V;
        }

        public void AddEdge(int v, int w)
        {
            _adj[v].AddLast(w);
        }

        public void BreadFirstSearch(int s)
        {
            bool[] visited = new bool[_V];
            for (int i = 0; i < _V; i++)
            {
                visited[i] = false;

                LinkedList<int> queue = new LinkedList<int>();

                visited[s] = true;
                queue.AddLast(s);

                while (queue.Any())
                {
                    s = queue.First();
                    Console.Write(s + " ");
                    queue.RemoveFirst();

                    LinkedList<int> list = _adj[s];

                    foreach (var val in list)
                    {
                        if (!visited[val])
                        {
                            visited[val] = true;
                            queue.AddLast(val);
                        }
                    }
                }
            }
        }

    }
    #endregion BreadthFirstSearch

