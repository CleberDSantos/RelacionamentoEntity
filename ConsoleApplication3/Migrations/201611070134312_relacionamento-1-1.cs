namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionamento11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClienteEnderecoes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Numero = c.Int(nullable: false),
                        Rua = c.String(),
                        Bairro = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClienteEnderecoes", "Id", "dbo.Clientes");
            DropIndex("dbo.ClienteEnderecoes", new[] { "Id" });
            DropTable("dbo.Clientes");
            DropTable("dbo.ClienteEnderecoes");
        }
    }
}
