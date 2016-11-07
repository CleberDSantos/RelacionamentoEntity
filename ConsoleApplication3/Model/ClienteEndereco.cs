using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApplication3.Model
{
    public class ClienteEndereco
    {
        [Key,ForeignKey("Cliente")]
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
