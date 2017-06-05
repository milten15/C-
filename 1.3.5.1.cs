using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = a;
            b = a++;            // b = 1
            b = a;              // b = 1
            b = ++a;            // b = 2
            b = b++;            // b = 2
            b = b++ + ++b;      // b = 6

        }

    }

}
