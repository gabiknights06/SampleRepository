using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAPIConsumer
{
    public class Post
    {
        public Post()
        {
            id = 0;
            userId = 0;
            title = string.Empty;
            completed = false;
        }

        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }


    }
}
