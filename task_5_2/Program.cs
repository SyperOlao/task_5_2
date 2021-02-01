using System;
using System.Collections.Generic;

//2.Базовый класс – Человек, производные классы – Служащий, Студент. 

namespace task_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Список людей:");
            var humans = new List<Human>
            {
                new Student("Андрей Петров", 2),
                new Serviceman ("Василий Васильев", "Капрал"),
                new Student("Иван Егоров", 3)
            };
            Input(humans);
            
            foreach (var human in humans)
            {
                human.Income();
                Console.WriteLine();
                Info(human);
            }
           

        }

        public static void Input(List<Human> humans)
        {
            Random random = new Random();
            foreach (var hum in humans)
            {
                hum.Weight = random.Next(50, 160);
                if (hum is Student)
                {
                    hum.Age = (byte)random.Next(18, 25);
                   
                }
                else hum.Age = (byte)random.Next(18, 50);
            }

        }

        public static void Info(Human human)
        {
            Console.WriteLine("Имя: " + human.Name);
            Console.WriteLine("Возраст:" + human.Age);
            Console.WriteLine("Вес:" + human.Weight); 
            Console.WriteLine("Накопления:" + human.Accumulation);            
            if (human is Student) Console.WriteLine("Студент");
            if (human is Serviceman) Console.WriteLine("Служащий");
           
        }
    }
}
