using System.Text.Json.Serialization;

namespace UnipPimFazenda.Dtos
{
    public class ProdutoRequestDto
    {
        [JsonPropertyName("nome")]
        public string Nome { get; set; }

        [JsonPropertyName("preço")]
        public string Preco { get; set; }

        [JsonPropertyName("quantidade")]
        public int Quantidade { get; set; }

        [JsonPropertyName("peso")]
        public string Peso { get; set; }

        [JsonPropertyName("Unidade de medida")]
        public string UnidadeMedida { get; set; }

    }
}