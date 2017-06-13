using System;


namespace IMJunior
{
    class Program1
    {

        //1.3.9.5
        //Реализуйте любой алгоритм сортировки на свой вкус (можно сортировку пузырьком). 

        static void Main(string[] args)
        {
            int[] ar = new int[] { 11, 33, 23, 32, 7 , 1, 2, 3, 4, 5 };    
            Array.Sort(ar);
            foreach (var v in ar)
            {
                Console.WriteLine(v);
            }

        }

    }
}
