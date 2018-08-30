using System;

namespace Sandbox.Graphs
{
    public class BinaryNode
    {
        public int Value { get; }
        //child nodes
        public BinaryNode Left { get; set; }
        public BinaryNode Right { get; set; }
        public BinaryNode(int value)
        {
            Value = value;
        }
        public bool IsLeaf()
        {
            return this.Left == null && this.Right == null;
        }
    }
}