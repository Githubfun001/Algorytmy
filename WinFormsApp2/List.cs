using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class List
    {
        public Node head;
        public Node tail;
        public int count=0;

        public void AddFirst(int liczba)
        {

        }
        
        public void AddLast(int liczba)
        {
            Node add = new Node(liczba);
            this.tail.next = add;
            add.prev = this.tail;
            this.tail = add;
            this.count++;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
