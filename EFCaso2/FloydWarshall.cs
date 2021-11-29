using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCaso2

{
    class FloydWarshall
    {
        public const int INF = 898989;

        private static void Imprimir(int[,] distancia, int TotalVertices)
        {
            Console.WriteLine("Distancia mínima entre cada par de vértices:");

            for (int i = 0; i < TotalVertices; ++i)
            {
                for (int j = 0; j < TotalVertices; ++j)
                {
                    if (distancia[i, j] == INF)
                        Console.Write("INF".PadLeft(7));
                    else
                        Console.Write(distancia[i, j].ToString().PadLeft(7));
                }

                Console.WriteLine();
            }
        }

        public static void FloydWarshallAlgo(int[,] grafo, int TotalVertices)
        {
            int[,] distancia = new int[TotalVertices, TotalVertices];

            for (int i = 0; i < TotalVertices; ++i)
                for (int j = 0; j < TotalVertices; ++j)
                    distancia[i, j] = grafo[i, j];

            for (int k = 0; k < TotalVertices; ++k)
            {
                for (int i = 0; i < TotalVertices; ++i)
                {
                    for (int j = 0; j < TotalVertices; ++j)
                    {
                        if (distancia[i, k] + distancia[k, j] < distancia[i, j])
                            distancia[i, j] = distancia[i, k] + distancia[k, j];
                    }
                }
            }

            Imprimir(distancia, TotalVertices);
        }

    }
}