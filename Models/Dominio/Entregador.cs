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
    [Table("Entregadores")]
    public class Entregador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int Id { get; set; }

        [StringLength(35, ErrorMessage = "Não aceita Nome com mais de 35 dígitos")]
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo nome do entregador é obrigatório")]
        public String Nome { get; set; }

        [StringLength(14, ErrorMessage = "Não aceita CPF com mais de 14 dígitos")]
        [DisplayName("CPF")]
        [Required(ErrorMessage = "Campo CPF do entregador é obrigatório")]
        [Remote("ValidarCPF", "entregador", ErrorMessage = "CPF Inválido!!!")]
        public int CPF { get; set; }

        [StringLength(10, ErrorMessage = "DD/MM/AAAA")]
        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Campo nome do entregador é obrigatório")]
        [Remote("ValidarData", "entregador", ErrorMessage = "Data Inválida!!!")]
        public String DataNascimento { get; set; }


        [StringLength(35, ErrorMessage = "Não aceita Email com mais de 35 dígitos")]
        [DisplayName("Email")]
        [Required(ErrorMessage = "Campo Email do entregador é obrigatório")]
        public String Email { get; set; }

        [StringLength(10, ErrorMessage = "Não aceita CEP com mais de 10 dígitos")]
        [DisplayName("CEP")]
        [Required(ErrorMessage = "Campo CEP do entregador é obrigatório")]
        public int CEP { get; set; }


        [StringLength(35, ErrorMessage = "Não aceita cidade com mais de 35 dígitos")]
        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Campo Cidade do entregador é obrigatório")]
        public String Cidade { get; set; }

        [StringLength(14, ErrorMessage = "Não aceita Nome com mais de 14 dígitos")]
        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Campo telefone do entregador é obrigatório")]
        public int Telefone { get; set; }

        [Display(Name = "CNH")]
        [StringLength(14, ErrorMessage = "Não aceita CNH com mais de 14 dígitos")]
        [Required(ErrorMessage = "Campo CNH é obrigatorio")]
        public int CNH { get; set; }
    }
}
