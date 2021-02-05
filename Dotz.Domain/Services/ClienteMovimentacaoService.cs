using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Domain.Interface.Services;
using Dotz.Domain.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Services
{
    public class ClienteMovimentacaoService : ServiceBase<ClienteMovimentacao>, IClienteMovimentacaoService
    {
        private readonly IClienteMovimentacaoRepository _clienteMovimentacaoRepository;
        public ClienteMovimentacaoService(IClienteMovimentacaoRepository pClienteMovimentacaoRepository) : base(pClienteMovimentacaoRepository)
        {
            this._clienteMovimentacaoRepository = pClienteMovimentacaoRepository;
        }
    }
}
