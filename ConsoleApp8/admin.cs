using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace Admin
{
    class Admin : Human.Human
    {
        public int LikeCount { get; set; } = 0;
        public int ViewCount { get; set; } = 0;
        Post.Post post = new Post.Post();
        private void copyfile(string filename, string filename2)
        {
            File.WriteAllText(filename2, "");
            string[] text = File.ReadAllLines(filename);
            foreach (var line in text)
            {
                Admin[]? user = JsonSerializer.Deserialize<Admin[]>(line);
                var json = JsonSerializer.Serialize(user);
                File.AppendAllText(filename2, json + '\n');
            }
        }
        private bool likepost()
        {
            Console.WriteLine("1)Like ?");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num==1) return true;
            return false;
        }
        private void Printpost(int id) => post.print(id);
        private int FileId()
        {
            string[] text = File.ReadAllLines("admin.txt");
            for (int i = 0; i < text.Length; i++)
            {
                Admin[]? admin = JsonSerializer.Deserialize<Admin[]>(text[i]);
                foreach (var item2 in admin)
                {
                    if (text.Length - 1 == i) return item2.ID += 1;
                }
            }
            return 1;
        }
        private void Postfile()
        {
            File.WriteAllText("Postfiel.txt", "");
            post.Postfiel(); return;
        }
        public int SignIn()
        {
            Console.Write("Enter Name: "); var Name = Console.ReadLine();
            string[] text = File.ReadAllLines("admin.txt");
            for (int i = 0; i < text.Length; i++)
            {
                Admin[]? admin = JsonSerializer.Deserialize<Admin[]>(text[i]);
                foreach (var item2 in admin)
                {
                    Console.WriteLine(item2.Name);
                    if (item2.Name == Name)
                    {
                        Console.WriteLine(item2.Password);
                        Console.Write("Enter password: "); var password = Console.ReadLine();
                        if (item2.Password == password)
                        {
                            Console.WriteLine("Welcome");
                            Printpost(item2.ID);
                            return i;
                        }
                        Console.WriteLine("No Admin!");
                        return -1;
                    }
                    else if (admin == null) return -1;
                    else continue;
                }
            }
            return -1;
        }
        public void select()
        {
            do
            {
                Console.WriteLine("1)sign in\n2)sign up");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1) { SignIn(); break; }
                else if (num == 2) { SignUp(); break; }
                else continue;
            } while (true);
        }
        public void SignUp()
        {
            Console.Write("Enter Name: "); Name = Console.ReadLine();
            Console.Write("Enter password: "); Password = Console.ReadLine();
            Console.Write("Enter Email: "); Email = Console.ReadLine();
            ID = FileId();
            Admin[] user = {
                new Admin( this.ID,this.Email,this.Name,this.Password)
            };
            var json = JsonSerializer.Serialize(user);
            Console.WriteLine("aa");
            File.AppendAllText("admin.txt", json + '\n');
            Postfile();
        }
        public void change(string filename, string filename2, int num)
        {
            copyfile(filename, filename2);
            File.WriteAllText(filename,"");
            string[] text = File.ReadAllLines(filename2);
            for (int i = 0; i < text.Length; i++)
            {
                Admin[]? user = JsonSerializer.Deserialize<Admin[]>(text[i]);
                if (i == num)
                {
                    if (likepost()) user[0].LikeCount++;
                    user[0].ViewCount++;
                }
                var json = JsonSerializer.Serialize(user);
                File.AppendAllText(filename, json + '\n');
            }
            Postfile();
        }
        public Admin()
        {

        }
        public Admin(int id, string email, string name, string passsword) : base(id, email, name, passsword)
        {

        }
    }
}
