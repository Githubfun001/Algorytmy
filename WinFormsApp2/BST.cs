using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class BST
    {
        public NodeT? root;

        public void Add(int liczba)
        {
            NodeT dziecko = new(liczba);
            if (this.root == null)
            {
                this.root = dziecko;
                return;
            }
            NodeT rodzic = this.SzukajRodzica(dziecko);

            dziecko.rodzic = rodzic;

            if(rodzic.data > dziecko.data)
                rodzic.lewe = dziecko;
            else
                rodzic.prawe = dziecko;
        }

        /*
        1) Gdy węzeł nie am dzieci - odwiązujemy (w dwóch kierunkach), zwracamy węzeł
        2) Gdy węzeł ma jedno dziecko - w miejsce rodzica wpada mniejsze dziecko
        3) Gdy węzeł ma 2 dzieci - z prawego poddrzewa wybieramy element najmniejszy, 
                                    odpinamy i wstawiamy w miejsce węzła kasowanego
        */

        public void RemoveElement(NodeT n)
        {
            switch(n.liczbaDzieci())
            {
                case 0:
                    this.RemoveElement0(n);

                    break;

                case 1:                    
                    NodeT? dziecko = this.RemoveElement1(n);

                    break;

                case 2:
                    NodeT? tmp = Min(n.prawe);

                    this.RemoveElement(tmp);

                    n.data = tmp.data;

                    break;
            }
        }


        private void RemoveElement0(NodeT? n)
        {
            if (n == null)
                return;

            if (this.root == n)
                this.root = null;
            else
            {
                if (n.rodzic.lewe == n)
                    n.rodzic.lewe = null;
                else if (n.rodzic.prawe == n)
                    n.rodzic.prawe = null;
                n.rodzic = null;
            }
        }

        private NodeT? RemoveElement1(NodeT n)
        {
            NodeT? dziecko = null;

            if (n.lewe != null)
                dziecko = n.lewe;

            else if (n.prawe != null)
                dziecko = n.prawe;

            if (n == root)
            {
                root = dziecko;
            }
            else
            {
                // Przypisz dziecko do rodzica usuwanego węzła
                if (n.rodzic.lewe == n)
                    n.rodzic.lewe = dziecko;
                else
                    n.rodzic.prawe = dziecko;
            }

            // Ustaw nowego rodzica dla dziecka
            if (dziecko != null)
                dziecko.rodzic = n.rodzic;
            return dziecko;
        }

        private static NodeT Min(NodeT n)
        {
            NodeT current = n;
            while (current.lewe != null)
                current = current.lewe;
            return current;
        }

        

        private NodeT SzukajRodzica(NodeT dziecko)
        {
            if (root == null)
                throw new InvalidOperationException("Drzewo nie ma przypisanego roota.");

            NodeT current = this.root;
            while(true)
            {
                if (current.data > dziecko.data)
                {
                    if (current.lewe == null)
                        return current;
                    else
                        current = current.lewe;
                }
                else
                {
                    if (current.prawe == null)
                        return current;
                    else
                        current = current.prawe;
                }
            }
        }

        public void CPD(NodeT? węzeł)
        {   //przykład drzewa     8
            //                3       9
            //             1     4
            //              2   3

            if(węzeł == null)
                return;

            //pre (order) -> 8 3 1 2 4 3 9

            CPD(węzeł.lewe);

            //in (order) -> 1 2 3 3 4 8 9

            CPD(węzeł.prawe);

            //post (order) -> 2 1 3 4 3 9 8
        }
    }
}
