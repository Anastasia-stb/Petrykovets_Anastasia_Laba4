using System;

namespace Oop4
{
    abstract class Animals
    {
         public int age;
         public string Sound;
         public string speed;
         public void Property(string Sound, string speed)
         {
            this.Sound = Sound;
            this.speed=speed;

         }
    }
    class bird : Animals
    {
        public bird() { age = 2; }
        public static void Height()
        {
            Console.WriteLine("Найбiльша висота польту птаха дорiвнює 2000 метрiв!");
        }
    }
    class owl : Animals
    {
        public owl() { age = 4; }
       
    }
    class dog : Animals
    {
       
        public dog() { age = 10; }
         
    }
   

    class Program
    {
        static void Main()
        {
            bird pigeon = new bird();
            pigeon.Property("Кар! Кар! Кар!", "90 км за год");
            owl wiseowl = new owl();
            wiseowl.Property("Пугу! Пугу! Пугу!", "80 км за год");
            dog barsyk = new dog();
            barsyk.Property("Гав! Гав! Гав!", "12 км за год");

            Console.WriteLine("Звук якої тварини Ви хочете почути?");
            string s = Console.ReadLine();
            if (s == "птах")
            {
                Console.WriteLine(pigeon.Sound);
                
            }
            else if (s=="сова")
            {
                Console.WriteLine(wiseowl.Sound);
            }
            else if (s == "собака")
            {
                Console.WriteLine(barsyk.Sound);
            }
            else
            {
                Console.WriteLine("Звукiв такої тварини не знайдено!");
            }

            bird.Height();

            Console.WriteLine("Швидкiсть польоту птаха дорiвнює " + pigeon.speed);
            Console.WriteLine("Швидкiсть польоту сови дорiвнює " + wiseowl.speed);
            Console.WriteLine("Швидкiсть бiгу собаки дорiвнює " + barsyk.speed);
            Console.ReadKey();
        }
    }
}
