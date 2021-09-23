using Newtonsoft.Json;

namespace DeafioFrameworkAPI.Model
{
    public class ModelNumero
    {
        [JsonProperty("mensagem")]
        public int Numero { get; set; }
    }
}
