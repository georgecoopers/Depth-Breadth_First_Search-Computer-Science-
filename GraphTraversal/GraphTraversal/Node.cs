using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTraversal
{
    class Node
    {
        // Properties
        public Node left;
        public Node right;
        public string data;

        // Constructor with inputs for child nodes
        public Node(Node left, Node right, string data)
        {
            this.left = left;
            this.right = right;
            this.data = data;
        }
    }
}
