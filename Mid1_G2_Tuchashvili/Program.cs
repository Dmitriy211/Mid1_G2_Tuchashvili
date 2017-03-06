using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if ((int.Parse(args[i]) % 1000 == 0) && (int.Parse(args[i]) % 15 != 0))
                    Console.WriteLine(args[i]);
            }
        }
    }
}
