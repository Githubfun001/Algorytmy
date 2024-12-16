using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6
{
    internal class NodeGS : NodeG
    {
        public char symbol;

        public NodeGS(int data, char symbol) : base(data)
        {
            this.symbol = symbol;
        }
        /*
        .OrderBy(n => n.data)

        .ThemBy(n => n.GetTyp() == typeof(NodeGS) ? 0 : 1).ToList()

        var lista = new list<NodeG>()
        */
    }
}
