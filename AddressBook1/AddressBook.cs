﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook1
{
    public class AddressBook
    {
        List<Contacts> add = new List<Contacts>();
        public void AddContact()
        {
            Contacts con = new Contacts();
            Console.WriteLine("Enter First Name");
            con.FirstName =  Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            con.LastName =  Console.ReadLine();
            Console.WriteLine("Enter Address");
            con.Address =  Console.ReadLine();
            Console.WriteLine("Enter City");
            con.City =  Console.ReadLine();
            Console.WriteLine("Enter State");
            con.State =  Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            con.ZipCode =  long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            con.Phonenumbe = long.Parse(Console.ReadLine());

            add.Add(con);
        }

        public void Display()
        {
            foreach (Contacts data in add)
            {
                Console.WriteLine("Firstname:"+data.FirstName);
                Console.WriteLine("Lastname:" + data.LastName);
                Console.WriteLine("Address:"+data.Address);
                Console.WriteLine("city:"+data.City);
                Console.WriteLine("state:"+data.State);
                Console.WriteLine("Zipcode:"+data.ZipCode);
                Console.WriteLine("PhoneNumber:"+data.Phonenumbe);

            }
        }

    }
}
