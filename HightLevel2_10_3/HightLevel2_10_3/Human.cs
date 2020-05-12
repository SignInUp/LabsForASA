using System;

namespace HightLevel2_10_3
{
    public abstract class Human
    {
        public int Age { get; }
        public int Experience { get; }
        public string Name { get; }
        protected Human(int age, int experience, string name)
        {
            Age = age;
            Experience = experience;
            Name = name;
        }

        public abstract bool Shot();
        public abstract string GetMyExpType();
        public static void FillInSevenHumans(Human[] humans)
        {
            var rnd = new Random();
            humans[0] = new Newbie(rnd.Next(20, 31), rnd.Next(0, 10), "Джорно Джованна");
            humans[1] = new Newbie(rnd.Next(20, 31), rnd.Next(0, 10), "Бруно Буччарати");
            humans[2] = new Experienced(rnd.Next(30, 51), rnd.Next(10, 20), "Леоне Аббаккьо");
            humans[3] = new Veteran(rnd.Next(50, 81), rnd.Next(30, 40 ), "Гвидо Миста");
            humans[4] = new Experienced(rnd.Next(30, 51), rnd.Next(10, 20), "Наранча Гирга");
            humans[5] = new Newbie(rnd.Next(10, 31), rnd.Next(0, 10), "Паннакотта Фуго");
            humans[6] = new Newbie(rnd.Next(10, 31), rnd.Next(0, 10), "Трис Уна");
        }
    }
}




















