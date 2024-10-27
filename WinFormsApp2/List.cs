using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class List
    {
        public Node ?head;
        public Node ?tail;
        public int count=0;

        public void AddFirst(int liczba)
        {
            Node add = new Node(liczba);
            if (head == null)
            {
                this.head = add;
                this.tail = add;
            }
            else
            {
                add.next = this.head;
                this.head.prev = add;
                this.head = add;
            }
            this.count++;
        }
        
        public void AddLast(int liczba)
        {
            Node add = new Node(liczba);
            if (this.tail == null)
            {
                this.head = add;
                this.tail = add;
            }
            else
            {
                this.tail.next = add;
                add.prev = this.tail;
                this.tail = add;
            }
            this.count++;
        }

        public void RemoveFirst()
        {
            if (this.head != null)
            {
                if (this.head == this.tail)
                {
                    this.head = null;
                    this.tail = null;
                }
                else
                {
                    this.head = this.head.next;
                    if(this.head != null)
                        this.head.prev = null;
                }
                this.count--;
            }
        }

        public void RemoveLast()
        {
            if (this.tail != null)
            {
                if (this.tail == this.head)
                {
                    this.tail = null;
                    this.head = null;
                }
                else
                {
                    this.tail = this.tail.prev;
                    if(this.tail != null)
                        this.tail.next = null;
                }
                this.count--;
            }
        }

        public override string ToString()
        {
            if (this.head == null) 
                return "Lista jest pusta";

            Node ?current = this.head;
            StringBuilder str = new System.Text.StringBuilder();

            while(current != null)
            {
                str.Append(current.data + " ");
                current = current.next;
            }

            return str.ToString().TrimEnd();
        }
    }
}
