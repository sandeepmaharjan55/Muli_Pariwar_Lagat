namespace Muli_Pariwar_Lagat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MuliCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mulis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GharNum = c.Int(nullable: false),
                        Woda = c.Int(nullable: false),
                        sabik_G_B_S = c.String(),
                        sabik_woda = c.Int(nullable: false),
                        tol = c.String(),
                        Naam = c.String(),
                        Sikshhya = c.String(),
                        AddedDate = c.DateTime(nullable: false),
                        Kaam = c.String(),
                        JanmaMiti = c.DateTime(nullable: false),
                        JanmaSthan = c.String(),
                        NagarikId = c.Int(nullable: false),
                        NagarikJariDate = c.DateTime(nullable: false),
                        NagarikJariJilla = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mulis");
        }
    }
}
