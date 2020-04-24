using System;
using System.Collections.Generic;

namespace ConsoleApp1.Assignment_5
{
    public class PhoneBook:Phone
    {
        protected List<string> PhoneList;

        public PhoneBook(List<string> phoneList)
        {
            PhoneList = phoneList;
        }

        public PhoneBook()
        {
            throw new NotImplementedException();
        }

        public override bool insertPhone(string name, string phone)
        {
            if (name == null)
            {
                PhoneList.Add(name);
                PhoneList.Add(phone);
                return true;
            }
            else if(phone == null)
            {
                PhoneList.Add(phone);
            }

            return false;
        }

        public override bool removePhone(string name)
        {
            return PhoneList.Remove(name);
        }

    



    }
}