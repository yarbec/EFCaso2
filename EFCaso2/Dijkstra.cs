using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCaso2
{
    class Dijkstra
    {
        private static int DistanciaMinima(int[] distancia, bool[] ConjuntoCaminoMasCorto, int TotalVertices)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < TotalVertices; ++v)
            {
                if (ConjuntoCaminoMasCorto[v] == false && distancia[v] <= min)
                {
                    min = distancia[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private static void Imprimir(int[] distancia, int TotalVertices)
        {
            Console.WriteLine("Vértice    Distancia desde inicio");

            for (int i = 0; i < TotalVertices; ++i)
                Console.WriteLine("{0}\t  {1}", i, distancia[i]);
        }

        public static void DijkstraAlgo(int[,] grafo, int Inicio, int TotalVertices)
        {
            int[] distancia = new int[TotalVertices];
            bool[] ConjuntoCaminoMasCorto = new bool[TotalVertices];

            for (int i = 0; i < TotalVertices; ++i)
            {
                distancia[i] = int.MaxValue;
                ConjuntoCaminoMasCorto[i] = false;
            }

            distancia[Inicio] = 0;

            for (int count = 0; count < TotalVertices - 1; ++count)
            {
                int u = DistanciaMinima(distancia, ConjuntoCaminoMasCorto, TotalVertices);
                ConjuntoCaminoMasCorto[u] = true;

                for (int v = 0; v < TotalVertices; ++v)
                    if (!ConjuntoCaminoMasCorto[v] && Convert.ToBoolean(grafo[u, v]) &&
                        distancia[u] != int.MaxValue && distancia[u] + grafo[u, v] < distancia[v])
                        distancia[v] = distancia[u] + grafo[u, v];
            }

            Imprimir(distancia, TotalVertices);
        }


    }
}