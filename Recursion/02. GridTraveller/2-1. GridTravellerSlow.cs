using System;

class GridTravellerSlow{

    static int GridTravel(int m, int n) {
        if (m == 1 && n == 1) return 1;
        if (m == 0 || n == 0) return 0;                             //remember there is an or
        return GridTravel(m - 1, n) + GridTravel(m, n - 1);         //can either go down or right
    }

    static void Main(string[] args) { 
        Console.WriteLine(GridTravel(1,1));
        Console.WriteLine(GridTravel(2,3));
        Console.WriteLine(GridTravel(3,2));
        Console.WriteLine(GridTravel(3,3));
        Console.WriteLine(GridTravel(15,15));
    }
}