using CartaoCreditoApplication.Interfaces;
using ContaCartao.Entities;
using ContaCartao.Repositories;
using Proposta.Services;
using Proposta.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CartaoCreditoApplication.Proposta
{
    public class PropostaAppService : IPropostaAppService
    {
        private readonly IPropostaService propostaService;
        private readonly IContaRepository contaRepository;

        public PropostaAppService(IPropostaService propostaService, IContaRepository contaRepository)
        {
            this.propostaService = propostaService;
            this.contaRepository = contaRepository;
        }

        public int InserirProposta(PropostaDTO proposta)
        {
            var propostaDomain = new PropostaCartao
            {
                CPF = proposta.CPF,
                CodigoLojaVendedora = proposta.CodigoLojaVendedora,
                Nome = proposta.Nome,
                Renda = proposta.Renda
            };

            return propostaService.InserirPropostaCartao(propostaDomain);
        }

        public Conta.StatusConta ConsultarStatusAdesao(int adesao)
        {
            Conta conta = contaRepository.GetById(adesao);
            if (conta == null)
                throw new Exception("Não há proposta com esse número de adesão.");

            return conta.Status;
        }
    }
}
