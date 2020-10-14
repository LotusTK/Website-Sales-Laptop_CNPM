namespace FinalTerm_CNPM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finaltermdb_v5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartProducts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        amount = c.Int(nullable: false),
                        cartId = c.Int(nullable: false),
                        productId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Carts", t => t.cartId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.productId, cascadeDelete: true)
                .Index(t => t.cartId)
                .Index(t => t.productId);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        totalProduct = c.Int(nullable: false),
                        state = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        totalPrice = c.Int(nullable: false),
                        userId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.OrderProducts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        amount = c.Int(nullable: false),
                        orderId = c.Int(nullable: false),
                        productId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Orders", t => t.orderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.productId, cascadeDelete: true)
                .Index(t => t.orderId)
                .Index(t => t.productId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        state = c.Int(nullable: false),
                        price = c.Int(nullable: false),
                        primaryType = c.String(nullable: false, maxLength: 10),
                        img = c.String(maxLength: 500),
                        laptopId = c.Int(),
                        cpuId = c.Int(),
                        ramId = c.Int(),
                        storageId = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cpus", t => t.cpuId)
                .ForeignKey("dbo.Laptops", t => t.laptopId)
                .ForeignKey("dbo.Rams", t => t.ramId)
                .ForeignKey("dbo.Storages", t => t.storageId)
                .Index(t => t.laptopId)
                .Index(t => t.cpuId)
                .Index(t => t.ramId)
                .Index(t => t.storageId);
            
            CreateTable(
                "dbo.Cpus",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nameCpu = c.String(nullable: false, maxLength: 100),
                        typeCpu = c.String(nullable: false, maxLength: 10),
                        detailCpu = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Laptops",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nameLaptop = c.String(nullable: false, maxLength: 100),
                        displaySize = c.String(nullable: false, maxLength: 10),
                        weightLaptop = c.Int(nullable: false),
                        detailLaptop = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Rams",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nameRam = c.String(nullable: false, maxLength: 100),
                        typeRam = c.String(nullable: false, maxLength: 50),
                        sizeRam = c.Int(nullable: false),
                        unitSizeRam = c.String(nullable: false, maxLength: 10),
                        detailRam = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nameStorage = c.String(nullable: false, maxLength: 100),
                        typeStorage = c.String(nullable: false, maxLength: 50),
                        sizeStorage = c.Int(nullable: false),
                        unitSizeStorage = c.String(nullable: false, maxLength: 10),
                        detailStorage = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "userId", "dbo.Users");
            DropForeignKey("dbo.Products", "storageId", "dbo.Storages");
            DropForeignKey("dbo.Products", "ramId", "dbo.Rams");
            DropForeignKey("dbo.OrderProducts", "productId", "dbo.Products");
            DropForeignKey("dbo.Products", "laptopId", "dbo.Laptops");
            DropForeignKey("dbo.Products", "cpuId", "dbo.Cpus");
            DropForeignKey("dbo.CartProducts", "productId", "dbo.Products");
            DropForeignKey("dbo.OrderProducts", "orderId", "dbo.Orders");
            DropForeignKey("dbo.Carts", "userId", "dbo.Users");
            DropForeignKey("dbo.CartProducts", "cartId", "dbo.Carts");
            DropIndex("dbo.Products", new[] { "storageId" });
            DropIndex("dbo.Products", new[] { "ramId" });
            DropIndex("dbo.Products", new[] { "cpuId" });
            DropIndex("dbo.Products", new[] { "laptopId" });
            DropIndex("dbo.OrderProducts", new[] { "productId" });
            DropIndex("dbo.OrderProducts", new[] { "orderId" });
            DropIndex("dbo.Orders", new[] { "userId" });
            DropIndex("dbo.Carts", new[] { "userId" });
            DropIndex("dbo.CartProducts", new[] { "productId" });
            DropIndex("dbo.CartProducts", new[] { "cartId" });
            DropTable("dbo.Storages");
            DropTable("dbo.Rams");
            DropTable("dbo.Laptops");
            DropTable("dbo.Cpus");
            DropTable("dbo.Products");
            DropTable("dbo.OrderProducts");
            DropTable("dbo.Orders");
            DropTable("dbo.Carts");
            DropTable("dbo.CartProducts");
        }
    }
}
