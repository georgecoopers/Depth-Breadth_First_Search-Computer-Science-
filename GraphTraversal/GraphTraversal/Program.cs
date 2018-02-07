using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the tree
            Node tree = new Node(new Node(new Node(null,null,"D"),new Node(null,null,"E"),"B"), new Node(new Node(null,null,"F"), new Node(null,null,"G"), "C"), "A");

            /*        
             *   The equivalent Tree
             *   -------------------
             *            A
             *          /   \
             *         B     C
             *        / \   / \
             *       D   E F   G
             *       
             */

            // Outputting Results to the depth first search
            Console.WriteLine("Depth First Search:");
            DFS(tree);
            Console.Write("\n");

            // Outputting Results for the Breadth First Search
            Console.WriteLine("Breadth First Search:");
            BFS(tree);

            Console.ReadKey();
        }
        // Depth First Search Algorithm
        static void DFS(Node tree)
        {
            if ((tree == null))
            {
                return;
            }
            Console.Write(tree.data + " ");
            DFS(tree.left);
            DFS(tree.right);
        }

        // Breath First Search Algorithm
        static void BFS(Node tree)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(tree);

            while(q.Count >0)
            {
                Node node = q.Dequeue();
                if(node != null)
                {
                    Console.Write(node.data + " ");
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
                
            }
        }
    }
}
