using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4_2
{
    internal class BST
    {
        public NodeT root;

        public void Add(int liczba)
        {
            var dziecko = new NodeT(liczba);
            if (this.root == null)
            {
                this.root = dziecko;
                return;
            }

            var rodzic = this.SzukajRodzica(dziecko);
            rodzic.Polacz(dziecko);
        }
        NodeT SzukajRodzica(NodeT dziecko)
        {
            NodeT temp = this.root;
            while (true)
            {
                if (dziecko.data < temp.data)
                {
                    if (temp.lewe == null)
                    {
                        return temp;
                    }
                    else
                    {
                        temp = temp.lewe;
                    }
                }
                else
                {
                    if(temp.prawe == null)
                    {
                        return temp;
                    }
                    else
                    {
                        temp = temp.prawe;
                    }
                }
            }
            
        }

        public void Delete(int value)
        {
            var wezel = FindNode(root, value);
            if (wezel != null)
            {
                Delete(wezel);
            }
        }

        public NodeT FindNode(NodeT wezel, int value)
        {
            if (wezel == null) return null;
            if (wezel.data == value) return wezel;

            if (value < wezel.data)
                return FindNode(wezel.lewe, value);
            else
                return FindNode(wezel.prawe, value);
        }

        public void Delete(NodeT wezel)
        {
            if (wezel == null) return;

            // Przypadek 1: Węzeł bez dzieci
            if (wezel.lewe == null && wezel.prawe == null)
            {
                if (wezel.rodzic != null)
                {
                    if (wezel.rodzic.lewe == wezel) wezel.rodzic.lewe = null;
                    else wezel.rodzic.prawe = null;
                }
                else
                {
                    root = null; // jeśli usuwamy korzeń
                }
                return;
            }

            // Przypadek 2: Węzeł z jednym dzieckiem
            if (wezel.lewe == null || wezel.prawe == null)
            {
                var dziecko = wezel.lewe ?? wezel.prawe; // Znajduje jedyne dziecko (lewe lub prawe)
                dziecko.rodzic = wezel.rodzic;

                if (wezel.rodzic != null)
                {
                    if (wezel.rodzic.lewe == wezel) wezel.rodzic.lewe = dziecko;
                    else wezel.rodzic.prawe = dziecko;
                }
                else
                {
                    root = dziecko; // jeśli usuwamy korzeń
                }
                return;
            }

            // Przypadek 3: Węzeł z dwojgiem dzieci
            var nastepnik = ZnajdzMin(wezel.prawe); // Znajduje najmniejszy element w prawym poddrzewie
            wezel.data = nastepnik.data; // Przypisuje wartość następnika do usuwanego węzła

            // Rekurencyjnie usuwa następnik, który nie może mieć więcej niż jedno dziecko
            Delete(nastepnik);
        }

        private NodeT ZnajdzMin(NodeT wezel)
        {
            while (wezel.lewe != null)
            {
                wezel = wezel.lewe;
            }
            return wezel;
        }

        public List<int> InOrder(NodeT wezel)
    {
            var result = new List<int>();
            if (wezel == null) return result;

            result.AddRange(InOrder(wezel.lewe));
            result.Add(wezel.data);
            result.AddRange(InOrder(wezel.prawe));

            return result;
        }
        public List<int> PreOrder(NodeT wezel)
        {
            var result = new List<int>();
            if (wezel == null) return result;

            result.Add(wezel.data);
            result.AddRange(PreOrder(wezel.lewe));
            result.AddRange(PreOrder(wezel.prawe));

            return result;
        }

        public List<int> PostOrder(NodeT wezel)
        {
            var result = new List<int>();
            if (wezel == null) return result;

            result.AddRange(PostOrder(wezel.lewe));
            result.AddRange(PostOrder(wezel.prawe));
            result.Add(wezel.data);

            return result;
        }
    }
}
