namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criacaotabelacidade : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEstado = c.Int(nullable: false),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estadoes", t => t.IdEstado, cascadeDelete: true)
                .Index(t => t.IdEstado);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cidades", "IdEstado", "dbo.Estadoes");
            DropIndex("dbo.Cidades", new[] { "IdEstado" });
            DropTable("dbo.Cidades");
        }
    }
}
