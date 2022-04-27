using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace Human
{
    class Human
    {
        public int ID { get; set; }
        private string _gmail;
        public string  Email
        {
            get => _gmail;
            set
            {
                while (true)
                {
                    if (value.Contains('@')) break;
                    else
                    {
                        Console.WriteLine("Enter Email: ");
                        value = Console.ReadLine();
                        continue;
                    }
                }
                _gmail = value;
            }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set
               {
                if (value.Length < 3)
                {
                    while (value.Length < 3)
                    {
                        Console.WriteLine("Enter name (<=3): ");
                        value = Console.ReadLine();
                        Console.Clear();
                    }

                }
                _name = value;
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                while (value.Length <= 6)
                {
                    Console.WriteLine("Enter Password (<= 6): ");
                    value = Console.ReadLine();
                    Console.Clear();
                }
                _password = value;
            }
        }

        public Human() {}
        public Human(int id,string email,string name ,string passsword)
        {
            ID = id;
            Name= name;
            Email = email;
            Password = passsword;
        }
    }

}
