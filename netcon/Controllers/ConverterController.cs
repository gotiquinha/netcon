using Microsoft.AspNetCore.Mvc;
using Netcon.Models;
using System;

namespace Netcon.Controllers
{
    [ApiController]
    [Route("api/v1/converter")]
    public class ConverterController : ControllerBase
    {
        // 1 ano-luz é aproximadamente 9.461 trilhões de quilômetros
        private const double QuilometrosPorAnoLuz = 9.461e12;

        [HttpGet("paraQuilometros")]
        public ActionResult<ConversionResponse> ConverterAnosLuzParaQuilometros([FromQuery] double anosLuz)
        {
            if (anosLuz < 1)
            {
                return BadRequest(new ConversionResponse
                {
                    CodigoStatus = 400,
                    MensagemErro = "Valor inválido. O valor deve ser numérico e maior ou igual a 1.",
                    DataHora = DateTime.Now,
                    ValorConvertido = 0
                });
            }

            double quilometros = anosLuz * QuilometrosPorAnoLuz;

            return Ok(new ConversionResponse
            {
                CodigoStatus = 200,
                MensagemErro = string.Empty,
                DataHora = DateTime.Now,
                ValorConvertido = (float)quilometros
            });
        }

        [HttpGet("paraAnosLuz")]
        public ActionResult<ConversionResponse> ConverterQuilometrosParaAnosLuz([FromQuery] double quilometros)
        {
            if (quilometros < 1)
            {
                return BadRequest(new ConversionResponse
                {
                    CodigoStatus = 400,
                    MensagemErro = "Valor inválido. O valor deve ser numérico e maior ou igual a 1.",
                    DataHora = DateTime.Now,
                    ValorConvertido = 0
                });

            }

            double anosLuz = quilometros / QuilometrosPorAnoLuz;

            return Ok(new ConversionResponse
            {
                CodigoStatus = 200,
                MensagemErro = string.Empty,
                DataHora = DateTime.Now,
                ValorConvertido = (float)anosLuz
            });

        }
    }
}
