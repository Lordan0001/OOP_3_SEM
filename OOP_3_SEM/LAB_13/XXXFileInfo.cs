using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_OOP
{
    public static class XXXFileInfo
    {
        private const string path = @"C:\Users\User\Desktop\универ\БГТУ\2 Курс\ООП\2 курс\All Lab\LAB_13\Path.txt";
        private static FileInfo fi;

        static XXXFileInfo() => fi = new FileInfo(path);

        public static string GetPath() => "Dir name " + fi.DirectoryName + '\n';

        public static string GetFileInfo()
        {
            string res = "";
            res += "Space " + fi.Length + '\n';
            res += "Extension " + fi.Extension + '\n';
            res += "Name " + fi.Name + "\n\n";
            return res;
        }

        public static string GetTimeCreation() => "Time creation " + fi.CreationTime.ToString() + "\n\n";
    }
}