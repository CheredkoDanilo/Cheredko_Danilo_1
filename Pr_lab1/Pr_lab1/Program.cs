using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k,m,l = 1;
            Console.WriteLine("Введіть кількість елементів в рядку");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть кількість елементів списку");
            k = int.Parse(Console.ReadLine());
            List<int> s = new List<int>(k);
            Random ran = new Random();
            for (int i = 0; i < k; i++)
            {
                s.Add(ran.Next(100));
            }
            foreach (int i in s)
            {
                if (l < n)
                {
                    Console.Write(i + "\t");
                    l++;
                }
                else
                {
                    Console.WriteLine(i + "\t");
                    l = 1;
                }
            }
            for (int i = 1; i < (k/n); i++)
            {
                if (i % 2 != 0)
                {
                    m = i * n;
                    s.Reverse(m, n);
                }
            }
            Console.WriteLine();
            foreach (int i in s)
            {
                if (l < n)
                {
                    Console.Write(i + "\t");
                    l++;
                }
                else
                {
                    Console.WriteLine(i + "\t");
                    l = 1;
                }
            }
            Console.ReadKey();
        }
    }
}
