using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Array massiv1 = new Array();
            massiv1.Data(1, 3, 4, 2, 4, 100);

            Array massiv2 = new Array();
            massiv2.Data(1, 3, 4, 2, 4, 100);

            Array arr1 = new Array { Value = 30 };

            Array arr2 = new Array { Value = 22 };

            // **************Перегрузка**************

            Array arr3 = new Array();
            arr3 = arr1 - arr2;
           // arr3.PrintValue();

            bool resultValue = arr1 > arr2;
            // Console.WriteLine(resultValue);

            bool resultMassiv = massiv1 != massiv2;
            // Console.WriteLine(resultMassiv);

            Array massiv3 = new Array();
            massiv3 = massiv1 + massiv2;
            massiv3.PrintArray();


            Date date = new Date();
            date.showDate();
            Console.WriteLine("\n***************  Date and Owner  ***************");
            Array ownerArr = new Array(666, "Vladislav", "Evil Corp.");
            ownerArr.owner.printInfo();

            Console.WriteLine("\n------------  Statistic Operations  -------------");
            Console.WriteLine("Max in arrP: " + massiv3.max());
            Console.WriteLine("Min in arr4: " + massiv3.min());
            Console.WriteLine("Delta in arr3: " + arr3.delta());
            Console.WriteLine("Size of arr2: " + arr2.size());


            Array arrNega = new Array();
            arrNega.Data(1, 2, 3, -1, 4, -2, 5);
            Array arrOut = arrNega.nega();
           // Console.WriteLine("\n************  Delete Negative ************");
           // arrOut.PrintArray();

            Array arrStr = new Array();
            arrStr.str = "Hello World!";
           // Console.WriteLine("\n************  Char Search  ************");
           // Console.WriteLine("\nВведите символ, который хотите найти в строке:");
           // string symbol = Console.ReadLine();
            //arrStr.hasSymbol(symbol);

        }

        //***********Вложенный класс***********
        public class Date
        {
            public DateTime time;
            public Date()
            {
                this.time = new DateTime(2021, 10, 23, 3, 27, 0);
            }
            public void showDate()
            {
                Console.WriteLine("Дата создания: " + time);
            }
        }
    }

  
}
