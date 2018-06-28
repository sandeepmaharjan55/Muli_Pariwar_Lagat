namespace Muli_Pariwar_Lagat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PDF : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pdfs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        status = c.Boolean(nullable: false),
                        MuliId = c.Int(nullable: false),
                        File = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Mulis", t => t.MuliId, cascadeDelete: true)
                .Index(t => t.MuliId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pdfs", "MuliId", "dbo.Mulis");
            DropIndex("dbo.Pdfs", new[] { "MuliId" });
            DropTable("dbo.Pdfs");
        }
    }
}
