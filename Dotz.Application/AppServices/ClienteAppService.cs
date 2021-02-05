using Dotz.Application.Interfaces;
using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Repositories;
using Dotz.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.AppServices
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;
        public ClienteAppService(IClienteService pClienteService) : base(pClienteService)
        {
            this._clienteService = pClienteService;
        }
    }
}
