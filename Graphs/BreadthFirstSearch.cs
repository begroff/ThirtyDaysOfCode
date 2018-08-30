using System;
using System.Collections.Generic;

namespace c_sharp_playground.Graphs
{
    public class BreadthFirstSearch
    {
        public void Traverse(BinaryNode root)
        {
            var queue = new Queue<BinaryNode>();
            BinaryNode thisNode = null;
            //push the root onto the queue
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                //remove the next item from the queue
                thisNode = queue.Dequeue();

                //do whatever calc
                Console.WriteLine(thisNode.Value);

                //add the children into the queue
                if (thisNode.Left != null)
                {
                    queue.Enqueue(thisNode.Left);
                }

                if (thisNode.Right != null)
                {
                    queue.Enqueue(thisNode.Right);
                }
            }
        }

        public void Run()
        {
            var rootNode = new BinaryNode(0);
            rootNode.Left = new BinaryNode(1);
            rootNode.Right = new BinaryNode(2);
            rootNode.Left.Left = new BinaryNode(3);
            rootNode.Left.Right = new BinaryNode(4);
            rootNode.Right.Left = new BinaryNode(5);
            rootNode.Right.Right = new BinaryNode(6);
            this.Traverse(rootNode);
        }
    }
}