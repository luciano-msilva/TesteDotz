using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(Contexto pDb) : base(pDb)
        {
        }
    }
}
