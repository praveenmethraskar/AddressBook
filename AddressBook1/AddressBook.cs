using System;
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
            con.Phonenumber = long.Parse(Console.ReadLine());

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
                Console.WriteLine("PhoneNumber:"+data.Phonenumber);

            }
        }

        public void EditContact()
        {
            Console.WriteLine("To Edit contacts list enter contact firstname");

            string name = Console.ReadLine().ToLower();
            foreach(var data in add)
            {
                if(add.Contains(data))
                {
                    Console.WriteLine("To edit contacts enter 1.Lastname\n2.address\n3.city\n4.state\n5.zip code\n6.phone number\n");
                    int options = Convert.ToInt32(Console.ReadLine);
                    switch(options)
                    {
                        case 1:
                            string lastname = Console.ReadLine();
                            data.LastName = lastname;
                            break;
                        case 2:
                            string address = Console.ReadLine();
                            data.Address = address;
                            break;
                        case 3:
                            string city = Console.ReadLine();
                            data.City = city;
                            break;
                        case 4:
                            string state = Console.ReadLine();
                            data.State = state;
                            break;
                        case 5:
                            long zipCode = long.Parse(Console.ReadLine());
                            data.ZipCode = zipCode;
                            break;
                        case 6:
                            long phonenumber = long.Parse(Console.ReadLine());
                            data.Phonenumber = phonenumber;
                            break;
                        default:
                            Console.WriteLine("Enter valid option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Name Doesn't matches");
                }
            }
        }

        public void DeleteContact(string personName)
        {
            for (int i = 0; i < add.Count; i++)
            {
                if (add[i].FirstName == personName)
                {
                    Console.WriteLine("Record {0} succesfully deleted", add[i].FirstName);
                    add.RemoveAt(i);

                }
            }
        }

    }
}
