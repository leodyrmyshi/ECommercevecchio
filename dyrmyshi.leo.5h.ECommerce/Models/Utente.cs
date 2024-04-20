using System.ComponentModel.DataAnnotations;
namespace dyrmyshi.leo._5h.ECommerce.Models;
public class Utente
{
    [Required(ErrorMessage = "Il campo Username è obbligatorio.")]
    [Display(Name = "Username")]
    public string? Username { get; set; }

    [Required(ErrorMessage = "Il campo Email è obbligatorio.")]
    [EmailAddress(ErrorMessage = "Il campo Email non è un indirizzo email valido.")]
    [Display(Name = "Email")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Il campo Password è obbligatorio.")]
    [DataType(DataType.Password)]
    [StringLength(100, ErrorMessage = "La {0} deve essere lunga almeno {2} caratteri.", MinimumLength = 6)]
    [Display(Name = "Password")]
    public string? Password { get; set; }

    internal static void Registrati()
    {
        throw new NotImplementedException();
    }
}
