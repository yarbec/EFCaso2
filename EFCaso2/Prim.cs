﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCaso2

{
    class Prim
    {
        private static int MinLlave(int[] llave, bool[] conjunto, int totalVertices)
        {
            int min = int.MaxValue, minIndice = 0;

            for (int v = 0; v < totalVertices; ++v)
            {
                if (conjunto[v] == false && llave[v] < min)
                {
                    min = llave[v];
                    minIndice = v;
                }
            }

            return minIndice;
        }

        private static void Imprimir(int[] padres, int[,] grafo, int TotalVertices)
        {
            Console.WriteLine("Arista     Peso");
            for (int i = 1; i < TotalVertices; ++i)
                Console.WriteLine("{0} - {1}    {2}", padres[i], i, grafo[i, padres[i]]);
        }

        public static void PrimAlgo(int[,] grafo, int totalVertices)
        {
            int[] padres = new int[totalVertices];
            int[] llaves = new int[totalVertices];
            bool[] mstConjuntos = new bool[totalVertices];

            for (int i = 0; i < totalVertices; ++i)
            {
                llaves[i] = int.MaxValue;
                mstConjuntos[i] = false;
            }

            llaves[0] = 0;
            padres[0] = -1;

            for (int count = 0; count < totalVertices - 1; ++count)
            {
                int u = MinLlave(llaves, mstConjuntos, totalVertices);
                mstConjuntos[u] = true;

                for (int v = 0; v < totalVertices; ++v)
                {
                    if (Convert.ToBoolean(grafo[u, v]) &&
                        mstConjuntos[v] == false && grafo[u, v] < llaves[v])
                    {
                        padres[v] = u;
                        llaves[v] = grafo[u, v];
                    }
                }
            }

            Imprimir(padres, grafo, totalVertices);
        }


    }
}