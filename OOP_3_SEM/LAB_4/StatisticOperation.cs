using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    static class StatisticOperation
    {
        public static int sum(this Array arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.arr.Length; i++)
            {
                sum += arr.arr[i];
            }
            return sum;
        }
        public static int max(this Array arr)
        {
            int max = -99999;
            foreach (int x in arr.arr)
            {
                if (x > max) max = x;
            }
            return max;
        }
        public static int min(this Array arr)
        {
            int min = 999999;
            foreach (int x in arr.arr)
            {
                if (x < min) min = x;
            }
            return min;
        }
        public static int delta(this Array arr)
        {
            return Math.Abs(StatisticOperation.max(arr)) - Math.Abs(StatisticOperation.min(arr));
        }
        public static int size(this Array arr)
        {
            return arr.arr.Length;
        }



        public static Array nega(this Array arr)
        {
            Array newArr = new Array();
            for (int i = 0; i < arr.arr.Length; i++)
            {
                if (arr.arr[i] > 0)
                {
                    if (i > 0 && newArr.arr[i - 1] == arr.arr[i]) { }
                    else
                        newArr.arr[i] = arr.arr[i];
                }
                else if (arr.arr[i] < 0)
                {
                    newArr.arr[i] = arr.arr[i + 1];
                }
            }
            return newArr;
        }
        public static void hasSymbol(this Array arr, string c)
        {
            int index = arr.str.IndexOf(c);
            if (index == -1)
                Console.WriteLine("Такого символа нет в строке!");
            else Console.WriteLine("Символ " + c + " присутсвует в строке под индексом " + index);
        }
    }
}
