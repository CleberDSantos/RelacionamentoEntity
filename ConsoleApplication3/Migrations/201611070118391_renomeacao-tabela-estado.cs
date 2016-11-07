namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renomeacaotabelaestado : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Estadoes", newName: "Estado");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Estado", newName: "Estadoes");
        }
    }
}
