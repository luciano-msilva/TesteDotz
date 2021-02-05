using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(Contexto pDb) : base(pDb)
        {
        }
    }
}
