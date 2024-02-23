using System;

namespace Netcon.Models
{
    public class ConversionResponse
    {
        public int CodigoStatus { get; set; }
        public string? MensagemErro { get; set; } // string anulável
        public DateTime DataHora { get; set; }
        public float ValorConvertido { get; set; }
    }
}

