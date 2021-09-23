using Newtonsoft.Json;
using System.Collections.Generic;

namespace DeafioFrameworkAPI.Response
{
    public class ResponseNumero : ResponseBase
    {
        [JsonProperty("Numero")]
        public int Numero { get; set; }
        [JsonProperty("ListaDivisores")]
        public List<int> ListaDivisores { get; set; }
        [JsonProperty("ListaNumerosPrimos")]
        public List<int> ListaNumerosPrimos { get; set; }
        [JsonProperty("DivisoresEmLinha")]
        public string DivisoresEmLinha => EmLinha(ListaDivisores);
        [JsonProperty("NumerosPrimosEmLinha")]
        public string NumerosPrimosEmLinha => EmLinha(ListaNumerosPrimos);

        public string EmLinha(List<int> lista)
        {
            var result = "";
            for (int i = 0; i < lista.Count; i++)
            {
                result += lista.Count != i + 1 ? lista[i] + ", " : lista[i].ToString();
            }
            return result;
        }

        public static ResponseNumero DivisoresEPrimos(int num)
        {
            var divisores = new List<int>();
            var primos = new List<int>();

            for (var NumeroDivisor = 1; NumeroDivisor <= num; NumeroDivisor++)
            {
                if (num % NumeroDivisor == 0)
                {
                    divisores.Add(NumeroDivisor);
                }
            }
            foreach (var item in divisores)
            {
                int cont = 0;
                for (int i = 1; i <= item; i++)
                {
                    if (item % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    primos.Add(item);
                }
            }
            var response = new ResponseNumero
            {
                Numero = num,
                ListaDivisores = divisores,
                ListaNumerosPrimos = primos
            };
            return response;
        }
    }
}
