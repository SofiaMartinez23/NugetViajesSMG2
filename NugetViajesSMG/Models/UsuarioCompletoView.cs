using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetViajesSMG.Models
{
    [Table("USUARIOS")] 
    public class UsuarioCompletoView
    {
        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("EDAD")]
        public int Edad { get; set; }

        [Column("NACIONALIDAD")]
        public string Nacionalidad { get; set; }

        [Column("PREFERENCIASDEVIAJE")]
        public string PreferenciaViaje { get; set; } 

        [Column("CLAVE")]
        public string Clave { get; set; }

        [Column("CONFIRMARCLAVE")]
        public string ConfirmarClave { get; set; }

        [Column("AVATARURL")]
        public string AvatarUrl { get; set; }

        [Column("FECHADEREGISTRO")]
        public DateTime FechaRefistro { get; set; }
    }
}