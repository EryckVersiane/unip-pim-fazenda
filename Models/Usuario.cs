using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnipPimFazenda.Models
{
    [Table("usuario", Schema = "dbo")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("usuario")]
        public string UsuarioNome { get; set; } = ""; // Renomeei para "UsuarioNome" para seguir boas práticas de nomenclatura

        [Column("senha")]
        public string Senha { get; set; } = "";

        [Column("estado")]
        public string Estado { get; set; } = "";

        [Column("pessoa_id")]
        public int PessoaId { get; set; } // Ajustei a propriedade para ter o nome correto e associada à coluna correta
    }
}
