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
                if (i==text.Length-1)
                {
                    Post[] admin2 = {new Post(admin[0].ID, admin[0].LikeCount,admin[0].ViewCount)};
                    var json2 = JsonSerializer.Serialize(admin2);
                    File.WriteAllText("Postfiel.txt", json2 + '\n');
                }
            }
        }
    }
}
