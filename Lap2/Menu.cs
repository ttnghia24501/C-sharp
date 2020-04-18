using System;
using System.Collections.Generic;

namespace ConsoleApp1.Lap2
{
    public static class Menu
    {
        public static void ShowInfo()
        {
            
        }
       static void Gallery()
        {
            string[] ga = new string[10];
            ga[0] = "img1";
            ga[1] = "img2";
        
            ga[9] = "img10";
            List<string> list = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}