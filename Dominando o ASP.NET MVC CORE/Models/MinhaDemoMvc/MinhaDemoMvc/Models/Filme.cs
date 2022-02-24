using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        //Primary Key com autoincrement
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo título é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 a 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto!")]
        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório.")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        //Informa que a primeira letra precisa ser maiscula e a
        //segunda pode ser de a-z minuscula ou de a-z maiscula
        //aceitando as acentuacoes
        [RegularExpression(@"^[A-Z] + [a-zA-Z\u00C0-\u00FF""\w-]*$", ErrorMessage = "Gênero em formato inválido")]
        [StringLength(30, ErrorMessage = "Máximo 30 caracteres."),
            Required(ErrorMessage ="O campo gênero é obrigatório")]
        public string Genero { get; set; }

        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000!")]
        [Required(ErrorMessage = "Preencha o campo valor")]
        //Banco de dados
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha o campo avaliação")]
        [RegularExpression(@"^[0-5]*$",ErrorMessage = "Somente números")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
