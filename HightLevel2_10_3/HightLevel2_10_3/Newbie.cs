using System;

namespace HightLevel2_10_3
{
    public class Newbie : Human
    {
        public Newbie(int age, int experience, string name) 
            : base(age, experience, name) { }
        public override bool Shot()
        {
            var rnd = new Random();
            return rnd.Next(0, 101) < Experience;
        }
        public override string GetMyExpType() => "новичок";
    }
}