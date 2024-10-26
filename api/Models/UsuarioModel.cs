using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnipPimFazenda.Models
{
    [Table("usuario", Schema = "dbo")]
    public class UsuarioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string Nome { get; set; } 

        [Column("cpf")]
        public string Cpf{ get; set; } 

        [Column("telefone")]
        public string Telefone { get; set; }


        [Column("email")]
        public string Email { get; set; }

        [Column("senha")]
        public string Senha { get; set; }
    }
}