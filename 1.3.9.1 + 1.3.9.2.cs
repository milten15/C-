using System;


namespace IMJunior
{
    class Program
    {
        // 1.3.9.1
        /*Объявить переменную которая хранит массив тип элементов у которого string 
         * и поместить туда ссылку на новый массив с типом элементов string размерностью в 5 элементов. 
         * Далее, через оператор индексации проинициализировать каждый элемент. 
         */
        static void Main(string[] args)
        {
            string[] strArr = new string[5];
            strArr[0] = "Вася";
            strArr[1] = "Петя";
            strArr[2] = "Ииигорь";
            strArr[3] = "Игнат";
            strArr[4] = "Изя";


        //1.3.9.2
        //Получить строку от пользователя, разбить её с помощью метода Split 
        //на массив по сепаратору пробел, и потом вывести каждый элемент массива.

            string someString = Console.ReadLine();
            string[] split = someString.Split(' ');
            foreach(string s in split)
            {
               Console.WriteLine(s);               
            }

        }



    }
}
