using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication11.Models
{
    public class Admin : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}