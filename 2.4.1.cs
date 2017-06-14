using System;


namespace IMJunior
{
    class Program
    {
        //2.4.1
        /*Воспользуйтесь классами и выделите типичную структуру данных.Воспользуйте массивом объектов этого класса, для того, 
         * чтобы сделать цикл и избавиться от повторяющегося кода.
         */

        static void Main(string[] args)
        {

            //string Question1 = "Кто вы?", Question2 = "Что вы хотите?", Question3 = "Чем вы можете помочь ордену?";

            //string[] questions = new string[3] { "Кто вы?", "Что вы хотите?", "Чем вы можете помочь ордену?" };
            Dialog[] dialog = new Dialog[3]
            {
                new Dialog("Кто вы?", new string[] { "Человек", "Брандлмуха", "Кхаджит" }),
                new Dialog("Что вы хотите?", new string[] { "Победить Аразота", "Стать богатым", "Найти боевых товарищей" }),
                new Dialog("Чем вы можете помочь ордену?", new string[]{ "Я отлчиный воин", "Я добротный маг", "Я могу работать в кузнице" })
            };

            Console.WriteLine("Совершенно очевидно, что мы не берём в наш орден кого попало. По этому заполни вот эту анкету, " +
                              "и мы примем решение, брать тебя или нет");
            foreach(Dialog dlg in dialog)
            {
                Console.WriteLine(dlg.question);
                for(int i = 0; i < dlg.answer.Length; i++)
                {
                    Console.WriteLine("[{0}]>{1}", i, dlg.answer[i]);
                }
                Console.ReadLine();
                dlg.isDoorOpen = true;
            }
        }
    }
    class Dialog
    {
        public bool isDoorOpen;
        public string question;
        public string[] answer;

        public Dialog(string question, string[] answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
}
