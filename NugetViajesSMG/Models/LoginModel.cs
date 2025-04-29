using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetViajesSMG.Models
{
    public class LoginModel
    {
        public string Email { get; set; }
        public string Clave { get; set; }
    }
}
