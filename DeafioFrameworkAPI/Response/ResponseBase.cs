using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeafioFrameworkAPI.Response
{
    public class ResponseBase
    {
        [JsonProperty("Mensagem")]
        public string Mensagem { get; set; }
    }
}
