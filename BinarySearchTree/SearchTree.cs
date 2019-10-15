using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class SearchTree
    {




      
        public Node root;
        Node main;
        public void BinarySearchTree()
        {
            root = null;
        }
        public void Add(int value)
        {
            Node newNode = new Node();
            newNode.value = value;
            if (root == null)
            {
                root = newNode;
                main = root;
            }
            else
            {

                if (value > main.value)
                {
                    if (main.right == null)
                    {
                        main.right = newNode;
                    }
                    else
                    {
                        main = main.right;
                        Add(value);
                    }
                }
                else if (value < main.value)
                {
                    if (main.left == null)
                    {
                        main.left = newNode;
                    }
                    else
                    {
                        main = main.left;
                        Add(value);
                    }
                }
                main = root;
            }
        }













        public bool SearchNodes(Node node, int searchValue)
        {

            if (searchValue > node.value)
            {
                if (node.right == null)
                {
                    return false;
                }
                else
                {
                    //needs to go right
                    return SearchNodes(node.right, searchValue);
                }

            }
            else if (searchValue < node.value)
            {
                if (node.left == null)
                {
                    return false;
                }
                else
                {
                    //needs to go left
                    return SearchNodes(node.left, searchValue);
                }
            }

            else
            {
                return true;
            }







        }
    }
}
