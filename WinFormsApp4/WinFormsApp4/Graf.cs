using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class Graf
    {
        public List<NodeG> nodes = new List<NodeG>();

        public Graf()
        {
            NodeG A = new(1);
            NodeG B = new(2);
            NodeG C = new(3);
            NodeG D = new(4);
            NodeG E = new(5);
            NodeG F = new(6);
            NodeG G = new(7);

            nodes.Add(A);
            nodes.Add(B);
            nodes.Add(C);
            nodes.Add(D);
            nodes.Add(E);
            nodes.Add(F);
            nodes.Add(G);

            A.Połącz(B);
            A.Połącz(C);
            B.Połącz(D);
            B.Połącz(E);
            C.Połącz(D);
            C.Połącz(F);
            D.Połącz(F);
            E.Połącz(F);
            F.Połącz(G);
        }


        public List<NodeG> Wszerz(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>() { start };

            for (int i = 0; i < odwiedzone.Count; i++)
            {
                NodeG tmp = odwiedzone[i];
                for (int j = 0; j < tmp.sąsiedzi.Count; j++)
                {
                    if (!odwiedzone.Contains(tmp.sąsiedzi[j]))
                        odwiedzone.Add(tmp.sąsiedzi[j]);
                }
            }
            return odwiedzone;
        }

        public List<NodeG> Wglab(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>();
            DFS(start, odwiedzone);
            return odwiedzone;

            void DFS(NodeG node, List<NodeG> odwiedzone)
            {
                if (!odwiedzone.Contains(node))
                    odwiedzone.Add(node);

                foreach (NodeG sasiad in node.sąsiedzi)
                {
                    if(!odwiedzone.Contains(sasiad))
                        DFS(sasiad, odwiedzone);
                }
            
            }
        }
    }
}