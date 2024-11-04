using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{   
    internal class NodeT
    {
        public NodeT ?rodzic;
        public NodeT ?lewe;
        public NodeT ?prawe;
        public int data;

        public NodeT(int liczba)
        {
            this.data = liczba;
        }

        public int liczbaDzieci()
        {
            int wynik = 0;
            if (this.lewe != null)
                wynik++;
            if (this.prawe != null)
                wynik++;
            return wynik;
        }

        public void PołączLewe(NodeT dziecko)
        {
            this.lewe = dziecko;
            if(dziecko != null)
                dziecko.rodzic = this;
        }

        public void PołączPrawe(NodeT dziecko)
        {
            this.prawe = dziecko;
            if (dziecko != null)
                dziecko.rodzic = this;
        }
    }
}
