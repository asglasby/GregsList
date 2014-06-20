using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GregsList06202014.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
            Id = Singleton.CategoryIdCounter;
            Singleton.CategoryIdCounter += 1;
        }
    }
}