namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class validacoesestado : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Estado", "Nome", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Estado", "Nome", c => c.String(nullable: false));
        }
    }
}
