using Dotz.Application.Interfaces;
using Dotz.Domain.Entities;
using Dotz.Domain.Interface.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.AppServices
{
    public class ClienteEnderecoAppService:AppServiceBase<ClienteEndereco>, IClienteEnderecoAppService
    {
        private readonly IClienteEnderecoService _clienteEnderecoService;

        public ClienteEnderecoAppService(IClienteEnderecoService clienteEnderecoService):base(clienteEnderecoService)
        {
            this._clienteEnderecoService = clienteEnderecoService;
        }
    }
}
