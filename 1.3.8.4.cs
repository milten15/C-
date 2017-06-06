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
            // 1.3.8.4
            /* С помощью циклов организуйте обработку команд. В программе должны следующие команды:
               -SetName(устанавливает имя)
               -DisplayName(запрашивает число, и выводит столько раз имя)
               -SetColor(установка цвета фона консоли и символов)
               -DisplayBoxWithName(отображение полого квадрата из символов ‘#’ с надписью имени внутри)
           */

            Console.WriteLine("1. SetName - Установить имя");
            Console.WriteLine("2. DisplayName - Вывести имя n -кол-во раз");
            Console.WriteLine("3. SetColor - Установить цвет фона");
            Console.WriteLine("4. DisplayBoxWithName - Отображение полого квадрата из символов #");

            string name = "";
            string command = "";
            while (command != "exit")
            {
                command = Console.ReadLine();
                if(command == "SetName")
                {
                    Console.WriteLine("Введите имя");
                    name = Console.ReadLine();
                }
                else if (command == "DisplayName")
                {
                    Console.WriteLine("Введите число n для отображения имени n раз");
                    int count = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(name);
                    }
                }
                else if (command == "SetColor")
                {
                    Console.WriteLine("Задайте цвет фона и символов \n SetFon - для изменения цвета фона \n SetSymbol - для изменения цвета символов \n Для выхода из раздела SetColor напиши colorexit \n Здорово Правда?");
                    string color = "";
                    while(color != "colorexit")
                    {
                        
                        color = Console.ReadLine();
                        if(color == "SetFon")
                        {
                            Console.WriteLine("Укажите цвет фона(blue, red, green)");
                            color = Console.ReadLine();
                            if(color == "red")
                            {
                            Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                            }
                            else if (color == "green")
                            {
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                            }
                            else if (color == "blue")
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.Clear();
                            }
                        }
                        else if (color == "SetSymbol")
                        {
                            Console.WriteLine("Укажите цвет символов(blue, red, darkgreen) \n для выхода из режима выбора напишите colorsymbexit");
                            string colorSymb = "";
                            while (colorSymb != "colorsymbexit")
                            {
                                colorSymb = Console.ReadLine();
                                if(colorSymb == "blue")
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Clear();
                                }
                                else if (colorSymb == "red")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Clear();
                                }
                                else if (colorSymb == "darkgreen")
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Clear();
                                }
                            }
                        }
                    }

                }
                else if (command == "DisplayBoxWithName")
                {
                    Console.Clear();
                    string square = "";
                    for(int i = 0; i < name.Length + 2; i++)
                    {
                        square += "#";
                    }
                    Console.WriteLine(square);
                    Console.WriteLine("#" + name + "#");
                    Console.WriteLine(square);
                }
            }


        }

    }

}
