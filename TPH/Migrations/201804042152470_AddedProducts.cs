namespace TPH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        color = c.String(),
                        quantityInStock = c.Int(nullable: false),
                        price = c.Double(nullable: false),
                        category = c.String(),
                        size = c.String(),
                        weight = c.String(),
                        image_URL = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
