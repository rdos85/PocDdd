using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCartao.Entities
{
    public class Conta
    {
        public int ID { get; set; }
        public int Adesao { get; set; }
        public int CodigoLojaVendedora { get; set; }
        public int CPF { get; set; }
        public string Nome { get; set; }
        public decimal Renda { get; set; }
        public StatusConta Status { get; set; }

        public enum StatusConta
        {
            PendenteAprovacao,
            AguardandoEnvioProcessadora,
            AguardandoRetornoProcessadora,
            RetornadaProcessadora,
            ContaCriada
        }
    }
}
