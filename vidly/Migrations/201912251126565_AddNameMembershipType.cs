namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameMembershipType : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "MembershipTypeName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MembershipTypeName", c => c.String());
        }
    }
}
