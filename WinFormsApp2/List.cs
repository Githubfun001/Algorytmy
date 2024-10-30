using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class List
    {
        public Node? head;
        public Node? tail;
        public int count = 0;

        public void AddFirst(int liczba)
        {
            Node add = new(liczba);
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
            Node add = new(liczba);
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

        public Node? RemoveFirst()
        {
            if (this.head == null)
                return null;

            Node wynik;

            if (this.head == this.tail)
            {
                wynik = this.head;
                this.head = this.tail = null;
                this.count = 0;
                return wynik;
            }

            wynik = this.head;
            this.head = this.head.next;
            if (this.head != null)
                this.head.prev = null;
            wynik.next = null;
            this.count--;
            return wynik;
        }

        public Node? RemoveLast()
        {
            if (this.tail == null)
                return null;

            Node wynik;

            if (this.tail == this.head)
            {
                wynik = this.head;
                this.tail = this.head = null;
                this.count = 0;
                return wynik;
            }

            wynik = this.tail;
            this.tail = this.tail.prev;
            if (this.tail != null)
                this.tail.next = null;
            wynik.prev = null;
            this.count--;
            return wynik;
        }

        public override string ToString()
        {
            if (this.head == null)
                return "Lista jest pusta";

            Node? current = this.head;
            string str = "";

            while (current != null)
            {
                str += current.data + " ";
                current = current.next;
            }

            return str.TrimEnd();
        }
    }
}
