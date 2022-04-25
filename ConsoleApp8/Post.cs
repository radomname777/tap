using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
     class Post :Human.Human
     {

        //public DateOnly CreationDateTime { get; set; }
        public int LikeCount { get; set; } = 0;
        public int ViewCount { get; set; } = 0;
        public Post()
        {
   
        }
        public Post(int id, string email, string name, string passsword) : base(id, email, name, passsword)
        {
        }
    }
}
