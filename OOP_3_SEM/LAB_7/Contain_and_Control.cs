using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Contain
    {
      // public Weapon[] weapon = { new Bow(), new Gun(), new AssaultRifle() };
        public List<Weapon> WeaponList = new List<Weapon>()  { };
        public enum PossibleArmament
        {
            Flatline,
            Vingman,
            p2020,
            G_7,
            Bocek,
            R301,
            R99
        }

       //public object ItemList = new List<string>() { "FirstItem", "SecondItem", "ThirdItem", "FourthItem"};
        public List<string> ItemList = new List<string>() { "FirstItem", "SecondItem", "ThirdItem", "FourthItem" };

    }
    class Control : Contain    
    {

        public void AddObject(Weapon objectWeapon)
        {
            WeaponList.Add(objectWeapon);
        }


        public void AddItem(string str)
        {
            ItemList.Add(str);
        }

        public void RemoveItem(string str)
        {
            ItemList.Remove(str);
        }

        public void ShowItemList()
        {
            foreach (var item in ItemList)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();
        }

        public void PrintContainer()
        {
            foreach (var item in WeaponList)
            {
                Console.WriteLine(item);
            }
            
        }
        public void AmmoCount()
        {
            Console.WriteLine($"\nОбщее колличество затраченных боеприпасов: {Weapon.Count}");
        }
        public void ShowWeaponCount()
        {
            Console.WriteLine($"\n\nОбщее колличество имеющихся орудий: {WeaponList.Count}");
        }
        public void ShowPossibleGuns()
        {
            PossibleArmament possibleArmament;
            Console.WriteLine();
            Console.WriteLine("Возможное вооружение:");
            for (int i = 0; i < 7; i++)
            {
                possibleArmament = (PossibleArmament)i;
                Console.Write(possibleArmament + "\t");
            }
        }


    }
}
