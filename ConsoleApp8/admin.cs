using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace Admin
{
    class Admin : Post.Post
    {

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
            Console.WriteLine("1)Like? ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num==1) return true;
            return false;
        }
        public void change(string filename, string filename2, int num)
        {
            copyfile(filename, filename2);
            File.WriteAllText(filename, "");
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
        }
        public Admin()
        {

        }
        public Admin(int id, string email, string name, string passsword) : base(id, email, name, passsword)
        {
            //post.id = id;
            //post.Likecount = 0;
            //post.ViewCount = 0;
        }
    }
}
