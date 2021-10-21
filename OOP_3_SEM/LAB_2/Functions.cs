using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, int, int, char) Foo(int [] arr1,string str2)
            {
                arr1.Max();
                arr1.Min();
                arr1.Sum();
                str2.First();
                (int,int,int,char) tuple = (arr1.Max(), arr1.Min(), arr1.Sum(), str2.First());
                return tuple;
            }

            int[] arr = { 11, 325, 342, 11111, 1, 113 };
            string str = "Vlad";


            Console.WriteLine(Foo(arr, str));
        }
    }
}
