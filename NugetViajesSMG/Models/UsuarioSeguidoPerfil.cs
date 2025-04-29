using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetViajesSMG.Models
{
    [Table("VISTA_USUARIOS_SEGUIDOS_PERFIL")]
    public class UsuarioSeguidoPerfil
    {
        [Key]
        [Column("ID_SEGUIDOR")]
        public int IdSeguidor { get; set; }

        [Column("ID_USUARIO_SEGUIDOR")]
        public int IdUsuarioSeguidor { get; set; }

        [Column("ID_USUARIO_SEGUIDO")]
        public int IdUsuarioSeguido { get; set; }

        [Column("NOMBRE_SEGUIDO")]
        public string NombreSeguido { get; set; }

        [Column("IMAGEN_SEGUIDO")]
        public string ImagenSeguido { get; set; }

        [Column("FECHA_SEGUIMIENTO")]
        public DateTime FechaSeguimiento { get; set; }
    }
}