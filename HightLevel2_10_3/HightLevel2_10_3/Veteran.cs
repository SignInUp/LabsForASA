using System;

namespace HightLevel2_10_3
{
    public class Veteran : Human
    {
        public Veteran(int age, int experience, string name) 
            : base(age, experience, name) { }
        public override bool Shot()
        {
            var rnd = new Random();
            return rnd.Next(0, 101) < 70 - Age;
        }
        public override string GetMyExpType() => "ветеран";
    }
}