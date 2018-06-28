namespace Muli_Pariwar_Lagat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PDFremovedMuli : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pdfs", "MuliId", "dbo.Mulis");
            DropIndex("dbo.Pdfs", new[] { "MuliId" });
            DropColumn("dbo.Pdfs", "MuliId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pdfs", "MuliId", c => c.Int(nullable: false));
            CreateIndex("dbo.Pdfs", "MuliId");
            AddForeignKey("dbo.Pdfs", "MuliId", "dbo.Mulis", "Id", cascadeDelete: true);
        }
    }
}
