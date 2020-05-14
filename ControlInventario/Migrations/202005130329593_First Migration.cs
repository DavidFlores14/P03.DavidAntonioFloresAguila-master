namespace ControlInventario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductCode", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "ProductName", c => c.String());
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Price", c => c.Single(nullable: false));
            AddColumn("dbo.Products", "SupplierId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "SupplierId");
            AddForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "SupplierCod");
            DropColumn("dbo.Products", "SupplierName");
            DropColumn("dbo.Products", "Email");
            DropColumn("dbo.Products", "Phone");
            DropColumn("dbo.Products", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Address", c => c.String());
            AddColumn("dbo.Products", "Phone", c => c.String());
            AddColumn("dbo.Products", "Email", c => c.String());
            AddColumn("dbo.Products", "SupplierName", c => c.String());
            AddColumn("dbo.Products", "SupplierCod", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Products", new[] { "SupplierId" });
            DropColumn("dbo.Products", "SupplierId");
            DropColumn("dbo.Products", "Price");
            DropColumn("dbo.Products", "Quantity");
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Products", "ProductName");
            DropColumn("dbo.Products", "ProductCode");
        }
    }
}
