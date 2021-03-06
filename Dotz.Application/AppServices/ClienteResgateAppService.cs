﻿using Dotz.Application.Interfaces;
using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.AppServices
{
    public class ClienteResgateAppService : AppServiceBase<ClienteResgate>, IClienteResgateAppService
    {
        private readonly IClienteResgateService _clienteResgateService;

        public ClienteResgateAppService(IClienteResgateService clienteResgateService):base(clienteResgateService)
        {
            this._clienteResgateService = clienteResgateService;
        }
    }
}
