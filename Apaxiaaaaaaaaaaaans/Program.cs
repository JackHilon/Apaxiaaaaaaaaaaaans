using System;
using System.Collections.Generic;

namespace Apaxiaaaaaaaaaaaans
{
    class Program
    {
        static void Main(string[] args)
        {
            // Apaxiaaaaaaaaaaaans
            // https://open.kattis.com/problems/apaxiaaans 
            // simple string - char program

            var myNameCharArr = EnterName();

            var myNameList = GetNewName(myNameCharArr);

            PrintListInOneString(myNameList);
        }
        private static void PrintListInOneString(List<char> name)
        {
            string str = "";
            for (int i = 0; i < name.Count; i++)
            {
                str = str + name[i].ToString();
            }
            Console.WriteLine(str);
        }

        private static List<char> GetNewName(string name)
        {
            var nameList = new List<char>();

            nameList.Add(name[0]);

            if (name.Length == 1)
            {
                return nameList;
            }

            else
            {
                for (int i = 1; i < name.Length; i++)
                {
                    if (name[i] != name[i - 1])
                        nameList.Add(name[i]);
                }
                return nameList;
            }
        }
        private static string EnterName()
        {
            string str = "";
            try
            {
                str = Console.ReadLine();
                if (str.Length < 1 || str.Length > 250)
                    throw new ArgumentException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterName();
            }
            return str;
        }
    }
}
