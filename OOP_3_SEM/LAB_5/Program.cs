using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Weapon[] weapon = { new Bow(), new Gun(), new AssaultRifle() };
            for (int i = 0; i < 3; i++)
            {
                foreach (var item in weapon)
                {
                    Console.WriteLine(item.ToString()); 
                    item.check_Ammo();
                    player.Fire(item);
                    player.CheckInfo(item);
                    Console.WriteLine();

                }
                Console.WriteLine("**************************************************");
             }
            Console.WriteLine("МЕТОД IAmPrinting:");
            
            Printer printer = new Printer();
            foreach (var item in weapon)
            {
                printer.IAmPrinting(item);

            }

           
           
        }
    }
}
