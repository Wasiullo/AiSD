using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4_2
{
    internal class NodeT
    {
        public NodeT rodzic;
        public NodeT lewe;
        public NodeT prawe;
        public int data;

        public NodeT(int liczba)
        {
            this.data = liczba;
        }
        public void Polacz(NodeT dziecko)
        {
            dziecko.rodzic = this;
            if (dziecko.data < this.data)
            {
                this.lewe = dziecko;
            }
            else
            {
                this.prawe = dziecko;
            }
        }
    }
}
