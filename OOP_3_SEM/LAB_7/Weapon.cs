using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    abstract class Weapon : IInfo
    {
        public abstract void Fire();

        public abstract void check_Ammo();
        
        public abstract int Damage { get; }
        public void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name} Damage: {Damage}");
        }
        public static int Count = 0;
    }
}
