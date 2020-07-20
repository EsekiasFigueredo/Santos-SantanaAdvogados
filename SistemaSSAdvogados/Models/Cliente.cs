using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaSSAdvogados.Models
{
    [Table("CLienteTb")]
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Documento { get; set; }

        [Required]
        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        public DateTime DataCadastro { get; set; }

        [Required]
        public string Telefone { get; set; }

        public bool Ativo { get; set; } = true;

        public bool Validacao()
        {
            return true;
        }
    }
}