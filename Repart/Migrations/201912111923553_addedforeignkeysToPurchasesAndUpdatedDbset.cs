namespace Repart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedforeignkeysToPurchasesAndUpdatedDbset : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        BuyersNameId = c.Int(nullable: false),
                        DatePurchased = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.BuyersNameId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.BuyersNameId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "BuyersNameId", "dbo.Customers");
            DropForeignKey("dbo.Purchases", "BookId", "dbo.Books");
            DropIndex("dbo.Purchases", new[] { "BuyersNameId" });
            DropIndex("dbo.Purchases", new[] { "BookId" });
            DropTable("dbo.Purchases");
        }
    }
}
