using System;

namespace LAB_4
{
    class Array
    {
        public int[] arr = new int[100];
        public string str;
        public int Value { get; set; }
        public Owner owner;
        public Array() { }
        public Array(int ownerId, string ownerName, string ownerCompany)
        {
            this.owner = new Owner(ownerId, ownerName, ownerCompany);
        }

        // ***********Методы***********
        public void Data(params int[] ArrayData)
        {
            this.arr = ArrayData;
            
        }
        public void PrintArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void PrintValue()
        {
            Console.WriteLine(Value);
        }



        // **************Перегрузка**************

        public static Array operator -(Array a1, Array a2) {

            return new Array { Value = a1.Value - a2.Value };
        }

        public static bool operator >(Array a1, Array a2)
        {

            return  a1.Value > a2.Value;
        }
        public static bool operator <(Array a1, Array a2)
        {

            return a1.Value < a2.Value;
        }

       


        public static bool operator ==(Array Array1,Array Array2)
        {
            if (Array1.arr.Length != Array2.arr.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Array1.arr.Length; i++)
                {
                    if (Array1.arr[i] != Array2.arr[i])
                    {
                        return false;
                    }
                    
                }
                return true;
            }
            
        }
        public static bool operator !=(Array Array1, Array Array2)
        {
            if (Array1.arr.Length != Array2.arr.Length)
            {
                return true;
            }
            else
            {
                for (int i = 0; i < Array1.arr.Length; i++)
                {
                    if (Array1.arr[i] == Array2.arr[i])
                    {
                        return false;
                    }

                }
                return true;
            }

        }

        public static Array operator +(Array object1, Array object2)
        {
            Array newArray = new Array();
            newArray.Data(12, 213, 123, 12, 12, 12);//рандомные значения, чтобы массив определили свою длинну
            if (object1.arr.Length != object2.arr.Length)
            {
                Console.WriteLine("Массивы не равны, сложить не получится!");
                return null;
            }

            for (int i = 0; i < object1.arr.Length; i++)
            {
                newArray.arr[i] = object1.arr[i] + object2.arr[i];
            }
            Console.WriteLine( newArray.arr.Length);

            return newArray;
        }

    }
}
