﻿using System;
using System.Collections.Generic;
using System.Xml;

namespace ConsoleApp1.Re_Lap_2_3
{
    public class Product
    {
        protected int id;
        protected string name;
        protected double price;
        protected uint qty;
        protected string image;
        protected string desc;
        protected List<string> gallery;
        
        public Product()
        {
            this.gallery = new List<string>();
        }

        public Product(int id, string name,double price, uint qty, string image, string desc, List<string> gallery)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public int Id // khai bao 1 properties
        {
            get { return id; }
            //set { this.id = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public double Price
        {
            get { return price; }
            set { this.price = value; }
        }

        public uint Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public void GetInfo()
        {
            Console.WriteLine("ID: "+ this.id+ "Name: "+name+"Qty :"+qty);
        }

        public bool CheckStock()
        {
            if (qty > 0) return true;
            return false;
        }

        public bool AddGallery(string image)
        {
            if (gallery.Count >= 10)
            {
                Console.WriteLine("anh da vuot qua so luong, can xoa bot truoc khi them");
                return false;
            }

            gallery.Add(image);
            return true;
        }

        public void DeleteGallery()
        {
            Console.WriteLine("danh sach in anh: ");
            for (int i=0; i< gallery.Count;i++)
            {
                Console.WriteLine((i+1)+"."+gallery[i]);
            }
            Console.WriteLine("chon anh de xoa: ");
            int stt = Convert.ToInt32(Console.ReadLine());
            gallery.RemoveAt(stt);
        }

        public bool DeleteImage(string image)
        {
            return gallery.Remove(image);
        }

        public bool DeleteAt(int number)
        {
            if (number <= gallery.Count && number >= 0)
            {
                gallery.RemoveAt(number);
                return true;
            }

            return false;
        }
    }
}