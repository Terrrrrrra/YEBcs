using System;
using System.Collections.Generic;

namespace TestProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("철수");
            names.Add("영희");
            names.Add("민수");
            names.Add("맹구");
            names.Add("짱구");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            // 철수, 영희, 민수, 맹구, 짱구
            Console.WriteLine("==========================");

            names.Remove("맹구");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            // 철수, 영희, 민수, 짱구
            Console.WriteLine("==========================");

            names.RemoveAt(1);

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            // 철수, 민수, 짱구
            Console.WriteLine("==========================");

            /*foreach (string name in names)
            {
                Console.Write(name);
            }*/
        }
    }
}
