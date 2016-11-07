namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionamentonn : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EstudanteCursoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EstudanteId = c.Int(nullable: false),
                        CursoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cursoes", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.Estudantes", t => t.EstudanteId, cascadeDelete: true)
                .Index(t => t.EstudanteId)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.Estudantes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EstudanteCursoes", "EstudanteId", "dbo.Estudantes");
            DropForeignKey("dbo.EstudanteCursoes", "CursoId", "dbo.Cursoes");
            DropIndex("dbo.EstudanteCursoes", new[] { "CursoId" });
            DropIndex("dbo.EstudanteCursoes", new[] { "EstudanteId" });
            DropTable("dbo.Estudantes");
            DropTable("dbo.EstudanteCursoes");
            DropTable("dbo.Cursoes");
        }
    }
}
