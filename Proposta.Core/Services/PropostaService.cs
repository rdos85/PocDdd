using ContaCartao.Entities;
using ContaCartao.Repositories;
using Proposta.Services;
using Proposta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proposta.Core.Services
{
    class PropostaService : IPropostaService
    {
        private readonly IContaRepository contaRepository;

        public PropostaService(IContaRepository contaRepository)
        {
            this.contaRepository = contaRepository;
        }

        public int InserirPropostaCartao(PropostaCartao proposta)
        {
            // Verifica se já existe uma adesão para o CPF.
            if (contaRepository.Get(p => p.CPF == proposta.CPF).Any())
                throw new Exception("Já existe proposta para o CPF.");

            var adesao = GerarAdesao();

            var novaConta = new Conta
            {
                CPF = proposta.CPF,
                Adesao = adesao,
                CodigoLojaVendedora = proposta.CodigoLojaVendedora,
                Nome = proposta.Nome,
                Renda = proposta.Renda,
                Status = Conta.StatusConta.PendenteAprovacao
            };

            contaRepository.Insert(novaConta);

            return adesao;
        }

        private int GerarAdesao()
        {
            return 1;
        }
    }
}
