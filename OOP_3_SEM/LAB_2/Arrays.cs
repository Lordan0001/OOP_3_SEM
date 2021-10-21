using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////////1/////////////
            /*  Random random = new Random();
              int[,] arr = new int[4, 4];
              for (int i = 0; i < arr.GetLength(0); i++)
              {
                  for (int j = 0; j < arr.GetLength(1); j++)
                  {
                      arr[i, j] = random.Next(100);
                  }
              }

              for (int i = 0; i < arr.GetLength(0); i++)
              {
                  for (int j = 0; j < arr.GetLength(1); j++)
                  {
                      Console.Write(arr[i, j] + "\t");
                  }
                  Console.WriteLine();
              }*/

            //////////////2///////////////

            /*string[] arr1 = new string[5] {"One","Two","Three","Four","Five" };

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]+"\t");
            }
            Console.WriteLine("\nРазмер массива = "+arr1.Length);
            Console.WriteLine("Поменяем элемент");
            Console.WriteLine("Введите индекс элемента массива: ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значени элемента: ");
            string change = Console.ReadLine();
            arr1[index] = change;*/



            //////////////3///////////////

            /*int[][] arr2 = new int[3][];
            arr2[0] = new int[2];
            arr2[1] = new int[3];
            arr2[2] = new int[4];

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    arr2[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Clear();
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.Write(arr2[i][j] + "\t"); 
                }
                Console.WriteLine();
            }*/

            ////////////////////4/////////////////

          /*  var arr = new[] { 34.33, 235.22, 5675.11 };

            var str = "String"; */

        }
    }
}
