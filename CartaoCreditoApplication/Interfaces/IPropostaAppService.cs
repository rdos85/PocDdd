using CartaoCreditoApplication.Proposta;
using ContaCartao.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CartaoCreditoApplication.Interfaces
{
    public interface IPropostaAppService
    {
        int InserirProposta(PropostaDTO proposta);
        Conta.StatusConta ConsultarStatusAdesao(int adesao);
    }
}
