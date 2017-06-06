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
            // 1.3.8.2
            // Пользователь вводит сколько ему лет. Программа, с помощью цикла for, должна поздравить его с днём рождения столько раз, сколько ему лет. 

            Console.WriteLine("How old?");
            String sAge = Console.ReadLine();
            int age = Convert.ToInt32(sAge);
            for (int i = 0; i < age; i++)
            {
                Console.WriteLine("С днем рождения " + i);
            }
            
        }

    }

}
