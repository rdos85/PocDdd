using BaseClass;
using ConsistenciaProposta.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsistenciaProposta.Repositories
{
    public interface IConsistenciaRepository : IRepositoryCRUD<Consistencia>
    {
        IEnumerable<Consistencia> ObterConsistenciasVigentes(DateTime dataReferencia);
    }
}
