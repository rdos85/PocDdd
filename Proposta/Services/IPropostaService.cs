using Proposta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proposta.Services
{
    public interface IPropostaService
    {
        /// <summary>
        /// Insere uma proposta de cartão e retorna a adesão criada.
        /// </summary>
        /// <param name="proposta"></param>
        /// <returns></returns>
        int InserirPropostaCartao(PropostaCartao proposta);
    }
}
