using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace WMSEssential.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El campo nid es obligatorio.")]
        public string NID { get; set; }

        
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-.]?([0-9]{2})?[-.]?([0-9]{5})$", ErrorMessage = "El formato de teléfono no es válido.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "El campo correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es una dirección de correo electrónico válido")]
        public string Email { get; set; }

        
        [Display(Name = "Contrasena")]
        [Required(ErrorMessage = "El campo contaseña es obligatorio.")]
        [StringLength(100, ErrorMessage = "El número de caracteres de {0] debe ser al menos {2}.", MinimumLength = 6)]
        public string Password { get; set; }
    }
}
