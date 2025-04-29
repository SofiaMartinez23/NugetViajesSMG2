using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetViajesSMG.Models
{
    [Table("COMENTARIOS")]
    public class Comentario
    {
        [Key]
        [Column("ID_COMENTARIO")]
        public int IdComentario { get; set; }

        [Column("ID_LUGAR")]
        public int IdLugar { get; set; }

        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("COMENTARIO")]
        public string Comentarios { get; set; }

        [Column("FECHA_COMENTARIO")]
        public DateTime FechaComentario { get; set; }

        [Column("NOMBRE_USUARIO")]
        public string? NombreUsuario { get; set; }
        
    }
}
