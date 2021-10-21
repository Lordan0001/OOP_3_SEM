using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
  
    partial class Airplane
    {
        public string Place { get; set; }
        public string Plane_Type { get; set; }
        public uint Plane_number { get; set; }
        public string Time { get; set; }
        public DayOfWeek Day { get; set; }
        public int ID { get;}

        public const int CONST_VALUE = 666;

        public static int Object_Count = 0;
        public Airplane()
        {
            Place = "NO PLace";
            Plane_Type = "NO PLane";
            Plane_number = 0;
            Time = "NO Time";
            Day = DayOfWeek.Never;
            Object_Count++;
        }
        public Airplane(string Place, string Plane_Type, uint Plane_number, string Time, DayOfWeek Day)
        {
            this.Place = Place;
            this.Plane_Type = Plane_Type;
            this.Plane_number = Plane_number;
            this.Time = Time;
            this.Day = Day;
            ID = rnd.Next(0, 1000);
            Object_Count++;
        }
        public Airplane( string Plane_Type = "C-111", uint Plane_number = 1, string Time ="19:00", DayOfWeek Day = DayOfWeek.Everyday)
        {
           
            this.Plane_Type = Plane_Type;
            this.Plane_number = Plane_number;
            this.Time = Time;
            this.Day = Day;
            ID = rnd.Next(0, 1000);
            Object_Count++;
        }
        static Airplane()
        {
            Console.WriteLine("Вот информация о вашем рейсе:\n");
        }
        private Airplane(string Error)
        {
            Place = Error;
        }

    }
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
        Never,
        Everyday

    }
}
