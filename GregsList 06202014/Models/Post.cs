using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GregsList06202014.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int CategoryId { get; set; }

        public Post(string title, string body, int categoryId)
        {
            Id = Singleton.PostIdCounter;
            Singleton.PostIdCounter += 1;
            Title = title;
            Body = body;
            CategoryId = categoryId;
        }

    }
}