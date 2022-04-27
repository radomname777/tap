using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace Post
{
     class Post 
     {
          
        public string CreationDateTime { get; set; }
        public int Id { get; set; }
        public int LikeCount { get; set; } = 0;
        public int ViewCount { get; set; } = 0;
        public Post(){}
        public void print(int id)
        {
            string[] text = File.ReadAllLines("Postfiel.txt");
            for (int i = 0; i < text.Length; i++)
            {
                Post[]? post = JsonSerializer.Deserialize<Post[]>(text[i]);
                if (post[0].Id==id)
                {
                    Console.WriteLine($"ID: {post[0].Id}\nDate: {post[0].CreationDateTime}\nLike count: {post[0].LikeCount}\nView count: {post[0].ViewCount}");
                    Thread.Sleep(1000);
                    return;
                }
            }
        }
        public Post(int id, int likecount=0,int viewcount=0)
        {
            Id = id;
            DateTime date = DateTime.Now.Date;
            LikeCount = likecount;
            ViewCount = viewcount;
            CreationDateTime = date.ToString();
        }
        public void Postfiel()
        {
            string[] text = File.ReadAllLines("admin.txt");
            for (int i = 0; i < text.Length; i++)
            {
                Admin.Admin[]? admin = JsonSerializer.Deserialize<Admin.Admin[]>(text[i]);
                Post[] admin2 = {new Post(admin[0].ID, admin[0].LikeCount,admin[0].ViewCount)};
                var json2 = JsonSerializer.Serialize(admin2);
                File.AppendAllText("Postfiel.txt", json2 + '\n');
                
            }
        }
    }
}
