using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5._1
{
    class Gun : Weapon
    {
        public override string ToString()
        {
            return $"Class = {typeof(AssaultRifle).Name}, Type = {description}";

        }
        private string description = "Glock-17";
        public override void Fire()
        {
            Console.WriteLine("BANG!");
            ammoValue++;
        }
        public override int Damage
        {
            get { return 25; }
        }
        public string ToString(Weapon weapon)
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
            if (ammoValue % 2 !=0 )
            {
                Console.WriteLine("Заряжаю 2 патрона");
                
            }
           
        }
    }
}
