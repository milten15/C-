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
            int a;
            bool isTrue;
            string te4ka;
            string _how;
            double d;
            var a2 = true;
            var a1 = 10;
            char symb;
            float f;
            long l;
            string name = "Не статическая переменная";
            Console.WriteLine(name);
            
        }
        static string name = "Статическая переменная"; // насколько я понимаю это должно работать, из джавы помню что имя статической переменной может совпадать, но не уверен
        Console.WriteLine(name); // не смог разобраться почему он не может мне тут вывести на экран, и класс создавал все пробовал =(
    }

}
