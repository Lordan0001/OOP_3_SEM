using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    partial class Gun : Weapon
    {
        public override string ToString()
        {
            return $"Class = {typeof(Gun).Name}, Type = {description}";

        }
        private string description = "Glock-17";
        public override void Fire()
        {
            Console.WriteLine("BANG!");
            ammoValue++;
            Count++;
        }
        public override int Damage
        {
            get { return 25; }
        }
        public string ToString(Weapon weapon)
        {
            return weapon.Damage.ToString();
        }
       
           
        
    }
}
