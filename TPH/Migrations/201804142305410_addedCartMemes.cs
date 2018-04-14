namespace TPH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCartMemes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        quantityInStock = c.Int(nullable: false),
                        price = c.Double(nullable: false),
                        Product_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.Product_id)
                .Index(t => t.Product_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "Product_id", "dbo.Products");
            DropIndex("dbo.CartItems", new[] { "Product_id" });
            DropTable("dbo.CartItems");
        }
    }
}
