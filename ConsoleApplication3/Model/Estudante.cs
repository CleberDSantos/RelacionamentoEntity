using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApplication3.Model
{
    public class Estudante
    {
        public int Id { get; set; }
        public int Nome { get; set; }

        public virtual ICollection<EstudanteCurso> EstudantesCursos { get; set; }
    }

    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<EstudanteCurso> EstudantesCursos { get; set; }
    }

    public class EstudanteCurso
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Estudante")]
        public int EstudanteId { get; set; }
        [ForeignKey("Curso")]
        public int CursoId { get; set; }

        public virtual Estudante Estudante { get; set; }
        public virtual Curso Curso { get; set; }

    }

}
