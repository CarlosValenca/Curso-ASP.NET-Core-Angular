using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoEFCore.Models
{
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatorio")]
        [Display(Name = "Nome Completo")]
        [MaxLength(100, ErrorMessage = "O valor máximo é 100")]
        [MinLength(2, ErrorMessage = "O valor mínimo é 2")]
        public string Nome { get; set; }

        [Range(10,1000)]
        [Required(ErrorMessage = "Preencha o Valor")]
        public decimal Valor { get; set; }

        public bool Gratuito { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatoria")]
        [MaxLength(100, ErrorMessage = "O valor máximo é 1000")]
        public string Descricao { get; set; }

        public DateTime Data { get; set; }


    }
}
