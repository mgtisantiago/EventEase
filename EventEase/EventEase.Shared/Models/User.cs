using System.ComponentModel.DataAnnotations;
namespace EventEase.Shared.Models
{
   public class User
   {
       public int Id { get; set; }
       public required string Name { get; set; }
      
       [Required(ErrorMessage = "El correo electrónico es obligatorio")]
       [EmailAddress(ErrorMessage = "El correo electrónico no es válido")]
       public required string Email { get; set; }


       [Required(ErrorMessage = "La contraseña es obligatoria")]
       public required string Password { get; set; }
      
   }
}