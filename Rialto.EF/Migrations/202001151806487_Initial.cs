namespace Rialto.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bet",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumberOfLots = c.Int(nullable: false),
                        DateOfCreation = c.DateTime(nullable: false),
                        Lot_ID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lot", t => t.Lot_ID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.User_ID, cascadeDelete: true)
                .Index(t => t.Lot_ID)
                .Index(t => t.User_ID);
            
            CreateTable(
                "dbo.Lot",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LotDynamic",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateOfChange = c.DateTime(nullable: false),
                        Delta = c.Double(nullable: false),
                        Lot_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lot", t => t.Lot_ID, cascadeDelete: true)
                .Index(t => t.Lot_ID);
            
            CreateTable(
                "dbo.User",
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
                        Lot_ID = c.Int(nullable: false),
                        User_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lot", t => t.Lot_ID, cascadeDelete: true)
                .ForeignKey("dbo.User", t => t.User_ID, cascadeDelete: true)
                .Index(t => t.Lot_ID)
                .Index(t => t.User_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Futures", "User_ID", "dbo.User");
            DropForeignKey("dbo.Futures", "Lot_ID", "dbo.Lot");
            DropForeignKey("dbo.Bet", "User_ID", "dbo.User");
            DropForeignKey("dbo.Bet", "Lot_ID", "dbo.Lot");
            DropForeignKey("dbo.LotDynamic", "Lot_ID", "dbo.Lot");
            DropIndex("dbo.Futures", new[] { "User_ID" });
            DropIndex("dbo.Futures", new[] { "Lot_ID" });
            DropIndex("dbo.LotDynamic", new[] { "Lot_ID" });
            DropIndex("dbo.Bet", new[] { "User_ID" });
            DropIndex("dbo.Bet", new[] { "Lot_ID" });
            DropTable("dbo.Futures");
            DropTable("dbo.User");
            DropTable("dbo.LotDynamic");
            DropTable("dbo.Lot");
            DropTable("dbo.Bet");
        }
    }
}
