using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSon_Data_to_DataTable
{
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get;  set; }
        public string body { get;  set; }

        /*public Post(int userid_post, int id_post, string title_post, string body_post)
        {
            this.userId = userid_post;
            this.id = id_post;
            this.title = title_post;
            this.body = body_post;
        }*/
    }
}
