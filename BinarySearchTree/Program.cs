using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node();
            SearchTree searchTree = new SearchTree();


            searchTree.Add(15);
            searchTree.Add(12);
            searchTree.Add(50);
            searchTree.Add(61);
            searchTree.Add(33);
            searchTree.Add(67);
            searchTree.Add(11);
            searchTree.Add(34);

        }
    }
}
