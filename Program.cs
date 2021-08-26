using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            //SinglyLinkedList.Node head = null;
            //int[] arr = { 2, 3, 4, 1 };
            //foreach (var item in arr)
            //{   
            //    head = SinglyLinkedList.Insert(head, item);
            //}
            //SinglyLinkedList.Display(head);
            //head = SinglyLinkedList.ReverseList(head);
            //Console.WriteLine("==== Reverse ====");
            //SinglyLinkedList.Display(head);
            //head = SinglyLinkedList.ReverseListRec(head);
            //Console.WriteLine("==== ReverseRec ====");
            //SinglyLinkedList.Display(head);
            //head = SinglyLinkedList.InsertAtPosRec(head, 99, 2);
            //Console.WriteLine("==== add at 2 ====");
            //SinglyLinkedList.Display(head);

            DoublyLinkedList.Node head = null;
            int[] arr = { 1, 3, 2, 3, 4 };
            foreach (var item in arr)
            {
                //head = DoublyLinkedList.InsertAtTailRec(head, item);
                head = DoublyLinkedList.SortedInsertRec(head, item);
            }
            DoublyLinkedList.Display(head);
            head = DoublyLinkedList.SortedInsertRec(head, 1);
            Console.WriteLine("====");
            DoublyLinkedList.Display(head);
        }

        public static int ComputeDifference(int[] a)
        {
            int min = a[0];
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (min > a[i]) min = a[i];
                if (max < a[i]) max = a[i];
            }
            return (int)Math.Abs(max - min);
        }
    }
}
