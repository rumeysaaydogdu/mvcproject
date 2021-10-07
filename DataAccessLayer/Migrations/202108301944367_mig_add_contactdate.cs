﻿namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_contactdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "ContacTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "ContacTime");
        }
    }
}
