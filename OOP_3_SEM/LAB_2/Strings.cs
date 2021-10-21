using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////1////////////
            /*string str1 = "Hello ";
            string str2 = "World!";
            Console.WriteLine(str1 + str2);*/


            ////////////2////////////

            /* string str1 = "Hello ";
             string str2 = "World";
             string str3 = "!";
 */

            /*string str4 = str1 + str2 + str3;//сцепление

            string str5 = str1;//копирование

            string str6 = "Hello world";//подстрока
            str6 =str6.Substring(6);
            Console.WriteLine(str6);*/

            /*string s14 = "Эта строка, которая будет разделена на подстроки с использованием двух разделителей";
            string[] res = s14.Split(new char[] { ' ', ',' });//разделение на слова
            foreach (string s in res)
            {
                Console.WriteLine(s);
            }*/

            /* str1 = str1.Insert(6, "World");//вставка
             Console.WriteLine(str1);*/

            /* string str666 = "Hell string";//удаление
             str666 =str666.Remove(0, 5);
             Console.WriteLine(str666);*/

            /* int a = 5;//интерполяция
             int b = 6;
             Console.WriteLine($"Это значение - {a} а это значение - {b}");*/


            //////////////////////3//////////////////////

            /* string str1 = null;

             string str2 = "";

             string str3;

             str3 = str1 + str2;//получим пусиую строку

             Console.WriteLine( String.IsNullOrEmpty(str1));//в обоих случаях true
             Console.WriteLine(str3);*/


            /////////////////4/////////////////////


           /* StringBuilder sb = new StringBuilder("Cruel world!");
            *//* sb.Remove(0,6);//удаляет 6 символов начиная с 0
             Console.WriteLine(sb);*/
            /*
                        sb.Append("!!!!");//добавить в конец
                        Console.WriteLine(sb);*//*

            sb.Insert(0, "Hey ");
            Console.WriteLine(sb);*/
        }
    }
}
