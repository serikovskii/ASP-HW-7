using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Article : Entity
    {
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public Article()
        {
            CreationDate = DateTime.Now.ToShortTimeString();
        }
    }
}