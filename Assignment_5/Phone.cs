﻿namespace ConsoleApp1.Assignment_5
{
    public abstract class Phone
    {
        public abstract void insertPhone(string name, string phone);
        public abstract void removePhone(string name);
        public abstract bool updatePhone(string name, string newphone);
        public abstract void searchPhone(string name);
        
    }
}