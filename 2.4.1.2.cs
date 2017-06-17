using System;


namespace IMJunior
{
    class Program
    {
        //2.4.1.2
        /*На основе предыдущего задания, сделайте запись ответа пользователя. 
        В конце анкеты, выведите сообщение о том, что он принят в орден, если пользователь 
        “Человек, который хочет найти боевых товарищей, и который является отличным воином”
        */
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Совершенно очевидно, что мы не берём в наш орден кого попало. По этому заполни вот эту анкету, и мы примем решение, брать тебя или нет");
            
            string inOrden = "";

            MyClass[] obj = new MyClass[3]
            {
                new MyClass("Кто вы?", new string[] {"Человек", "Брандлмуха", "Кхаджит"}), 
                new MyClass("Что вы хотите?", new string[] {"Победить Аразота", "Стать богатым", "Найти боевых товарищей"}), 
                new MyClass("Чем вы можете помочь ордену?", new string[] {"Я отлчиный воин", "Я добротный маг", "Я могу работать в кузнице"}), 

            };
            foreach (var variable in obj)
            {
                Console.WriteLine(variable.question);
                for (int i = 0; i < obj.Length; i++)
                {
                    Console.WriteLine("[{0}]>{1}", i, variable.answer[i]);
                    variable.isDoorOpen = true;
                }
                inOrden += Console.ReadLine();
                if (inOrden == "0" + "2" + "0")
                {
                    Console.WriteLine("Ты принят красавчик!");
                }            
             }         
        }
    }

        
 }
    class MyClass
    {
        public string question;
        public string[] answer;
        public bool isDoorOpen;

        public MyClass(string question, string[] answer)
        {
           this.question = question;
           this.answer = answer;
        }
    }
