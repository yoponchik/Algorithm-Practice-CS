using System;
using System.Collections.Generic;

public class Algorithm1
{
    static void Main(string[] args)
    {
        //SelectionSort();
        //BubbleSort();
        //InsertionSort();
        #region QuickSort
        /*        int[] arr = new[] { 1, 9, 5, 4, 3, 2, 8 };
                QuickSort(arr, 0, arr.Length - 1);

                for (int i = 0; i < arr.Length; i++){
                    Console.WriteLine(arr[i]);
                }*/
        #endregion QuickSort
        #region MergeSort
        /*        int[] arr = { 12, 11, 13, 5, 6, 7 };
                Sort(arr, 0, arr.Length - 1);

                for (int i = 0; i < arr.Length; ++i){
                    Console.WriteLine(arr[i]);
                }*/
        #endregion MergeSort

        #region BreadthFirstSearch
        /*        BFSGraph g = new BFSGraph(4);

                g.AddEdge(0, 1);
                g.AddEdge(0, 2);
                g.AddEdge(1, 2);
                g.AddEdge(2, 0);
                g.AddEdge(2, 3);
                g.AddEdge(3, 3);


                g.BreadFirstSearch(2);      //starting from vertex 2*/
        #endregion BreadthFirstSearch
        #region DepthFirstSearch    
        /*        DFSGraph g2 = new DFSGraph(4);

                g2.AddEdge(0, 1);
                g2.AddEdge(0, 2);
                g2.AddEdge(1, 2);
                g2.AddEdge(2, 0);
                g2.AddEdge(2, 3);
                g2.AddEdge(3, 3);

                g2.DFS();*/
        #endregion DepthFirstSearch    

        #region Dynamic Programming
        Console.WriteLine(DP(30));
        #endregion Dynamic Programming 
    }



    #region Selection Sort
    //An algorithm that loops through the array pivoting on the ith element.
    static void SelectionSort()
    {

        int i;                  //nth number of the iteration
        int j;                  //nth number in the array(?)
        int min;                //the smallest number in the iteration
        int min_index = 0;      //the location of the smallest number; need to assign for some reason
        int temp;               //for swapping numbers

        int[] array = { 1, 10, 5, 8, 7, 6, 4, 3, 2, 9 };




        for (i = 0; i < array.Length; i++)
        {        //ith iteration; 0 -> 10
            min = 9999;         //arbitrary large number, so that the smallest number can be selected

            for (j = i; j < array.Length; j++)
            {    //jth element in the array; 0->10; loops through all the elements; compare ith element with all the elements
                if (min > array[j])
                {               //if the jth element is less than the current min

                    min = array[j];                 //store the jth element in the min variable
                    min_index = j;                      //store the location of the jth element
                }
            }

            //if the min value is stored 
            temp = array[i];                        //temporarily store the ith element of the array
            array[i] = array[min_index];                //insert min number in the right place
            array[min_index] = temp;                //insert temp into empty element

        }

        for (i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    #endregion Selection Sort

    #region Bubble Sort
    //An algorithm that goes through the ith element, compares it with the next element and sends the smaller number in the front
    //After each iteration, because we're taking the smaller number to the front, we have the largest number in the back
    //As a result, we can decrease the number of iterations as we go. 
    static void BubbleSort()
    {
        int i, j;
        int temp;
        int[] array = { 1, 10, 5, 8, 7, 6, 4, 3, 2, 9 };

        for (i = 0; i < array.Length; i++)
        {
            for (j = i; j < (array.Length - 1) - i; j++)
            {

                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }

        for (i = 0; i < 10; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    #endregion Bubble Sort

    #region Insertion Sort
    //An algorithm where the array is virtually split into a sorted and unsorted part.
    //Values from unsorted are picked and inserted into the correct position
    //Because the array is split, when we have to insert the value, we don't need to loop through the whole
    //array again
    private static void InsertionSort()
    {
        int i, j, temp;
        int[] array = { 1, 10, 5, 8, 7, 6, 4, 3, 2, 9 };


        for (i = 0; i < (array.Length - 1); i++)
        {
            j = i;
            //Console.WriteLine(i);

            while (array[j] > array[j + 1])
            {               //if the jth element is greater than the one behind it
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
                j--;                                        //if the jth element is smaller (or [j+1] > [j]), then after we swap; have to compare with the next preceding number
                                                            //Console.WriteLine(array[j]);              //This is the pivot, used for the array[j] > array[j+1]
                                                            //keep in mind the j decreases, so the number now compares with the next preceding number
                                                            //Console.WriteLine("********");
            }
        }

        for (i = 0; i < (array.Length); i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    #endregion Insertion Sort

    #region Quick Sort
    //A Divide and Conquer algorithm which picks an element as pivot and partitions the given array around the picked pivot
    private static int DivideArray(int[] arr, int left, int right)
    {

        var pivot = arr[left];
        var leftIndex = left;
        var rightIndex = right;

        while (leftIndex < rightIndex)
        {
            while ((leftIndex <= right) && (arr[leftIndex] < pivot)) leftIndex++;
            while ((rightIndex >= left) && (arr[rightIndex] > pivot)) rightIndex--;

            if (leftIndex < rightIndex)
            {
                var temp = arr[leftIndex];
                arr[leftIndex] = arr[rightIndex];
                arr[rightIndex] = temp;

                if (arr[leftIndex] == arr[rightIndex]) rightIndex--;
            }
        }

        return rightIndex;
    }


    private static void QuickSort(int[] arr, int left, int right)
    {

        if (left < right)
        {
            int pivot = DivideArray(arr, left, right);

            QuickSort(arr, left, pivot - 1);
            QuickSort(arr, pivot + 1, right);
        }
    }

    #endregion Quick Sort

    #region MergeSort
    private static void Merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;

        int[] L = new int[n1];
        int[] R = new int[n2];
        int i, j;

        for (i = 0; i < n1; ++i) { L[i] = arr[l + i]; }
        for (j = 0; j < n2; ++j) { R[j] = arr[m + 1 + j]; }

        i = 0;
        j = 0;

        int k = l;
        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }
        while (j < n2)
        {
            arr[k] = R[j];
            j++;
            k++;
        }

    }
    static void Sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
            Sort(arr, l, m);
            Sort(arr, m + 1, r);

            Merge(arr, l, m, r);
        }
    }
    #endregion MergeSort

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

    #region DepthFirstSearch
    public class DFSGraph {
        private int V;
        private List<int>[] adj;
        public DFSGraph(int v) {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i) {
                adj[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int w) { 
            adj[v].Add(w);
        }

        public void DFSUtil(int v, bool[] visited) { 
            visited[v] = true;
            Console.Write(v);

            foreach (int i in adj[v]) {
                int n = i;
                if (!visited[n]) { 
                    DFSUtil(n, visited);
                }
            }
        }

        public void DFS() { 
            bool[] visited = new bool[V];

            for (int i = 0; i < V; ++i) {
                if (visited[i] == false) { 
                    DFSUtil(i, visited);
                }
            }
        }

    }

    #endregion DepthFirstSearch

    #region Dynamic Programming
    //나동빈
    public static int DP(int x) {
        int[] prev = new int[100];
        if (x == 1) return 1;
        if (x == 2) return 1;
        if (prev[x] != 0) return prev[x];
        return DP(x - 1) + DP(x -2);
    }

    #endregion Dynamic Programming

    #region Greedy
    #endregion Greedy
}