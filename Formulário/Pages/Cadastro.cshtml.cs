using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Formulario.Pages
{
 public class CadastroModel : PageModel
{
[BindProperty]
 public Usuario Usuario { get; set; } = new Usuario();
  public void OnGet()
 {
 }
 public IActionResult OnPost()
{
 if (!ModelState.IsValid)
{
  return Page();
 }
 return RedirectToPage("/Index"); 
     }
  }
}
