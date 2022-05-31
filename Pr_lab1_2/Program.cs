using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace Pr_lab1_22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            Dictionary<string, int> s = new Dictionary<string, int>();
            
            s.Add("sdf", 12);
            s.Add("adf", 32);
            s.Add("wdf", 22);
            foreach (KeyValuePair<string, int> i in s)
            {
                l.Add(i.Key);
                Console.WriteLine(i.Key);
            }
            l.Sort();
            Console.WriteLine();
            foreach (string i in l)
            {
                Console.WriteLine(i);
            }
            string json = JsonConvert.SerializeObject(s);
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
