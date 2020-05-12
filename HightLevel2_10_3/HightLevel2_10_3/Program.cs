using System;

namespace HightLevel2_10_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int countHumans = 7;
            Human[] humans = new Human[countHumans];
            Human.FillInSevenHumans(humans);
            foreach (var human in humans)
            {
                Console.WriteLine($"И так.. стреляет {human.Name}!, он(она) {human.GetMyExpType()}");
                Console.WriteLine($"Ему(ей) лет: {human.Age}");
                Console.WriteLine($"Также, она(он) {human.Experience} годиков в спорте!");
                if (human.Shot())
                {
                    Console.WriteLine("Попал(а)!");
                    break;
                }
                Console.WriteLine("Промахнулся(лась)!");
            }

            Console.ReadLine();
        }
    }
}