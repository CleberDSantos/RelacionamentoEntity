namespace ConsoleApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remocaopluraltabelas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Cidades", newName: "Cidade");
            RenameTable(name: "dbo.ClienteEnderecoes", newName: "ClienteEndereco");
            RenameTable(name: "dbo.Clientes", newName: "Cliente");
            RenameTable(name: "dbo.Cursoes", newName: "Curso");
            RenameTable(name: "dbo.EstudanteCursoes", newName: "EstudanteCurso");
            RenameTable(name: "dbo.Estudantes", newName: "Estudante");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Estudante", newName: "Estudantes");
            RenameTable(name: "dbo.EstudanteCurso", newName: "EstudanteCursoes");
            RenameTable(name: "dbo.Curso", newName: "Cursoes");
            RenameTable(name: "dbo.Cliente", newName: "Clientes");
            RenameTable(name: "dbo.ClienteEndereco", newName: "ClienteEnderecoes");
            RenameTable(name: "dbo.Cidade", newName: "Cidades");
        }
    }
}
