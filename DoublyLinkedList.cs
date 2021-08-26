using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class DoublyLinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node prev;
            public Node(int d)
            {
                data = d;
                next = null;
                prev = null;
            }
        }

        public static Node InsertAtTailRec(Node head, int data)
        {
            if (head == null)
            {
                return new Node(data);
            }
            if (head.next == null)
            {
                Node node = new Node(data);
                head.next = node;
                node.prev = head;
                return head;
            }
            InsertAtTailRec(head.next, data);
            return head;
        }

        public static Node SortedInsertRec(Node head, int data)
        {
            if (head == null)
            {
                return new Node(data);
            }
            if (data < head.data)
            {
                Node node = new Node(data);
                node.next = head;
                head.prev = node;
                return node;
            }
            var rest = SortedInsertRec(head.next, data);
            head.next = rest;
            rest.prev = head;
            return head;
        }

        public static Node SortedInsert(Node head, int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                return node;
            }
            var start = head;
            while (head.next.data < data)
            {
                head = head.next;
            }
            node.next = head.next;
            head.next.prev = node;
            head.next = node;
            node.prev = head;
            return start;
        }

        public static Node InsertAtTail(Node head, int data)
        {
            if (head == null)
            {
                return new Node(data);
            }
            var start = head;
            while (head.next != null)
            {
                head = head.next;
            }

            var node = new Node(data);
            head.next = node;
            node.prev = head;
            return start;
        }

        public static void Display(Node head)
        {
            while (head != null)
            {
                Console.WriteLine(head.data);
                head = head.next;
            }
        }

    }
}
