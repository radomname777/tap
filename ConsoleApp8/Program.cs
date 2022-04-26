using System;
using User;
using System.Text.Json;
namespace MyApp 
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1) Admin 2)User");
                var select = Convert.ToInt32(Console.ReadLine());
                if (select == 2)
                {
                    
                    Users user = new Users();
                    user.select();
                }
                else if (select == 1) { Admin.Admin admin = new Admin.Admin();
                    admin.select();
                }
                else continue;
            }
            //Users anmes = new Users();
            //anmes.select();
            //anms.copyfile("file.txt", "copyfile.txt");
            //Admin.Admin[] admin = {
            //    new Admin.Admin( 2,"Nicat","a.gmail.com","Nicat1369")
            //};
            //var json = JsonSerializer.Serialize(admin);
            //File.AppendAllText("admin.txt", json + '\n');
            //string[] text = File.ReadAllLines("file.txt");
            //foreach (var item in text)
            //{
            //    Users []?user = JsonSerializer.Deserialize<Users[]>(item);
            //    foreach (var item2 in user)
            //    {
            //        if (item2.Name == "Nihad")
            //        {
            //            Console.WriteLine("Tapildi");
            //        }
            //        else continue;
            //    }
            //}

        }
    }
}