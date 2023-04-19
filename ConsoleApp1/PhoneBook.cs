using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    public class PhoneBook : Phone
    {
        private List<string[]> PhoneList = new List<string[]>();
        public PhoneBook()
        {

        }
        public override void InsertPhone(string name, string phone)
        {
            bool found = false;
            foreach (string[] item in PhoneList)
            {
                if (item[0] == name)
                {
                    found = true;
                    if (item[1] != phone)
                    {
                        item[1] = phone;
                        Console.WriteLine("Updated phone number for {0}.", name);
                    }
                    else
                    {
                        Console.WriteLine("{0} already has this phone number.", name);
                    }
                    break;
                }
            }
            if (!found)
            {
                string[] newPhone = new string[] { name, phone };
                PhoneList.Add(newPhone);
                Console.WriteLine("Added {0} with phone number {1}.", name, phone);
            }


        }
        public override void RemovePhone(string name)
        {
            int removed = PhoneList.RemoveAll(item => item[0] == name);
            if (removed > 0)
            {
                Console.WriteLine("Removed {0} from phone book", name);
            }
            else
            {
                Console.WriteLine("{0} not found in phone book ", name);
            }

        }
        public override void UpdatePhone(string name, string newphone)
        {
            bool found = false;
            foreach (string[] item in PhoneList)
            {
                if (item[0] == name)
                {
                    item[1] = newphone;
                    found = true;
                    Console.WriteLine("Updated phone number for {0}.", name);
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("{0} not found in phone book.", name);
            }

        }
        public override void SearchPhone(string name)
        {
            bool found = false;
            foreach (string[] item in PhoneList)
            {
                if (item[0] == name)
                {
                    Console.WriteLine("{0}'s phone number is {1}.", name, item[1]);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("{0} not found in phone book.", name);
            }   
        }
        public override void Sort()
        {
            PhoneList.Sort((x, y) => string.Compare(x[0], y[0]));
            Console.WriteLine("Phone book sorted.");
        }
    }
    }
}
