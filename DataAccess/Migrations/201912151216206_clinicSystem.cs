namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clinicSystem : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Speciality");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Speciality", c => c.Int(nullable: false));
        }
    }
}
