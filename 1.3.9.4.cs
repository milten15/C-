using System;
using System.Collections.Generic;

namespace IMJunior
{
    class Program1
    {

        //1.3.9.4
        /*Сделайте 3 метода: 
         * Удаление элемента из массива.
         * Добавление элемента в массив. 
         * Перенос одного массива в другой. 
         */

        static void Main(string[] args)
        {
            int[] ar = new int[5] { 1, 2, 3, 4, 5 };
            removeElement(ar, 1);
            addElement(ar, 44);
            transfer(ar);
            Console.WriteLine(ar[1]);

        }
        static int[] removeElement(int[] arr, int id)
        // копируем массив в List, удаляем элемент и переобразуем обратно в массив и возвращаем
        {
            var tmp = new List<int>(arr);
            tmp.Remove(id);
            tmp.CopyTo(arr);
            return arr;
        }
        static int[] addElement(int[] arr, int a)  //добавление элемента
        {
            var temp = new List<int>();
            temp.Add(a);
            temp.CopyTo(arr);
            return arr;
        }
        static int[] transfer(int[] arr)  //перенос массива
        {
            int[] copyArray = (int[])arr.Clone();
            return copyArray;
        }
    }
}
