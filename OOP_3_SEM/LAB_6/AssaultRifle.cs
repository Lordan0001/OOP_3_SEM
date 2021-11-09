using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5._1
{
    class AssaultRifle : Weapon
    {
        public override string  ToString()
        {
            return $"Class = {typeof(AssaultRifle).Name}, Type = {description}";

        }

        
        private string description = "M-16";
        public override void Fire()
        {
            Console.WriteLine("RATATA!");
            ammoValue++;
            Count++;
        }
        public override int Damage
        {
            get { return 155; }
        }
        public  string ToString(Weapon weapon)
        {
            return weapon.Damage.ToString();
        }
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
