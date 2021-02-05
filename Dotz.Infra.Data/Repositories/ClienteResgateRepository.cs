using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Infra.Data.Repositories
{
    public class ClienteResgateRepository : RepositoryBase<ClienteResgate>, IClienteResgateRepository
    {
        public ClienteResgateRepository(Contexto pDb) : base(pDb)
        {
        }
    }
}
