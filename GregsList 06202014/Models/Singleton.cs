using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GregsList06202014.Models
{
    public class Singleton
    {
        private static Singleton _instance;
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();
                return _instance;
            }
        }

        public static int PostIdCounter { get; set; }
        public static int CategoryIdCounter { get; set; }
        public List<Category> Categories { get; set; }
        public List<Post> Posts { get; set; }
        public Singleton()
        {
            Categories = new List<Category>();
            Posts = new List<Post>();
            PostIdCounter = 1;
            CategoryIdCounter = 1;

            Categories.Add(new Category("Jobs"));
            Categories.Add(new Category("Houses/Apartments"));

            Posts.Add(new Post("Jr Developer", "We want you. 100k+", 1));
            Posts.Add(new Post("Sr Developer", "Must be a graduate of Coder Camps. 250k+", 1));
            Posts.Add(new Post("Apartment 1/1", "Free if your awesome.", 2));
            Posts.Add(new Post("House 4/3", "150k", 2));
        }
    }
}