using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.checked_и_unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            int Foo1()
            {
                
                checked
                {
                    int a = 2147483647;
                    
                    return a;
                }
               
            }

            int Foo2()
            {
                
                unchecked
                {
                    int a = 2147483647;
                   
                    return a;
                }
            
              
            }

            Console.WriteLine(Foo1());
           // Console.WriteLine(Foo2());
        }
    }
}
