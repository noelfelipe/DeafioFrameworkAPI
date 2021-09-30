using DeafioFrameworkAPI.Response;
using DeafioFrameworkAPI.Model;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace DeafioFrameworkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumeroController : ControllerBase
    {
        private const string MENSAGEM_PADRAO_RESULT = "Não possível verficar o seu numero. Por favor, tente novamente em alguns minutos.";

        [HttpPost]
        public ResponseNumero VerficaPrimoeDivisores(ModelNumero modelNumero)
        {
            if (modelNumero is null)
            {
                throw new ArgumentNullException(nameof(modelNumero));
            }

            var result = ResponseNumero.VerificaDivisoresEPrimos(modelNumero.Numero);
            if (result == null)
                throw new ValidationException(result != null ? !string.IsNullOrEmpty(result.Mensagem) ? result.Mensagem : MENSAGEM_PADRAO_RESULT : MENSAGEM_PADRAO_RESULT);
            return result;
        }


    }
}
