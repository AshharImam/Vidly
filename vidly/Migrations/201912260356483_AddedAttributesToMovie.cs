namespace vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAttributesToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "InStock", c => c.Byte(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "InStock");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
