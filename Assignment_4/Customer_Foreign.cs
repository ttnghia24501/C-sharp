using System;
using System.Data.SqlTypes;

namespace ConsoleApp1.Assignment_4
{
    public class Customer_Foreign:Customer_VN
    {
        protected string national;
        
        public Customer_Foreign(int id, string name, string date, string constructor, int qty, int bill, int limitVN, string national)
            : base(id, name, date, constructor, qty, bill, limitVN)
        {
            this.national = national;

        }

        public string National
        {
            get => national;
            set => national = value;
        }

        public double Money(double money)
        {
            money = qty * 2000;
            return money;
        }

        // public double Averange(double avg)
        // {
        //     avg = .....
        // }
    }
}