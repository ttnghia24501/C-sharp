using System;

namespace ConsoleApp1.Assignment3
{
    public abstract class  Cart
    {
        protected static int id;
        protected static string customer;
        protected static string city;
        protected static string country;
        public abstract void addProduct();

        public virtual void removeProduct()
        {
            
        }

        public virtual void productList()
        {
            
        }

        public virtual void calulation()
        {
            
        }
        
    }
}