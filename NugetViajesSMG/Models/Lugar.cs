using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetViajesSMG.Models
{
    [Table("LUGARES")]
    public class Lugar
    {
        [Key]
        [Column("ID_LUGAR")]
        public int IdLugar { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }

        [Column("UBICACION")]
        public string Ubicacion { get; set; }

        [Column("CATEGORIA")]
        public string Categoria { get; set; }

        [Column("HORARIO")]
        public DateTime Horario { get; set; }

        [Column("IMAGEN")]
        public string Imagen { get; set; }

        [Column("TIPO")]
        public string Tipo { get; set; }

        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }
    }
}