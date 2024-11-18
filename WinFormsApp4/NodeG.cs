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

        public static void Połącz(NodeG a, NodeG b)
        {
            a.Połącz(b);
        }

        public override string ToString()
        {
            return this.data.ToString();
        }

        public void Połącz(NodeG somsiad)
        {
            if (!this.sąsiedzi.Contains(somsiad))
                this.sąsiedzi.Add(somsiad);

            if (!somsiad.sąsiedzi.Contains(this))
                somsiad.sąsiedzi.Add(this);
        }
    }
}
