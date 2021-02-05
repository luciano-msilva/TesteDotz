using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Repositories
{
    public class ClienteEnderecoRepository : RepositoryBase<ClienteEndereco>, IClienteEnderecoRepository
    {
        public ClienteEnderecoRepository(Contexto pDb) : base(pDb)
        {
        }
    }
}
