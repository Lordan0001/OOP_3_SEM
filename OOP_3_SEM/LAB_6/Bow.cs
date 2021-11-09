using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5._1
{
    class Bow : Weapon
    {
        public override string ToString()
        {
            return $"Class = {typeof(Bow).Name}, Type = {description}";

        }
        private string description = "two arrow elven bow";
        public override void Fire()
        {
            Console.WriteLine("VJUH!");
            ammoValue++;
            Count++;
        }
        public override int Damage
        {
            get { return 100; }
        }
        public string ToString(Weapon weapon)
        {
            return weapon.Damage.ToString();
        }
        public int ammoValue = 1;
        public override void check_Ammo()
        {
            if (ammoValue % 2 == 0)
            {
                Console.WriteLine("Можно стрелять");
              
            }
            if (ammoValue % 2 != 0)
            {
                Console.WriteLine("Накладываю 2 стрелы");
               
            }
          
        }
    }
}
