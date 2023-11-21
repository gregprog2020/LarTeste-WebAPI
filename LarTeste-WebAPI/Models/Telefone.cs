using System.ComponentModel.DataAnnotations;

namespace LarTeste_WebAPI.Models
{
    public class Telefone
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O tipo do telefone é obrigatório")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "O numero do telefone é obrigatório")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O Id da pessoa é obrigatório")]
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }
    }
}
