using System;

namespace HightLevel2_10_3
{
    public class Experienced : Human
    {
        public Experienced(int age, int experience, string name) 
            : base(age, experience, name) { }
        public override bool Shot()
        {
            var rnd = new Random();
            return rnd.Next(0, 101) < Experience * 5;
        }
        public override string GetMyExpType() => "имеет некоторый опыт";
    }
}