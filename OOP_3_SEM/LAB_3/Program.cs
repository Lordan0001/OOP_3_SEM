using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane[] airplane = new Airplane[3];


            airplane[0] = new Airplane("Minsk", "SU - 132", 121, "12:00", DayOfWeek.Monday);
            airplane[1] = new Airplane("Brest", "SU - 112", 101, "19:00", DayOfWeek.Friday);
            airplane[2] = new Airplane("Mogilev", "BU - 32", 99, "22:00", DayOfWeek.Sunday);

            for (int i = 0; i < airplane.Length; i++)
            {
                airplane[i].Print();
            }

           /* airplane1.Print();
            airplane2.Print();
            airplane3.Print();
*/

            // Console.WriteLine(airplane1.ID);
            var airplane4 = new {S = "Mogilev", M = "BU - 32",T = 99, A = "22:00", DayOfWeek.Sunday };
            Console.WriteLine(airplane4);
            Console.WriteLine(Airplane.Object_Count);

            int Out_value;
            Funct_Out(out Out_value);
            int Ref_value = 999;
            Funct_Ref(ref Ref_value);
        }
        static void Funct_Out(out int x)
        {
            x = 11;
        }
        static void Funct_Ref(ref int x)
        {
            x = 2331;
        }


        

    }
   
    partial class Airplane
    {
        Random rnd = new Random();
        public void Print()
        {
            Console.WriteLine($"Время вылета: {Time}\nДень вылета: {Day}\nМесто приземления: {Place}\nНомер самолёта: {Plane_number }\nТип Самолета: {Plane_Type}\n");

        }
        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
