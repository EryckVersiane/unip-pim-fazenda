using System.Text.Json.Serialization;

namespace UnipPimFazenda.Dtos
{
    public class FornecedorRequestDto
    {
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