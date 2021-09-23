using Newtonsoft.Json;

namespace DeafioFrameworkAPI.Response
{
    public class ResponseBase
    {
        [JsonProperty("Mensagem")]
        public string Mensagem { get; set; }
    }
}
