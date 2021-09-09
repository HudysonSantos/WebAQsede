using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAQsede.Models.Dominio
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int Id { get; set; }

        [StringLength(35)]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo nome do cliente é obrigatório")]
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
