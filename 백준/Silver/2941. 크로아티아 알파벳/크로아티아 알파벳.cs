using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            List<string> list = new List<string>() { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };

            string newStr = GetNewStr(str, list);
            Console.WriteLine(newStr.Count());
        }

        static private string GetNewStr(string str, List<string> list)
        {
            foreach (string listStr in list)
            {
                while (str.Contains(listStr))
                {
                    str = str.Replace(listStr, "_");
                }
            }
            return str;
        }
    }
}
