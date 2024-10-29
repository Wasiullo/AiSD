using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{

    internal class BST
    {
        public NodeT root;

        public void Add(int liczba)
        {
            if (root == null)
            {
                root = new NodeT(liczba);
                return;
            }

            AddRecursive(root, liczba);
        }

        private void AddRecursive(NodeT current, int liczba)
        {
            if (liczba < current.data)
            {
                if (current.lewe == null)
                {
                    current.lewe = new NodeT(liczba);
                }
                else
                {
                    AddRecursive(current.lewe, liczba);
                }
            }
            else
            {
                if (current.prawe == null)
                {
                    current.prawe = new NodeT(liczba);
                }
                else
                {
                    AddRecursive(current.prawe, liczba);
                }
            }
        }
    }
}
