using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap vao so nguyen n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
        }

        static void Fi(int n)
        {
            int fb = 0, fb1= 1,fb2 = 1;
            
            while (fb1+fb2 < n )
            {
                fb = fb1 + fb2;
                fb1 = fb2;
                fb2 = fb;
            }
            Console.Write("so can tim la : {0} ",fb);
        }
    }
}