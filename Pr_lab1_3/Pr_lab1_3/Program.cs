using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr_lab1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>(3) {"gas", "kil", "asm" };
            var result1 = l.Select(i => i[0]).Reverse();
            foreach (char i in result1)
            {
                Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
