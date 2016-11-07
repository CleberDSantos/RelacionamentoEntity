using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication3.Model
{
    [Table("Estado")]
    public class Estado
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo nome é obrigatório")]
        [StringLength(255)]
        [MinLength(20)]
        public string Nome { get; set; }

        [NotMapped]
        public string NomeComId { get; set; }

        public virtual ICollection<Cidade> Cidades { get; set; }

       
    }
}
