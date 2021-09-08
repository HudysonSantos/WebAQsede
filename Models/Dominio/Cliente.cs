using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAQsede.Models.Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public int CPF { get; set; }
        public String DataNascimento { get; set; }
        public String email { get; set; }
        public int CEP { get; set; }
        public String Cidade { get; set; }
        public String Endereco { get; set; }
        public int Telefone { get; set; }
    }
}
