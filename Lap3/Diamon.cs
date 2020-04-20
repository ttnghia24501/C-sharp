using System;

namespace ConsoleApp1.Lap2
{
    public class Diamon:Product
    {
        public override void Noti()
        {
            Console.WriteLine("Con hang");
        }

        public void Check()
        {
            if(cara > 5)
            {
                Console.WriteLine("Real");
            }
            else
            {
                Console.WriteLine("Fake");
            }
        }

        protected int cara = 6;
    }
}