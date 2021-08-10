using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class ArrayRotation
    {
        public static List<int> RotateLeft(List<int> a, int d)
        {
            Queue<int> inputs = new Queue<int>(a);
            var resultList = new List<int>();

            while (d-- > 0)
            {
                inputs.Enqueue(inputs.Dequeue());
            }

            return inputs.ToList();
        }

        public static List<int> RotateLeftRecur(List<int> a, int d)
        {
            if (d == 0)
            {
                return a;
            }
            var end = a.Count();
            var temp = a[0];
            for (int i = 0; i < end-1; i++)
            {
                a[i] = a[i + 1];
            }
            a[end - 1] = temp;
            d--;
            return RotateLeft(a, d);
        }

        public static List<int> ReverseArray(List<int> a, int d)
        {
            Stack<int> inputs = new Stack<int>(a);
            var resultList = new List<int>();

            while (d-- > 0)
            {
                inputs.Push(inputs.Pop());
            }

            foreach (int input in inputs)
            {
                resultList.Add(input);
            }
            return resultList;
        }
    }
}
