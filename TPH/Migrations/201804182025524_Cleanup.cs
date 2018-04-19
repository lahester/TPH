namespace TPH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cleanup : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.CartItems", name: "Product_id", newName: "Pr_id");
            RenameIndex(table: "dbo.CartItems", name: "IX_Product_id", newName: "IX_Pr_id");
            AddColumn("dbo.CartItems", "quantityOrdered", c => c.Int(nullable: false));
            DropColumn("dbo.CartItems", "name");
            DropColumn("dbo.CartItems", "quantityInStock");
            DropColumn("dbo.CartItems", "price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CartItems", "price", c => c.Double(nullable: false));
            AddColumn("dbo.CartItems", "quantityInStock", c => c.Int(nullable: false));
            AddColumn("dbo.CartItems", "name", c => c.String());
            DropColumn("dbo.CartItems", "quantityOrdered");
            RenameIndex(table: "dbo.CartItems", name: "IX_Pr_id", newName: "IX_Product_id");
            RenameColumn(table: "dbo.CartItems", name: "Pr_id", newName: "Product_id");
        }
    }
}
