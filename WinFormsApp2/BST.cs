using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class BST
    {
        public NodeT ?root;
    }

    public void Add(int liczba)
    {
        NodeT add = new(liczba);
        if (this.root == null)
            this.root = add;

    }
}
