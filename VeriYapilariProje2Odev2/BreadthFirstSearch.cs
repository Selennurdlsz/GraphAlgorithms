using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje2Odev2
{
    class BreadthFirstSearch
    {
       public int BreadthFirstSearchOlustur(
            int[,] capacityMatrix,
            Dictionary<int, List<int>> neighbors,
            int source,
            int sink,
            int[,] legalFlows,
            out int[] p)
        {
            EdmondsKarpMAX max = new EdmondsKarpMAX();
            p = new int[max.nMAX];
            for (int u = 0; u < max.nMAX; u++)
            {
                p[u] = -1;

            }

            p[source] = -2; // make sure source is not rediscovered
            int[] m = new int[max.nMAX]; // capacity of found path to node
            m[source] = int.MaxValue;

            Queue<int> q = new Queue<int>();
            q.Enqueue(source);

            while (q.Count > 0)
            {
                int u = q.Dequeue();
                foreach (int v in neighbors[u])
                {
                    // if there is available capacity, and v is not seen before in search
                    if (capacityMatrix[u, v] - legalFlows[u, v] > 0 &&
                        p[v] == -1)
                    {
                        p[v] = u;
                        m[v] = Math.Min(m[u], capacityMatrix[u, v] - legalFlows[u, v]);

                        if (v != sink) q.Enqueue(v);
                        else return m[sink];
                    }
                }
            }

            return 0;
        }
    }
}
