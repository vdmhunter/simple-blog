namespace SimpleBlog.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Posts_001 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Text", c => c.String(nullable: false, storeType: "ntext"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Text", c => c.String(storeType: "ntext"));
        }
    }
}
