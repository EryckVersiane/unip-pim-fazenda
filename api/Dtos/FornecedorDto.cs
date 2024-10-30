using System.Text.Json.Serialization;

namespace UnipPimFazenda.Dtos
{
    public class FornecedorDto
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("cnpj")]
        public string Cnpj { get; set; }

        [JsonPropertyName("telefone")]
        public string Telefone { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("endereço")]
        public string Endereco { get; set; }

    }
}