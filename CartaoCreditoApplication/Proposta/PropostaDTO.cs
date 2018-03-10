using System;
using System.Collections.Generic;
using System.Text;

namespace CartaoCreditoApplication.Proposta
{
    public class PropostaDTO
    {
        public int CodigoLojaVendedora { get; set; }
        public int CPF { get; set; }
        public string Nome { get; set; }
        public decimal Renda { get; set; }
    }
}
