namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KeyWords",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        keyWord = c.String(),
                        response = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.MemoryOfChats",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        message = c.String(),
                        date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MemoryOfChats");
            DropTable("dbo.KeyWords");
        }
    }
}
