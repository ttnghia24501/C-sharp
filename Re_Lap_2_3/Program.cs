using System;
using System.Collections.Generic;

namespace ConsoleApp1.Re_Lap_2_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product(1,"san pham 1",3000,2,"anh1","mo ta sp 1", new List<string>());
            p1.AddGallery("anh 2");
            Fashion f1 = new Fashion(2,"quan ao",1500,3,"fashion1.jpg","mo ta fashion f1",new List<string>(),"red",39);
            Diamon d1 = new Diamon(3,"kim cuong 18 kara",15500,1,"kc1.jpg","kim cuong nhan tao",new List<string>(),5);
            
            Cart c1 =new Cart(1,"tran tuan nghia",0, new List<Product>(),"hanoi","vietnam");
            c1.AddProduct(p1);
            c1.AddProduct(f1);
            c1.AddProduct(d1);
            Console.WriteLine("Tong tien phai thanh toan" +c1.FinalTotal());

        }
    }
}