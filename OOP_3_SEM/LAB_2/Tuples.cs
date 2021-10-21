using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////1////////////////
            /* (int, string, char, string, ulong) tuple = (111, "Vlad", 'A', "Second", 312423);*/

            /////////////////2////////////////
            /*  (int, string, char, string, ulong) tuple = (111, "Vlad", 'A', "Second", 312423);
              Console.WriteLine(tuple);
              Console.WriteLine(tuple.Item1 +"\t"+ tuple.Item3 + "\t" + tuple.Item4);*/

            /////////////////3///////////////
            /* (int, string, char, string, ulong) tuple = (111, "Vlad", 'A', "Second", 312423);
             var a = tuple;
             Console.WriteLine(a);*/


            ////////////4/////////////////

            /*var t1 = (A: 5, B: 10);
            var t2 = (B: 5, A: 10);
            Console.WriteLine(t1 == t2);  
            Console.WriteLine(t1 != t2); 
*/
        }
    }
}
