namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remocaodatatimetabelas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estado", "DataCriacao", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AddColumn("dbo.Estado", "DataAlteracao", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Estado", "DataAlteracao");
            DropColumn("dbo.Estado", "DataCriacao");
        }
    }
}
