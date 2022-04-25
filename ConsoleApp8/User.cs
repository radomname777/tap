using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace User
{

    class Users : Human.Human
    {
        
        //private int number;
        public int FileId()
        {
            string[] text = File.ReadAllLines("file.txt");
            for (int i = 0; i < text.Length; i++)
            {
                Users[]? admin = JsonSerializer.Deserialize<Users[]>(text[i]);
                foreach (var item2 in admin)
                {
                    if (text.Length-1==i)
                    {
                        Console.WriteLine("Burda");
                        return item2.ID+=1;
                    }
                }
            }
            return 1;
        }

        public Users(){}
        public Users(int id, string email, string name, string passsword) : base(id, email,name,passsword) {}
        public void IDSel()
        {
            string[] text = File.ReadAllLines("admin.txt");
            foreach (var item in text)
            {
                Users[]? user = JsonSerializer.Deserialize<Users[]>(item);
                foreach (var item2 in user)
                {
                    Console.WriteLine($"\t{item2.ID}");
                }
            }
        }
        public int SignIn()
        {
            Console.Write("Enter Name: "); var Name = Console.ReadLine();
            string[] text = File.ReadAllLines("admin.txt");
            for (int i = 0; i < text.Length; i++)
            {
                Users[]? admin = JsonSerializer.Deserialize<Users[]>(text[i]);
                foreach (var item2 in admin)
                {
                    if (item2.Name == Name)
                    {
                        Console.Write("Enter password"); var password = Console.ReadLine();
                        if (item2.Password == password) return i;
                        return -1;
                    }
                    else if (admin == null) return -1;
                    else continue;
                }
            }
            return -1;
        }
        public void SignUp()
        {
            Console.Write("Enter Name: ");Name = Console.ReadLine();
            Console.Write("Enter password: "); Password = Console.ReadLine();
            Console.Write("Enter Email: "); Email = Console.ReadLine();
            ID = FileId();
            Users[] user = {
                new Users( this.ID,this.Name,this.Email,this.Email)
            };
            var json = JsonSerializer.Serialize(user);
            File.AppendAllText("file.txt", json + '\n');

        }
        public int AdminID()
        {
            IDSel();
            Console.Write("Enter ID: "); int id = Convert.ToInt32(Console.ReadLine());
            string[] text = File.ReadAllLines("admin.txt");
            for (int i = 0; i < text.Length; i++)
            {
                Users[]? admin = JsonSerializer.Deserialize<Users[]>(text[i]);
                foreach (var item2 in admin)
                {
                    if (item2.ID == id) return i;
                    else if (admin == null) return -1;
                    else continue;
                }
            }
            return -1;
        }
        public void select()
        {
            Console.WriteLine("1)sign in\n2)sign up");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1) SignIn();
            else SignUp();
        }
        public void start()
        {
            int num = AdminID();
            Admin.Admin a = new Admin.Admin();
            a.change("admin.txt", "copyfile.txt", num);
        }
    }
}
