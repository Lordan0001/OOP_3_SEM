using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_5._1
{
    class Player
    {
        public void Fire (Weapon weaponObject)
        {
            if (weaponObject is Weapon point)//проверка и присоение
            {
                point.Fire();
            }
           
        }
        public void CheckInfo(IInfo IInfoObject)
        {
            IInfoObject.ShowInfo();

        }
    }

    sealed class newPlayer
    {
        public void Fire(Weapon weaponObject)
        {
            weaponObject.Fire();
        }
    }
}
