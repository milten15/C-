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
            // 1.3.8.1 + 1.3.8.2
            /*Создайте переменную типа string в которую пользователь вводит пароль, далее проверьте пароль на правильность, 
             * и если пароль неверный, то попросите его ввести пароль ещё раз. Если пароль подошёл, выведите секретное сообщение. 
             * 
             * 1.3.8.1.2
             * Сделайте счётчик неверных вводов пароля, и при достижение числа 5, завершите программу. 
             */

            // И можно было бы сделать через цикл for (int i = 0, i <= 5, i++) , а внутрь поместить проверку на соответствие пароля

            String pass = "qwerty";
            bool isCorrect = false;
            int count = 0;
            while (!isCorrect)
            {
                Console.WriteLine("Введите пароль");
                String userPassword = Console.ReadLine();

                if (userPassword == pass)
                {
                  Console.WriteLine("Секретное сообщение");
                  isCorrect = true;
                }
                else
                {
                    count++;
                    if (count == 5)
                    {
                        Console.WriteLine("Введено 5 попыток ввода, завершение работы");
                        break;
                    }
                    
                }
            }
        }

    }

}
