using System;
using System.Collections.Generic;

namespace c_sharp_playground.Graphs
{
    public class DepthFirstSearch
    {
        public void Traverse(BinaryNode root)
        {
            var stack = new Stack<BinaryNode>();
            BinaryNode thisNode = null;
            //push the root onto the stack
            stack.Push(root);
            while (stack.Count > 0)
            {
                thisNode = stack.Pop();
                Console.WriteLine(thisNode.Value);

                //push right then left
                if (thisNode.Right != null)
                {
                    stack.Push(thisNode.Right);
                }

                if (thisNode.Left != null)
                {
                    stack.Push(thisNode.Left);
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