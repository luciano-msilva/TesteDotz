using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Domain.Interface.Services;
using Dotz.Domain.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Services
{
    public class ClienteEnderecoService : ServiceBase<ClienteEndereco>, IClienteEnderecoService
    {
        private readonly IClienteEnderecoRepository _clienteEnderecoRepository;
        public ClienteEnderecoService(IClienteEnderecoRepository pClienteEnderecoRepository) : base(pClienteEnderecoRepository)
        {
            this._clienteEnderecoRepository = pClienteEnderecoRepository;
        }
    }
}
