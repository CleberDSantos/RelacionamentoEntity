using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApplication3.Model
{
    public class Cidade
    {
        public int Id { get; set; }

        [ForeignKey("Estado")]
        public int IdEstado { get; set; }

        public string Nome { get; set; }

        public virtual Estado Estado { get; set; }
    }
}
