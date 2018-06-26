namespace Muli_Pariwar_Lagat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MuliModelEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mulis", "ContactNum", c => c.String());
            AlterColumn("dbo.Mulis", "NagarikJariJilla", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mulis", "NagarikJariJilla", c => c.DateTime(nullable: false));
            DropColumn("dbo.Mulis", "ContactNum");
        }
    }
}
