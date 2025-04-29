using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetViajesSMG.Models
{
    [Table("SEGUIDORES")]
    public class Seguidor
    {
        [Key]
        [Column("ID_SEGUIDOR")]
        public int IdSeguidor { get; set; }

        [Column("ID_USUARIO_SEGUIDOR")]
        public int IdUsuarioSeguidor { get; set; }

        [Column("ID_USUARIO_SEGUIDO")]
        public int IdUsuarioSeguido { get; set; }

        [Column("FECHA_SEGUIMIENTO")]
        public DateTime FechaSeguimiento { get; set; }

        [ForeignKey("IdUsuarioSeguidor")]
        public UsuarioCompletoView UsuarioSeguidor { get; set; } 

        [ForeignKey("IdUsuarioSeguido")]
        public UsuarioCompletoView UsuarioSeguido { get; set; }
    }
}