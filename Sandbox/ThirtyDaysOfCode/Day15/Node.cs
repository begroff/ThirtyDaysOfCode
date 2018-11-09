using System;
using System.Text;

namespace Sandbox.ThirtyDaysOfCode.Day15
{
    public class Node
    {
        public int data;
        public Node next;

        public Node()
        {

        }

        public Node(int data)
        {
            this.data = data;
            next = null;
        }

        public static Node Insert(Node head, int data)
        {
            // Create the new node
            Node newNode = new Node(data);

            // Save the head reference to a temporary variable
            Node temp = head;

            // When the list is empty return the new node
            if (head == null)
            {
                return newNode;
            }
            else
            {
                // Traverse the list, setting temp(i.e. head) to the last node
                while (temp.next != null)
                {
                    temp = temp.next;
                }
            }

            // Put the new node at the end
            temp.next = newNode;

            // Return the list
            return head;
        }

        public string ToString(Node head)
        {
            StringBuilder list = new StringBuilder();

            Node start = head;
            while (start.next != null)
            {
                list.Append(start.data + " ");
                start = start.next;
            }

            // Append the last node's data
            list.Append(start.data);

            return list.ToString();
        }
    }
}