using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Graf1
    {
        List<NodeG1> nodes = new();
        List<Edge> edges = new();

        Graf1(Edge k)
        {
            Add(k);
            this.edges.Add(k);
        }

        public void Add(Edge k)
        {
            if (this.nodes.Contains(k.start))
                this.nodes.Add(k.start);

            if (this.nodes.Contains(k.end))
                this.nodes.Add(k.end);
        }

        public int IleNowychWezlow(Edge k)
        {
            int wynik = 0;
            if (!nodes.Contains(k.start))
                wynik++;

            if (!nodes.Contains(k.end))
                wynik++;

            return wynik;
        }

        public void Join(Graf1 g1)
        {
            foreach(Edge edge in g1.edges)
            {
                Add(edge);
            }
        }
    }
}
