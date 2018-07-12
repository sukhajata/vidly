namespace Vidly3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerAnnotations : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1968-10-10' WHERE Id = 1");
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BirthDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
    }
}
