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
        }
    }
}