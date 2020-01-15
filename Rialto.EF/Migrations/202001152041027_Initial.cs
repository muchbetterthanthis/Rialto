namespace Rialto.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumberOfLots = c.Int(nullable: false),
                        DateOfCreation = c.DateTime(nullable: false),
                        Lot_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lots", t => t.Lot_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Lot_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Lots",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LotDynamics",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateOfChange = c.DateTime(nullable: false),
                        Delta = c.Double(nullable: false),
                        Lot_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lots", t => t.Lot_ID)
                .Index(t => t.Lot_ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Futures",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumberOfLots = c.Int(nullable: false),
                        DateOfCreation = c.DateTime(nullable: false),
                        DateOfSelling = c.DateTime(nullable: false),
                        Lot_ID = c.Int(),
                        User_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lots", t => t.Lot_ID)
                .ForeignKey("dbo.Users", t => t.User_ID)
                .Index(t => t.Lot_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Futures", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Futures", "Lot_ID", "dbo.Lots");
            DropForeignKey("dbo.Bets", "User_ID", "dbo.Users");
            DropForeignKey("dbo.Bets", "Lot_ID", "dbo.Lots");
            DropForeignKey("dbo.LotDynamics", "Lot_ID", "dbo.Lots");
            DropIndex("dbo.Futures", new[] { "User_ID" });
            DropIndex("dbo.Futures", new[] { "Lot_ID" });
            DropIndex("dbo.LotDynamics", new[] { "Lot_ID" });
            DropIndex("dbo.Bets", new[] { "User_ID" });
            DropIndex("dbo.Bets", new[] { "Lot_ID" });
            DropTable("dbo.Futures");
            DropTable("dbo.Users");
            DropTable("dbo.LotDynamics");
            DropTable("dbo.Lots");
            DropTable("dbo.Bets");
        }
    }
}
