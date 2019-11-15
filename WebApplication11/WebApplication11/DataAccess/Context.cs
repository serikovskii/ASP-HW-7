namespace WebApplication11.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using WebApplication11.Models;

    public class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
            Database.SetInitializer(new Initilizer());
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Article> News { get; set; }
    }
}