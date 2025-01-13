using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WinFormsApp5
{
    internal class Graf1
    {
        public List<NodeG1> nodes = new();
        public List<Edge> edges = new();

        public Graf1() { }
        public Graf1(Edge k)
        {
            Add(k);
            this.edges.Add(k);
        }

        public void Add(Edge k)
        {
            if (!this.nodes.Contains(k.start))
                this.nodes.Add(k.start);

            if (!this.nodes.Contains(k.end))
                this.nodes.Add(k.end);

            if (!edges.Contains(k))
                edges.Add(k);
        }

        public int IleNowychWezlow(Edge k)
        {
            int wynik = 0;
            if (this.nodes != null)
            {
                if (!nodes.Contains(k.start))
                    wynik++;

                if (!nodes.Contains(k.end))
                    wynik++;
                return wynik;
            }
            else
            {
                return 2;
            }
        }

        public void Join(Graf1 g1)
        {
            foreach(Edge edge in g1.edges)
            {
                Add(edge);
            }
        }

        public List<Edge> Kruskal()
        {
            List<Edge> orderedEdges = this.edges.OrderBy(o => o.weight).ToList();
            List<Edge> wynik = new List<Edge>();
            Graf1 nowyGraf = new Graf1(orderedEdges[0]);

            foreach (Edge e in orderedEdges)
            {
                Graf1 temp = nowyGraf;
                if (nowyGraf.IleNowychWezlow(e) == 0)
                {
                    temp.Add(e);
                    if (temp.nodes.Count - temp.edges.Count == 1)
                    {
                        nowyGraf.Add(e);
                        wynik.Add(e);
                    }
                }
                else if (nowyGraf.IleNowychWezlow(e) > 0)
                {
                    nowyGraf.Add(e);
                    wynik.Add(e);
                }
            }
            return wynik;
        }

        public Dictionary<NodeG1, int> Dijkstra(NodeG1 start)
        {
            var odleglosci = nodes.ToDictionary(node => node, node => int.MaxValue);
            var visited = new HashSet<NodeG1>();

            odleglosci[start] = 0;

            while (visited.Count < nodes.Count)
            {
                NodeG1 currentNode = odleglosci
                                    .Where(tmp => !visited.Contains(tmp.Key))
                                    .OrderBy(tmp => tmp.Value)
                                    .FirstOrDefault().Key;

                if (currentNode == null)
                    break;

                visited.Add(currentNode);

                foreach (var edge in edges.Where(e => e.start == currentNode))
                {
                    var sasiad = edge.end;
                    if (visited.Contains(sasiad))
                        continue;

                    var newDistance = odleglosci[currentNode] + edge.weight;
                    if (newDistance < odleglosci[sasiad])
                        odleglosci[sasiad] = newDistance;
                }
            }

            return odleglosci;
        }
    }
}
