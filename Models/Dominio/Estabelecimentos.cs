using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAQsede.Models.Dominio
{
    [Table("Estabelecimentos")]
    public class Estabelecimentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int Id { get; set; }

        [StringLength(35, ErrorMessage = "Não aceita Nome com mais de 35 dígitos")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo nome do estabelecimento é obrigatório")]
        public String Nome { get; set; }

        [StringLength(18, ErrorMessage = "Não aceita CNPJ com mais de 18 dígitos")]
        [DisplayName("CNPJ")]
        [Required(ErrorMessage = "Campo CPF do estabelecimento é obrigatório")]
        [Remote("ValidarCNPJ", "Estabelecimento", ErrorMessage = "CNPJ Inválido!!!")]
        public String CNPJ { get; set; }

        [StringLength(35, ErrorMessage = "Não aceita Email com mais de 35 dígitos")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Campo Email do estabelecimento é obrigatório")]
        public String Email { get; set; }

        [StringLength(10, ErrorMessage = "Não aceita CEP com mais de 10 dígitos")]
        [DisplayName("CEP")]
        [Required(ErrorMessage = "Campo CEP do estabelecimento é obrigatório")]
        public int CEP { get; set; }

        [StringLength(35, ErrorMessage = "Não aceita cidade com mais de 35 dígitos")]
        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Campo Cidade do estabelecimento é obrigatório")]
        public String Cidade { get; set; }

        [StringLength(14, ErrorMessage = "Não aceita Nome com mais de 14 dígitos")]
        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Campo telefone do estabelecimento é obrigatório")]
        public int Telefone { get; set; }

        [StringLength(35, ErrorMessage = "Não aceita endereço com mais de 35 dígitos")]
        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Campo endereço do estabelecimento é obrigatório")]
        public String Endereco { get; set; }
    }
}
