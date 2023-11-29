using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BinarySearchTree bst = new BinarySearchTree();

            bst.Add(5);
            bst.Add(3);
            bst.Add(7);
            bst.Add(2);
            bst.Add(4);
            bst.Add(6);
            bst.Add(8);

            MessageBox.Show("In-order traversal of the binary search tree:");
            bst.InOrderTraversal();
        }
    }

    class Node
    {
        public int key;
        public Node left, right;

        public Node(int value)
        {
            key = value;
            left = right = null;
        }
    }

    class BinarySearchTree
    {
        public Node root=null;


        public void Add(int key)
        {
            root = AddRecursive(root, key);
        }

        private Node AddRecursive(Node node, int key)
        {
            if (node == null)
            {
                return new Node(key);
            }

            if (key < node.key)
            {
                node.left = AddRecursive(node.left, key);
            }
            else if (key > node.key)
            {
                node.right = AddRecursive(node.right, key);
            }

            return node;
        }

        public void InOrderTraversal()
        {
            InOrderTraversalRecursive(root);
        }

        private void InOrderTraversalRecursive(Node node)
        {
            if (node != null)
            {
                InOrderTraversalRecursive(node.left);
                MessageBox.Show(node.key.ToString());
                InOrderTraversalRecursive(node.right);
            }
        }
    }




}
