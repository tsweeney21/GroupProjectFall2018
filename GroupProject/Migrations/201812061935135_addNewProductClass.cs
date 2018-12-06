namespace GroupProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addNewProductClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewProducts",
                c => new
                    {
                        newID = c.Int(nullable: false, identity: true),
                        newProdName = c.String(),
                        newProdDescription = c.String(),
                        newProdPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        newProdPicture = c.String(),
                    })
                .PrimaryKey(t => t.newID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewProducts");
        }
    }
}
