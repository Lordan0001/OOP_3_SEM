using System;
using System.Collections.Generic;
using System.IO;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {



                test1<MyClass> test = new test1<MyClass>();
                MyClass myClass = new MyClass();
                myClass.name = 5;
                test.xe = myClass;
                Console.WriteLine(test.xe);

                CollectionType<char> collection = new CollectionType<char>(CollectionType<char>.GetFromFile());

                collection.Show();
                collection.Add('!');
                collection.Save();
                collection.ShowOut();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Файл не открылся!");
            }
            finally
            {
                Console.WriteLine("\nI'm finaly");
            }
        }
    }
    interface IStand<T>
    {
        public void Add(T element)
        { }
        public void Delete(T element)
        { }
        public void Show()
        { }
    }
    class CollectionType<T> : IStand<T> where T : new()
    {
        private List<T> _list;
        CollectionType()
        {
            _list = new List<T>();
        }
        public CollectionType(params T[] args) : this()
        {
            _list.AddRange(args);
        }
        public CollectionType(IEnumerable<T> mas) : this()
        {
            _list.AddRange(mas);
        }

        public void Save()
        {
            string filee = @"C:\Users\User\Desktop\универ\БГТУ\2 Курс\ООП\2 курс\All Lab\LAB_8\out.txt";
            string buf = null;
            using (StreamWriter ex = new StreamWriter(filee))
            {

                foreach (T el in this._list)
                {
                    buf += Convert.ToString(el);
                }


                ex.WriteLine(buf);
            }
        }
        public void ShowOut()
        {
            Console.WriteLine("Стало:");
            string [] lines = File.ReadAllLines(@"C:\Users\User\Desktop\универ\БГТУ\2 Курс\ООП\2 курс\All Lab\LAB_8\out.txt");
            
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }
        }
        public static string GetFromFile()
        {

            string[] lines = File.ReadAllLines(@"C:\Users\User\Desktop\универ\БГТУ\2 Курс\ООП\2 курс\All Lab\LAB_8\in.txt");
            string buf = null;

            for (int i = 0; i < lines.Length; i++)
            {
                buf += lines[i];
            }
            return buf;
            //this._list.Add((T)buf);
        }
        public void Add(T element)
        {
            if (Convert.ToInt16(element) != 0)
            {
                _list.Add(element);
            }
        }
        public void Show()
        {
            Console.WriteLine("Было:");
            foreach (T element in this._list)
            {
                Console.Write(element);
            }
            Console.WriteLine("\n");
        }
        public void Delete(T deleteEl)
        {
            _list.Remove(deleteEl);
        }
    }
    class MyClass
    {
        public int name { get; set; }
        //public string surname { get; set; }
    }

    class test1<MyClass>
    {

        public MyClass xe;
        public test1()
        {

        }
        public void Show()
        {
            Console.WriteLine(xe);
        }
    }
    class Person<T> where T : MyClass
    {
        public T name;
    }
}
