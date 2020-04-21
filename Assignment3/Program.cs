using System;

namespace ConsoleApp1.Assignment3
{
    public abstract class Program : Cart
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nhap id: ");
            id = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Nhap customer: ");
            customer =Console.ReadLine();
            
            Console.WriteLine("Nhap city: ");
            city = Console.ReadLine();
            
            Console.WriteLine("Nhap country: ");
            country = Console.ReadLine();
            
            Console.WriteLine("id: " +id, "customer" +customer, "city" +city, "country" + country);
            
            
            Total a = new Total();
            a.addProduct();
            Console.ReadKey();
        }
    }
}