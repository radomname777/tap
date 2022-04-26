using System;
using Admin;
using User;
using System.Text.Json;
namespace MyApp 
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Users anmes = new Users();
            anmes.select();
            //Console.WriteLine("1) Admin\n2) Username");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num==1)
            //{
                
            //}
            //else
            //anmes.copyfile("file.txt", "copyfile.txt");
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