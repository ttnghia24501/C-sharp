using System;

namespace ConsoleApp1.Assignment_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Customer_VN cn = new Customer_VN(1,"tran tuan nghia","2020/04/23","sinh hoat",70,1200,50-100);
            Customer_Foreign cf = new Customer_Foreign(2, "gie","2020/04/23","foreign",70,2000,100-2000,"american");

            cn.Total();
            Console.WriteLine("Tong so tien phai thanh toan la " + cn.Total());
        }
    }
}