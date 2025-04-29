using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetViajesSMG.Models
{

    public class UsuarioModel
    {

        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        public string Email { get; set; }

        public int Edad { get; set; }

        public string Nacionalidad { get; set; }

        public string PreferenciaViaje { get; set; }

        public string Clave { get; set; }

        public string ConfirmarClave { get; set; }

        public string AvatarUrl { get; set; }

        public DateTime FechaRefistro { get; set; }
    }
}