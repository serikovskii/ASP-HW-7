namespace WebApplication11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "CreationDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "CreationDate", c => c.DateTime());
        }
    }
}
