using System;


namespace IMJunior
{
    class Program1
    {

        //1.3.9.6
        //Реализуйте метод Shuffle, который перемешивает элементы массива в случайном порядке.
         

        static void Main(string[] args)
        {
            int[] ar = new int[] { 11, 33, 23, 32, 7 , 1, 2, 3, 4, 5 };
        }

        static int[] shuffle(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Random a = new Random();
                int j = a.Next(i + 1);
                if (j != i)
                {
                    array[i] = array[j];
                    array[j] = i + 1;
                }
                
            }
            return array;
        }
        

    }
}
