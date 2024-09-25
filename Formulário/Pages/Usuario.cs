using System.ComponentModel.DataAnnotations;

namespace Formulario.Pages
{
public class Usuario
{
[Required(ErrorMessage = "O nome é obrigatório.")]
public string Nome { get; set; }
 [Required(ErrorMessage = "O e-mail é obrigatório.")]
 [EmailAddress(ErrorMessage = "Formato de e-mail inválido.")]
 public string Email { get; set; }
 [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
 [DataType(DataType.Date)]
 [Display(Name = "Data de Nascimento")]
 [CustomDateValidation(ErrorMessage = "A data de nascimento não pode ser no futuro.")]
 public DateTime DataNascimento { get; set; }
}
public class CustomDateValidation : ValidationAttribute
{
protected override ValidationResult IsValid(object value, ValidationContext validationContext)
{
 if (value is DateTime date && date > DateTime.Now)
 {
  return new ValidationResult(ErrorMessage);
   }
 return ValidationResult.Success;
  }
 }
}
