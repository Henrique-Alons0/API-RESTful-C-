using System.ComponentModel.DataAnnotations;

namespace chamadosTeste.Models
{
    

    public class Acoes
    {
        [Key]
        
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLenght(15, ErrorMessage = "Este campo deve conter no maximo 15 caracteres")]
        [MinLenght(5, ErrorMessage = "Este campo deve conter no minimo 5 caracteres")]

        public string Nome { get; set; }

        
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O valor precisa ser maior que zero")]
        
        public int Valor { get; set; }
    }
}