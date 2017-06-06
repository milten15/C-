using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Сделать метод DrawPyramid который принимает 1 параметр типа int size.
    //Результатом этого метода должна быть отрисованная в консоли пирамида размером size.

        // аналогичная задача была на javarush, принцип помнил, остальное пришлость гуглить, так как синтаксис не очень знаю ещё.
    class Pyramyd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер пирамиды");
            int size = Convert.ToInt32(Console.ReadLine());
            DrawPyramid(size);
        }
        static void DrawPyramid(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int a = Math.Min(size - i, size - j);
                    int b = Math.Min(i + 1, j + 1);
                    Console.Write(Math.Min(a, b));
                }
                Console.WriteLine();
            }
           
        }

    }

}
