using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class User : Admin
    {
        public string CreationDate { get; set; }
        public string PhoneNumber { get; set; }

        public User()
        {
            CreationDate = DateTime.Now.ToShortTimeString();
        }
    }
}