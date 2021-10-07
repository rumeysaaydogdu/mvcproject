namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_contactdate_up : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContactDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Contacts", "ContacTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "ContacTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Contacts", "ContactDate");
        }
    }
}
