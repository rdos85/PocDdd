using ConsistenciaProposta.Entities;
using ConsistenciaProposta.Repositories;
using ConsistenciaProposta.Services;
using ContaCartao.Entities;
using ContaCartao.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsistenciaProposta.Core.Services
{
    public class ConsistenciaPropostaService : IConsistenciaPropostaService
    {
        private readonly IConsistenciaRepository consistenciaRepository;
        private readonly IContaRepository contaRepository;

        public void ConsistirProposta(int adesao)
        {
            // Busca a proposta.
            Conta conta = contaRepository.Get(p => p.Adesao == adesao).FirstOrDefault() 
                ?? throw new Exception("Proposta inexistente.");

            // Busca as consistências vigentes.
            IEnumerable<Consistencia> consistencias = consistenciaRepository.ObterConsistenciasVigentes(DateTime.Today);

            foreach (var consistencia in consistencias)
            {
                if (ConsistenciaAplicavel(consistencia, conta))
                    RegistrarInconsistencia(consistencia, conta);
            }
        }

        private void RegistrarInconsistencia(Consistencia consistencia, Conta conta)
        {
            // Cria a inconsistencia.
            var inconsistencia = new InconsistenciaConta
            {
                IDConta = consistencia.ID,
                IDConsistencia = consistencia.ID
            };

            contaRepository.InserirInconsistencia(inconsistencia);
        }

        private bool ConsistenciaAplicavel(Consistencia consistencia, Conta conta)
        {
            throw new NotImplementedException();
        }
    }
}
