using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class NodeG
    {
        public List<NodeG> sąsiedzi = new List<NodeG>();
        int data;

        public NodeG(int liczba)
        {
            this.data = liczba;
        }

        public void Połącz(NodeG g)
        {
            if(!this.sąsiedzi.Contains(g))
                this.sąsiedzi.Add(g);

            if (!g.sąsiedzi.Contains(this))
                g.sąsiedzi.Add(this);
        }

        public override string ToString()
        {
            return this.data.ToString();
        }
        
    }
}