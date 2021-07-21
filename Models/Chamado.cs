using System.ComponentModel.DataAnnotations;

namespace chamadosTeste.Models
{
    public class Chamado
    {
        [key]
        public int codigo { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime dataInicio { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public DateTime dataFim { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLenght(7, ErrorMessage = "Este campo deve conter exatamente 7 caracteres")]
        [MaxLenght(7, ErrorMessage = "Este campo deve conter exatamente 7 caracteres")]
        public string veiculo { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLenght(25, ErrorMessage = "Este campo deve conter no máximo 25 caracteres")]
        [MaxLenght(5, ErrorMessage = "Este campo deve conter no mínimo 7 caracteres")]
        public string operador { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public Boolean finalizado { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int quantidadeAcoes { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int quantidadeAcoes { get; set;}

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public int acoes { get; set;}

        Public Acoes Acoes { get; set; }
    }
}