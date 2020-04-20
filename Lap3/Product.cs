using System;
using System.Collections.Generic;

namespace ConsoleApp1.Lap2
{
    public abstract class Product
    {
        protected int id ;
        protected string name = "book";
        protected int price = 50000;
        protected int qty = 10;

        public virtual void getInfo()
        {
            Console.WriteLine("ID"+id," Name"+name," Price"+price," QTY"+qty);
        }

        public abstract void Noti();

        public void Add()
        {
            
        }

        public void Remove()
        {
            
        }
    }
}