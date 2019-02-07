using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje2Odev2
{
    class EdmondsKarpMAX
    {
        public int nMAX = 0;

        public int FindMaxFlow(
            int[,] capacityMatrix,
            Dictionary<int, List<int>> neighbors,
            int source,
            int sink,
            out int[,] legalFlows)
        {
            nMAX = capacityMatrix.GetLength(0);

            int f = 0; // initial flow is 0
            legalFlows = new int[nMAX, nMAX]; // residual capacity from u to v is capacityMatrix[u,v] - legalFlows[u,v]

            while (true)
            {
                BreadthFirstSearch bfs = new BreadthFirstSearch();
                int[] p;
                int m = bfs.BreadthFirstSearchOlustur(capacityMatrix, neighbors, source, sink, legalFlows, out p);

                if (m == 0) break;
                f += m;
                // backtrakc search, and write flow
                int v = sink;

                while (v != source)
                {
                    int u = p[v];
                    legalFlows[u, v] += m;
                    legalFlows[v, u] -= m;
                    v = u;
                }
            }
            return f;
        }
    }
}
