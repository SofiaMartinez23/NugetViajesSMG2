using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NugetViajesSMG.Models
{
    [Table("CHAT")]
    public class Chat
    {
        [Key]
        [Column("ID_MENSAJE")]
        public int IdMensaje { get; set; }

        [Column("ID_USUARIO_REMITENTE")]
        public int IdUsuarioRemitente { get; set; }

        [Column("ID_USUARIO_DESTINATARIO")]
        public int IdUsuarioDestinatario { get; set; }

        [Column("MENSAJE")]
        public string Mensaje { get; set; }

        [Column("FECHA_ENVIO")]
        public DateTime FechaEnvio { get; set; }

        public UsuarioCompletoView UsuarioRemitente { get; set; }
        public UsuarioCompletoView UsuarioDestinatario { get; set; }

    }
}
