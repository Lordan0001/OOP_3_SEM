using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_7
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

           
            
            Console.WriteLine();
            Console.WriteLine("Контейнер и Контроллер:");

            Contain contain = new Contain();
            Control control = new Control();
  
            control.ShowPossibleGuns();
            control.ShowWeaponCount();
            control.AmmoCount();

            MyStruct myStruct = new MyStruct();
            myStruct.StructMethod();

            control.ShowItemList();
            control.AddItem("AddedItem");
            control.ShowItemList();
            control.RemoveItem("FirstItem");
            control.ShowItemList();

            control.AddObject(new Bow());
            control.AddObject(new Gun());
            control.AddObject(new Gun());
            control.PrintContainer();

            /////Мои исключения
            Console.WriteLine();
            Console.WriteLine("********Мои Исключения**************\n");

                        string AdminName = "Admin";
                        string TempName = "NOAdmin";
                       
                        exception ex = new exception("Неверное имя пользователя");
                        try
                        {
                            if (!(AdminName == TempName))
                            {
                                throw ex;
                            }
                            if (AdminName == TempName)
                            {
                                Console.WriteLine("Имя подошло!");
                            }
                        }
                        catch (exception)
                        {
                            Console.WriteLine();
                            Console.WriteLine(ex.Error);

                        }

            PlayerError playerError = new PlayerError();
            try
            {
             
                Player player2 = new Player();
                if (!(Player.PlayerCount == 1))
                {
                    throw playerError;
                }
            }
            catch (PlayerError)
            {

                Console.WriteLine(playerError.MoreThenOne);
            }

            AssaultRifleError assaultRifleError = new AssaultRifleError();
            AssaultRifle assaultRifle2 = new AssaultRifle();
            try
            {
      
                if (!(AssaultRifle.AssaultRifleCount == 1))
                {
                    throw assaultRifleError;
                }
            }
            catch (AssaultRifleError)
            {

                Console.WriteLine(assaultRifleError.MoreThenOneAssault);
            }

           
           
            //////////// 5 стандартных ошибок
            Console.WriteLine("********Стандартные исключения**************\n");

            IndexOutofRange indexOutofRange = new IndexOutofRange();
                 try
                 {

                    for (int i = 0; i < indexOutofRange.exArr.Length + 1; i++)
                    {
                    indexOutofRange.exArr[i] = i;

                    if (indexOutofRange.exArr[i] < 0 || indexOutofRange.exArr[i] > 2)
                        {
                            throw indexOutofRange;
                        }
                    }
                for (int i = 0; i < indexOutofRange.exArr.Length; i++)
                {
                    Console.WriteLine(indexOutofRange.exArr[i]);
                }
                     
                 }
                 catch 
                 {
                Console.WriteLine();
                     Console.WriteLine(indexOutofRange.Error1);

                 }
                 finally
                 {
                     indexOutofRange.exArr[0] = 0;
                     indexOutofRange.exArr[1] = 0;
                     indexOutofRange.exArr[2] = 0;
                 }

            try
            {
                int x = 5;
                int y = x / 0;
                Console.WriteLine($"Результат: {y}");
            }
            catch
            {
                Console.WriteLine("\nДеление на ноль!");
            }

            

            try
            {
                string path = "D:\\new_file.txt";
                File.OpenRead(path);
            }
            catch (Exception)
            {

                Console.WriteLine("\nФайла нет!");
            }
            try
            {
                string foo = null;
                foo.ToUpper();

            }
            catch (Exception)
            {

                Console.WriteLine("\nСсылки нет!");
            }
            try
            {
                checked
                {
                    int a = int.MaxValue;
                    ++a;

                }
            
            }
            catch (Exception)
            {

                Console.WriteLine("Превышен размер типа данных");
            }


        }
    }
}
