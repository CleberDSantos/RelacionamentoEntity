using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ConsoleApplication3.Model
{
    public class Contexto : DbContext 
    {
        public Contexto()
            : base ("Contexto")
        {
            
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

           //modelBuilder.Properties<DateTime>().Configure(x => x.HasColumnType("datetime2"));

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Estado> Estados { get; set; }

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<ClienteEndereco> ClienteEnderecos { get; set; }

        public DbSet<Estudante> Estudantes { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<EstudanteCurso> EstudantesCursos { get; set; }

    }
}
