using System;
using System.Text.Json;

namespace MyApp 
{
    class Users
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        Users(int id,string name,string email,string password)
        {
            Id = id;Name = name;Email = email;Password = password;
        }
        Users() { }

    }

   class User : Users
   {
 

   }
    internal class Program
    {

        static void Main(string[] args)
        {
            User[] username = { 
                new User{ Name = "Nihad",password="Nihad1368"}
            };
            var json = JsonSerializer.Serialize(username);
            File.WriteAllText("file.txt", json);
            var text = File.ReadAllText("file.txt");
            User[]? user = JsonSerializer.Deserialize<User[]>(text);
            foreach (User item in user)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.password);
            }
        }
    }
}