using System;


namespace IMJunior
{
    class Program
    {

        //1.3.9.3.1
        //Что выведится в консоль? 

        static void Main(string[] args)
        {

            int a = 10, b = 15, c = 0;
            SomeMul(a, b, c);

            char[] map = new char[15];      
            map[2] = 'T';      
             GenerateMap(map);      

            Console.WriteLine(c);
            Console.WriteLine(map[2]);



        }
            static void GenerateMap(char[] map)
            {
                for (int i = 0; i < map.Length; i++)
                {
                    map[i] = 'P';
                }
            }
             static void SomeMul(int a, int b, int c)
            {
                 c = a * b; 
            }

        // Отобразится 0, так как метод void и не возвращает значение, поэтому С так и остаётся 0 при выводе на экран. 
        // Отобразится символ Р, так как в цикле как я понял он перезаписывает весь массив этим символом, затирая нашу Т изначально. От 0 до 14 все теперь Р
    }
}
