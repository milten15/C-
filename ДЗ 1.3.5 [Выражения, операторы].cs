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
            int a = 10;
            bool isTrue = false;
            string te4ka = "text";
            string _how = "test";
            double d = 1.24;
            var a2 = true;
            var a1 = 10;
            char symb = 'd';
            float f = 3.14f;
            long l = 100000000000000;
            string name = "Не статическая переменная";
            Console.WriteLine(name);

            int a = 10;
            int b = 15 + 25;                        // b = 40
            int c = a * b + 8;                      // a = 408
            int d = (5 + 5) / 2;                    // d = 5
            bool b_a = true;
            bool b_b = true && false;               // false          
            bool b_c = false || true;               // true           
            bool b_d = true != false;               // true
            bool b_e = b_a == b_c;                  // true

            string s = “test” + “ “ + “test2“;      // test test2


        }
       
    }

}
