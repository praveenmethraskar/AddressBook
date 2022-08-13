using System;

namespace AddressBook1
{
    public class Program
    {
        public static void Main(String[] args)
        {
            AddressBook add = new AddressBook();

            while (true)
            {
                Console.WriteLine("1-add,2-display,3-Edit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add.AddContact();
                        break;
                    case 2:
                        add.Display();
                        break;
                    case 3:
                        add.EditContact();
                        break;
                    case 4:
                        Console.WriteLine("Enter name to delete record");
                        string name = Console.ReadLine();
                        add.DeleteContact(name);
                        break;

                }
            }
        }
    }
}