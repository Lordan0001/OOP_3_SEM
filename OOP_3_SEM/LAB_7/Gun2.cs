using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    partial class Gun : Weapon
    {
        
        private int ammoValue = 1;
        public override void check_Ammo()
        {
            if (ammoValue % 2 == 0)
            {
                Console.WriteLine("Можно стрелять");

            }
            if (ammoValue % 2 != 0)
            {
                Console.WriteLine("Заряжаю 2 патрона");

            }

        }
    }
}
