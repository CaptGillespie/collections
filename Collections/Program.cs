using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object>stuff = new List<object>();
            int sum = 0;
            stuff.Add(7); 
            stuff.Add(28);
            stuff.Add(-1);
            stuff.Add(true);
            stuff.Add("chair");
            foreach (object things in stuff)
            {
                Console.WriteLine(things);
                if (things is int)
                {
                    sum += (int)things;
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}