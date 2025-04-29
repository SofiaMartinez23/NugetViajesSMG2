using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace NugetViajesSMG.Models
{
    [Table("LUGARESFAVORITOS")]
    public class LugarFavorito
    {
        [Key]
        [Column("ID_FAVORITO")]
        public int IdFavorito { get; set; }

        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("ID_LUGAR")]
        public int IdLugar { get; set; }

        [Column("FECHADEVISITA_LUGAR")]
        public DateTime FechaDeVisitaLugar { get; set; }

        [Column("IMAGEN_LUGAR")]
        public string ImagenLugar { get; set; }

        [Column("NOMBRE_LUGAR")]
        public string NombreLugar { get; set; }

        [Column("DESCRIPCION_LUGAR")]
        public string DescripcionLugar { get; set; }

        [Column("UBICACION_LUGAR")]
        public string UbicacionLugar { get; set; }

        [Column("TIPO_LUGAR")]
        public string TipoLugar { get; set; }
    }
}
