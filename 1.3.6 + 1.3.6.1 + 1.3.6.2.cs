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
            //1.3.6
            /*Объявить метод SomeMul который принимает два параметра типа int. 
             *Умножить параметры и вернуть их с помощью ключевого слова return. 
             *Вызвать метод и поместить результат его в какую-нибудь переменную. Попробовать также использовать метод в выражение. Например: 
             *SomeMul(10, 10) * 15
             */
            int result;
            result = SomeMul(32, 256);
            Console.WriteLine(SomeMul(10, 11));
            Console.WriteLine(result);

            int SomeMul(int a, int b = 10)
            {
                int c = a * b;
                return c;
            }
            //1.3.6.1
            //Сделать в SomeMul второй параметр как необязательный, и по умолчанию сделать равным 10.
            Console.WriteLine(SomeMul2(5));
            int SomeMul2(int a, int b = 10)
            {
                int c = a * b;
                return c;
            }


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
