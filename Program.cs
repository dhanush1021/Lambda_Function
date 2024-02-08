using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);
            List<int> list2 = list.FindAll(x => x%2 == 0);
            int num = list2.Find(x => x > 6);
            Console.WriteLine(num);
            foreach (int x in list2)
                Console.WriteLine(x);
        }
    }
}