using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class SinglyLinkedList
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }

        public static Node Insert(Node head, int data)
        {
            if (head is null)
                {
                    head = new Node(data);
                    return head;
                }

            head.next = Insert(head.next, data);

            return head;
        }

        public static Node ReverseList(Node head)
        {
            Node prev = head;
            Node next = null;

            while (prev != null)
            {
                Node temp = prev.next;
                prev.next = next;
                next = prev;
                prev = temp;
            }

            head = next;
            return head;
        }

        public static Node DeleteAtPos(Node head, int pos)
        {
            if (pos == 0)
            {
                return head.next;
            }
            head.next = DeleteAtPos(head.next, pos - 1);
            return head;
        }

        public static Node InsertAtPosition(Node head, int data, int pos)
        {
            if (pos == 0)
            {
                Node oldHead = head;
                head = new Node(data);
                head.next = oldHead;
                return head;
            }
            Node start = head;
            while (head != null && pos > 1)
            {
                head = head.next;
                pos--;
            }
            var next = new Node(data);
            next.next = head.next;
            head.next = next;
            return start;
        }

        public static Node InsertAtPosRec(Node head, int data, int pos)
        {
            if (pos == 0)
            {
                Node node = new Node(data);
                node.next = head;
                return node;
            }
            head.next = InsertAtPosRec(head.next, data, pos - 1);
            return head;
        }

        public static Node ReverseListRec(Node head)
        {
            Node rest;
            if (head == null || head.next == null)
            {
                return head;
            }

            rest = ReverseListRec(head.next);
            head.next.next = head;

            head.next = null;
            return rest;
        }

        public static Node ShowLast(Node head)
        {
            if (head.next == null)
            {
                return head;
            }
            return ShowLast(head.next);
        }

        public static void Delete(Node head, int data)
        {
            if (head.next.data == data)
            {
                head.next = head.next.next;
                return;
            }
            Delete(head.next, data);
        }

        public static void Display(Node head)
        {
            if (head.next is null)
                {
                    Console.WriteLine(head.data);
                    return;
                }
            Console.WriteLine(head.data);
            Display(head.next);
        }
    }
}
