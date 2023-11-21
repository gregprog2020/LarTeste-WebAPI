using System.ComponentModel.DataAnnotations;

namespace LarTeste_WebAPI.Models;

public class Pessoa
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    [MaxLength(100, ErrorMessage = "O nome não pode conter mais de 100 caracteres")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório")]
    public string CPF { get; set; } 

    [Required(ErrorMessage = "A data de nascimento é obrigatória")]
    [DataType(DataType.DateTime)]
    public DateTime DataNascimento { get; set; }

    [EmailAddress(ErrorMessage = "Email inválido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório")]
    public bool Ativo { get; set; }
    public virtual ICollection<Telefone> Telefone { get; set; }
}
