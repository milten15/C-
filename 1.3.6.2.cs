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
         
            //1.3.6.2
            //С помощью params сделать возможным передачу любого количества цифр в метод. 
            //В самом методе умножить все принятые цифры и вернуть их произведение.


            Console.WriteLine(SomeMul3(2,2,2));
            int SomeMul3(params int[] integers)
            {
                int res = 1;  // тут насколько я понимаю нужно присваивать 0 только если мы складываем числа к примеру, при умножении нужно 1 ведь умножение на 0 всегда 0 даст
                for (int i = 0; i < integers.Length; i++)
                {
                    res *= integers[i];
                }
                return res;
            }

        }

    }

}
