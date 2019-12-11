namespace Repart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataAnotationAddedtoCustomerAndBook : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "BookName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "CustomerName", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "CustomerName", c => c.String());
            AlterColumn("dbo.Books", "BookName", c => c.String());
        }
    }
}
