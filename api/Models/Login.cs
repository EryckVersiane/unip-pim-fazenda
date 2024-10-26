using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnipPimFazenda.Models
{
    [Table("login", Schema = "dbo")]
    public class Login
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("data_interecao")]
        public DateTime DataInteracao { get; set; } = DateTime.Now;

        [Column("tipo")]
        public string Tipo { get; set; } = "";

        [Column("usuario_id")]
        public int UsuarioId { get; set; }
    }
}

