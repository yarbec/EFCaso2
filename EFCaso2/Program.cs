using System;

namespace EFCaso2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] graph =  {
                         { 0,6,5,16,17,0,0},
                         { 7,9,0,6,15,8,0},
                         { 0,0,0,0,10,0,7},
                         { 6,25,5,0,0,1,0},
                         { 0,7,10,0,0,0,4},
                         { 0,12,0,14,0,0,0}
            };

            //El camino más corto de Dijkstra
            Console.WriteLine("Camino mas corto: \n");
            Dijkstra.DijkstraAlgo(graph, 1, 7);

            const int INF = 898989;

            int[,] graph2 = {
                { 0,6,5,16,17,INF,INF},
                { INF,0,INF,INF,INF,INF,INF},
                { 7,9,0,6,15,8,INF},
                { INF,INF,INF,0,10,INF,7},
                { 6,25,5,INF,0,1,INF},
                { INF,7,10,INF,INF,0,4},
                { INF,12,INF,14,INF,INF,0}
            };

            //Algoritmo de Warshall
            Console.WriteLine("Recorrido de mínima distancia que pase por todos los puntos: \n");
            FloydWarshall.FloydWarshallAlgo(graph2, 7);

            int[,] graph3 =  {
                         {0,6,5,16,17,0,0},
                         {6,0,9,0,0,0,0},
                         { 7,9,0,6,15,8,0},
                         {16,0,0,0,10,0,7},
                         {17,25,5,10,0,1,0},
                         {0,7,10,0,1,0,4},
                         {0,12,7,14,0,4,0}
            };
            //aklgoritmo de PRIM
            Console.WriteLine("Distancias mínimas de casa a los demás puntos: \n");
            Prim.PrimAlgo(graph3, 7);

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
