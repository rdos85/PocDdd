using BaseClass;
using ConsistenciaProposta.Entities;
using ContaCartao.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCartao.Repositories
{
    public interface IContaRepository : IRepositoryCRUD<Conta>
    {
        void InserirInconsistencia(InconsistenciaConta inconsistencia);
    }
}
