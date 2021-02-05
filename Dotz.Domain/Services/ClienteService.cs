using Dotz.Domain.Entities;
using Dotz.Domain.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using Dotz.Domain.Interface.Services;
using Dotz.Domain.Interface.Repositories;

namespace Dotz.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository pClienteRepository) : base(pClienteRepository)
        {
            this._clienteRepository = pClienteRepository;
        }
    }
}
