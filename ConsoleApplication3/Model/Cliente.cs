using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual ClienteEndereco ClienteEndereco { get; set; }
    }
}
