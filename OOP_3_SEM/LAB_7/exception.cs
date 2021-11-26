using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class exception : Exception
    {
       public string Error;
        public exception(string Error)
        {
            this.Error = Error;
        }
    }
    class IndexOutofRange : Exception
    {
       public int[] exArr = new int[3];
        public string Error1 = "Выход за границу массива";
     
    }
    class PlayerError : Exception
    {
        public string MoreThenOne = "\nУ нас одиночная игра!";
    }

    class AssaultRifleError : Exception
    {
        public string MoreThenOneAssault = "\nДолжна быть только одна винтовка!";
    }
}
