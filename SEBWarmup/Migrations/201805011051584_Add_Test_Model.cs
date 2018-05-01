namespace SEBWarmup.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Test_Model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SEBTests",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SEBTests");
        }
    }
}
