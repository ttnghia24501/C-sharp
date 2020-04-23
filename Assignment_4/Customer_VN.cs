using System;

namespace ConsoleApp1.Assignment_4
{
    public class Customer_VN
    {
        private int id;
        private string name;
        private string date;
        private string constructor;
        protected int qty;
        private int bill;
        private int limitVN;

        public Customer_VN(int id, string name, string date, string constructor, int qty, int bill, int limitVN)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.constructor = constructor;
            this.qty = qty;
            this.bill = bill;
            this.limitVN = limitVN;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Date
        {
            get => date;
            set => date = value;
        }

        public string Constructor
        {
            get => constructor;
            set => constructor = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public int Bill
        {
            get => bill;
            set => bill = value;
        }

        public int Limit
        {
            get { return bill;}
            set
            {
                if (qty < 50) bill = 1000;
                if (50 < qty && qty < 100) bill = 1200;
                if (100 < qty && qty < 200) bill = 1500;
                if (qty > 200) bill = 2000;
            }
        }
        public double Calulator(double money)
        {
            if (qty <= limitVN)
            {
                money = qty * bill;
            }
            else if(qty >= limitVN)
            {
                money = bill * limitVN + (qty - limitVN);
            }
            return money;
        }

        public double Total()
        {
            double money = 0;
            money += Calulator(money);
            return money;
        }
        // public double Sum(double sum)
        // {
        //     sum = Money()
        // }
    }
}