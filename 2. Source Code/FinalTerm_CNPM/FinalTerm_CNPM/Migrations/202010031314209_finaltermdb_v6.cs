namespace FinalTerm_CNPM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finaltermdb_v6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rams", "busRam", c => c.String(maxLength: 50));
            AlterColumn("dbo.Cpus", "typeCpu", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Laptops", "weightLaptop", c => c.Double(nullable: false));
            DropColumn("dbo.Rams", "detailRam");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rams", "detailRam", c => c.String(maxLength: 500));
            AlterColumn("dbo.Laptops", "weightLaptop", c => c.Int(nullable: false));
            AlterColumn("dbo.Cpus", "typeCpu", c => c.String(nullable: false, maxLength: 10));
            DropColumn("dbo.Rams", "busRam");
        }
    }
}
