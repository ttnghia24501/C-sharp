using System;

namespace ConsoleApp1.Lap2
{
    public class Run
    {
        public static void Main(string[] args)
        {
            
            Fashion f = new Fashion();
            f.getInfo();
            f.Noti();
            f.Check();
            Diamon d = new Diamon();
            d.Check();
        }
    }
}