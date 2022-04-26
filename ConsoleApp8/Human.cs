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
        public string? Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Human() { }
        public Human(int id,string email,string name ,string passsword)
        {
            ID = id;
            Name= name;
            Email = email;
            Password = passsword;
        }
        //public int FileName(string filename)
        //{
        //    Console.Write("Enter Name: "); var name = Console.ReadLine();
        //    string[] text = File.ReadAllLines(filename);
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        Human[]? user = JsonSerializer.Deserialize<Human[]>(text[i]);
        //        if (user == null) return -1;
        //        foreach (var item2 in user)
        //        {
        //            if (item2.Name == name)
        //            {
        //                Console.Write("Enter password: "); var password = Console.ReadLine();
        //                if (item2.Password == password)
        //                {
        //                    Console.WriteLine("Tapildi");
        //                    return i;
        //                }
        //                else return -1;
        //            }
        //            else continue;
        //        }
        //    }
        //    return -1;
        //}
    }

}
