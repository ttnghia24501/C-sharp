using System;

namespace ConsoleApp1.Lap2
{
    public class Fashion:Product
    {
        public override void Noti()
        {
            Console.WriteLine("Da het hang");
        }

        protected string color = "red";
        protected string size = "M";

        public void Check()
        {
            Console.WriteLine("Color"+color," Size"+size);
        }
        
    }
}